﻿// Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Drawables;
using osu.Framework.Input;
using OpenTK;

namespace osu.Framework.Graphics.Cursor
{
    public class CursorContainer : Container
    {
        protected Drawable ActiveCursor;

        public CursorContainer()
        {
            Depth = float.MaxValue;
            RelativeSizeAxes = Axes.Both;
        }

        public override void Load(BaseGame game)
        {
            base.Load(game);

            Add(ActiveCursor = CreateCursor());
        }

        protected virtual Drawable CreateCursor() => new Cursor();

        public override bool Contains(Vector2 screenSpacePos) => true;

        protected override bool OnMouseMove(InputState state)
        {
            ActiveCursor.Position = state.Mouse.Position;
            return base.OnMouseMove(state);
        }

        class Cursor : Box
        {
            public Cursor()
            {
                Size = new Vector2(5, 5);
                Origin = Anchor.Centre;
            }
        }
    }
}
