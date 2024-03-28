using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation
{
    internal class AnimationHandler
    {
        public Texture2D current_texture;
        string path;
        int duration;

        int WhichOne;
        int Direction;

        bool TimeTaken;
        double Time1;
        public AnimationHandler(Texture2D texture, string path, int duration)
        {
            this.current_texture = texture;
            this.path = path;
            this.duration = duration;
            WhichOne = 3;
            Direction = 1;
            TimeTaken = false;
        }

        public Texture2D NewTexture()
        {
            if(!TimeTaken)
            {
                Time1 = Globals.gt.TotalGameTime.TotalMilliseconds;
                TimeTaken = true;
            }
            if (Globals.gt.TotalGameTime.TotalMilliseconds - Time1 <= duration) return current_texture;

            Time1 = Globals.gt.TotalGameTime.TotalMilliseconds;

            int max = Directory.GetFiles(path).Length;

            if (WhichOne >= max || WhichOne <= 1) Direction *= -1;
            WhichOne += Direction;

            current_texture = Animations.FlowerIdle[WhichOne - 1];

            return current_texture;
        }
    }
}
