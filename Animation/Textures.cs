using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation
{
    internal class Textures
    {
        public static void LoadAll()
        {
            LoadFlower();
        }

        public static Texture2D FlowerBase;
        public static void LoadFlower()
        {
            FlowerBase = Globals.Content.Load<Texture2D>("FlowerIdle/3");
        }
    }
}
