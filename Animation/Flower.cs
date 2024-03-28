using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation
{
    internal class Flower : IGameObject
    {
        int x, y, w, h;
        Texture2D texture;
        Rectangle rect;
        AnimationHandler animationHandler;

        public Flower(int x = 100, int y = 500)
        {
            this.x = x;
            this.y = y;
            this.texture = Textures.FlowerBase;
            this.w = texture.Width;
            this.h = texture.Height;
            this.rect = new Rectangle(x, y, w, h);
            this.animationHandler = new AnimationHandler(texture, "Content/FlowerIdle", 100);
        }

        public void Update()
        {
            this.texture = animationHandler.NewTexture();
        }

        public void Draw()
        {
            Globals.sb.Draw(texture, rect, Color.White);
        }
    }
}
