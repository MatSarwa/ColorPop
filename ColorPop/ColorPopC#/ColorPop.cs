using System;

namespace ColorLibrary
{
    public static class ColorProcessor
    {

        public static void ProcessPixel(
            int originalR, int originalG, int originalB,
            int tolerance, int targetR, int targetG, int targetB,
            float[] results)
        {
            if (results == null || results.Length != 3)
                throw new ArgumentException("Tablica wyników musi mieć długość 3.");


            float rDiff = Math.Abs(originalR - targetR);
            float gDiff = Math.Abs(originalG - targetG);
            float bDiff = Math.Abs(originalB - targetB);

  
            if (rDiff <= tolerance && gDiff <= tolerance && bDiff <= tolerance)
            {
                results[0] = originalR;
                results[1] = originalG;
                results[2] = originalB;
            }
            else
            {
             
                float brightness = 0.299f * originalR + 0.587f * originalG + 0.114f * originalB;

             
                results[0] = brightness;
                results[1] = brightness;
                results[2] = brightness;
            }
        }
    }
}
