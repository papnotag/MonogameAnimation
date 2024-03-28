using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation
{
    internal class Globals
    {
        //COMPONENTS
        public static SpriteBatch sb;
        public static GameTime gt;
        public static ContentManager Content;

        //WINDOW
        public static int WIDTH = 1920;
        public static int HEIGHT = 1080;
        public static bool isFullScreen = true;
        public static bool isMouseVisible = false;
        public static Color BGCOLOR = Color.Black;
    }
}
