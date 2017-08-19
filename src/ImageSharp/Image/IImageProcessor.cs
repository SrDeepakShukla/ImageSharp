﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Threading.Tasks;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Primitives;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Encapsulates methods to alter the pixels of an image.
    /// </summary>
    /// <typeparam name="TPixel">The pixel format.</typeparam>
    public interface IImageProcessor<TPixel>
        where TPixel : struct, IPixel<TPixel>
    {
        /// <summary>
        /// Gets or sets the parallel options for processing tasks in parallel.
        /// </summary>
        ParallelOptions ParallelOptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to compress
        /// or expand individual pixel colors the value on processing.
        /// </summary>
        bool Compand { get; set; }

        /// <summary>
        /// Applies the process to the specified portion of the specified <see cref="ImageBase{TPixel}"/>.
        /// </summary>
        /// <param name="source">The source image. Cannot be null.</param>
        /// <param name="sourceRectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to draw.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="source"/> is null.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// <paramref name="sourceRectangle"/> doesnt fit the dimension of the image.
        /// </exception>
        void Apply(Image<TPixel> source, Rectangle sourceRectangle);
    }
}
