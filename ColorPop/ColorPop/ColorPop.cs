using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorLibrary;

namespace BasicWindowsForm
{
    public static class ColorPop
    {
        [DllImport(@"C:\Users\xyz89\OneDrive\Pulpit\studia\semestr 5\asembler\ColorPop - instrukcja asm\ColorPop\x64\Debug\ColorPopAsm.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ProcessPixel(
            int originalR,
            int originalG,
            int originalB,
            int tolerance,
            int targetR,
            int targetG,
            int targetB,
            [Out] float[] results
        );

        private static bool isFirstPixelProcessed = false;
        private static double firstPixelTime = 0;

        private static int ClampColor(float value)
        {
            if (value < 0) return 0;
            if (value > 255) return 255;
            return (int)value;
        }

        public static Color GetColorPop(Color originalColor, Color targetColor, int tolerance, bool useAsm, TextBox timeLabel)
        {
            float[] results = new float[3];
            int r = originalColor.R;
            int g = originalColor.G;
            int b = originalColor.B;

            Stopwatch stopwatch = null;
            if (!isFirstPixelProcessed)
            {
                stopwatch = Stopwatch.StartNew();
            }

            if (useAsm)
            {
                try
                {
                    ProcessPixel(
                        r, g, b,
                        tolerance,
                        targetColor.R,
                        targetColor.G,
                        targetColor.B,
                        results
                    );

                    if (!isFirstPixelProcessed)
                    {
                        stopwatch?.Stop();
                        firstPixelTime = stopwatch?.Elapsed.TotalMilliseconds * 1000.0 ?? 0;
                        isFirstPixelProcessed = true;
                        timeLabel.Text = firstPixelTime.ToString("F2") + " μs";
                    }

                    return Color.FromArgb(
                        ClampColor(results[0]),
                        ClampColor(results[1]),
                        ClampColor(results[2])
                    );
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error in ProcessPixel: {ex.Message}");
                    return originalColor; 
                }
            }
            else
            {
                ColorProcessor.ProcessPixel(
                    r, g, b,
                    tolerance,
                    targetColor.R,
                    targetColor.G,
                    targetColor.B,
                    results
                );

                if (!isFirstPixelProcessed)
                {
                    stopwatch?.Stop();
                    firstPixelTime = stopwatch?.Elapsed.TotalMilliseconds * 1000.0 ?? 0;
                    isFirstPixelProcessed = true;
                    timeLabel.Text = firstPixelTime.ToString("F2") + " μs";
                }

                return Color.FromArgb(
                    ClampColor(results[0]),
                    ClampColor(results[1]),
                    ClampColor(results[2])
                );
            }
        }

        public static Bitmap ConvertToGrayscale(Bitmap inputImage, Color targetColor, int tolerance, int maxDegreeOfParallelism, TextBox timeLabel, bool useAsm)
        {
            isFirstPixelProcessed = false;
            firstPixelTime = 0;

            int width = inputImage.Width;
            int height = inputImage.Height;

            Color[] pixels = new Color[width * height];

            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = maxDegreeOfParallelism
            };

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    pixels[y * width + x] = inputImage.GetPixel(x, y);
                }
            }

            Color[] processedPixels = new Color[width * height];

            Parallel.For(0, width * height, parallelOptions, i =>
            {
                Color pixelColor = pixels[i];
                processedPixels[i] = GetColorPop(pixelColor, targetColor, tolerance, useAsm, timeLabel);
            });

            Bitmap processedImage = new Bitmap(width, height);

            for (int i = 0; i < width * height; i++)
            {
                int x = i % width;
                int y = i / width;
                processedImage.SetPixel(x, y, processedPixels[i]);
            }

            return processedImage;
        }
    }
}