# ColorPop

## Overview
ColorPop is an image processing application that demonstrates the performance difference between high-level and assembly language implementations. The project provides two libraries - one written in C# and another in Assembly - that perform the same color isolation effect, allowing users to compare execution times and efficiency.

The application selectively preserves a chosen color in an image while converting the remaining pixels to grayscale, creating a striking visual effect where only the selected color appears in the original vibrant form.

## Key Features
- Dual implementation: C# and Assembly for performance comparison
- Real-time processing time measurement
- Color selection tool to pick which color to preserve
- Adjustable tolerance settings to control the color matching strictness
- Multi-threading capability for improved performance
- Simple image loading and saving functionality

## User Interface
The application displays the original image on the left and processed image on the right. Users can select between ASM/C# implementations, pick a reference color, adjust tolerance, control thread count, and load/save images. Processing time is displayed for performance comparison.

## How It Works
The algorithm compares each pixel's RGB values with a selected reference color. Pixels within tolerance remain unchanged, while others are converted to grayscale, highlighting only the chosen color range.

## Technical Implementation
### C# Library
- Object-oriented approach with multi-threading capabilities
- Managed code for pixel manipulation

### Assembly Library
- Low-level implementation for maximum performance
- Direct memory access and optimized calculations
- Grayscale conversion using weighted RGB formula

## Supported Image Formats
- JPG/JPEG
- PNG
- BMP
- GIF
- TIFF
