﻿// Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using OpenTK.Graphics.ES20;

namespace osu.Framework.Graphics.Textures
{
    public class RawTexture
    {
        public int Width, Height;
        public PixelFormat PixelFormat;
        public byte[] Pixels;
    }
}