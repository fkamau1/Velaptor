﻿// <copyright file="IGPUBufferFactory.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

namespace Velaptor.Factories;

using OpenGL;
using OpenGL.Buffers;

/// <summary>
/// Creates various types of GPU buffers.
/// </summary>
internal interface IGPUBufferFactory
{
    /// <summary>
    /// Creates an instance of the <see cref="TextureGPUBuffer"/> class.
    /// </summary>
    /// <returns>A GPU buffer class.</returns>
    /// <remarks>
    ///     The instance is a singleton.  Every call to this method will return the same instance.
    /// </remarks>
    IGPUBuffer<TextureBatchItem> CreateTextureGPUBuffer();

    /// <summary>
    /// Creates an instance of the <see cref="FontGPUBuffer"/> class.
    /// </summary>
    /// <returns>A GPU buffer class.</returns>
    /// <remarks>
    ///     The instance is a singleton.  Every call to this method will return the same instance.
    /// </remarks>
    IGPUBuffer<FontGlyphBatchItem> CreateFontGPUBuffer();

    /// <summary>
    /// Creates an instance of the <see cref="RectGPUBuffer"/> class.
    /// </summary>
    /// <returns>A GPU buffer class.</returns>
    /// <remarks>
    ///     The instance is a singleton.  Every call to this method will return the same instance.
    /// </remarks>
    IGPUBuffer<RectBatchItem> CreateRectGPUBuffer();
}
