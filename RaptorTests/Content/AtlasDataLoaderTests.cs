﻿// <copyright file="AtlasDataLoaderTests.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

namespace RaptorTests.Content
{
    using System.Drawing;
    using System.Text.Json;
    using FileIO.Core;
    using Moq;
    using Raptor.Content;
    using Xunit;

    public class AtlasDataLoaderTests
    {
        private readonly Mock<ITextFile> mockTextFile;

        public AtlasDataLoaderTests()
        {
            this.mockTextFile = new Mock<ITextFile>();

            var textFileData = new Rectangle[]
            {
                new Rectangle(11, 22, 33, 44),
                new Rectangle(55, 66, 77, 88),
            };
            this.mockTextFile.Setup(m => m.Load(It.IsAny<string>())).Returns(() =>
            {
                return JsonSerializer.Serialize(textFileData);
            });
        }

        #region Method Tests
        [Fact]
        public void Load_WhenInvoked_LoadsTextureAtlasData()
        {
            // Arrange
            var loader = new AtlasDataLoader<Rectangle>(this.mockTextFile.Object);
            var expected = new Rectangle[]
            {
                new Rectangle(11, 22, 33, 44),
                new Rectangle(55, 66, 77, 88),
            };

            // Act
            var actual = loader.Load("test-file");

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
