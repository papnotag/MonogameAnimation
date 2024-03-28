using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation
{
    internal class Animations
    {
        public static void LoadAll()
        {
            loadFlowerIdle();
        }

        public static List<Texture2D> FlowerIdle = new List<Texture2D>();
        public static void loadFlowerIdle()
        {
            string path = "Content/FlowerIdle";
            for(int i = 1; i <= Directory.GetFiles(path).Length; i++)
            {
                FlowerIdle.Add(Globals.Content.Load<Texture2D>($"FlowerIdle/{i}"));
            }
        }
    }
}
