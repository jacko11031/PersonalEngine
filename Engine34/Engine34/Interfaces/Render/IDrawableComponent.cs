﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Interfaces.Render
{
    public interface IDrawableComponent
    {

        void Draw(SpriteBatch spriteBatch);
    }
}