﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.IO;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Bmp;
using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp
{
    /// <summary>
    /// Extension methods for the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static partial class ImageExtensions
    {
        /// <summary>
        /// Saves the image to the given stream with the bmp format.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="stream">The stream to save the image to.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if the stream is null.</exception>
        public static void SaveAsBmp<TPixel>(this Image<TPixel> source, Stream stream)
            where TPixel : struct, IPixel<TPixel>
                        => source.SaveAsBmp(stream, null);

        /// <summary>
        /// Saves the image to the given stream with the bmp format.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="stream">The stream to save the image to.</param>
        /// <param name="encoder">The encoder to save the image with.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if the stream is null.</exception>
        public static void SaveAsBmp<TPixel>(this Image<TPixel> source, Stream stream, BmpEncoder encoder)
            where TPixel : struct, IPixel<TPixel>
                        => source.Save(stream, encoder ?? source.GetConfiguration().ImageFormatsManager.FindEncoder(ImageFormats.Bmp));
    }
}
