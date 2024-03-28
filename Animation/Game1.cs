using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Animation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        Flower f;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = Globals.isMouseVisible;
            _graphics.PreferredBackBufferWidth = Globals.WIDTH;
            _graphics.PreferredBackBufferHeight = Globals.HEIGHT;
            _graphics.IsFullScreen = Globals.isFullScreen;
            Globals.Content = Content;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.sb = new SpriteBatch(GraphicsDevice);

            Animations.LoadAll();
            Textures.LoadAll();
            for (int i = 0; i < Globals.WIDTH; i += 40)
            {
                ObjectDB.AllGameObjects.Add(new Flower(i, Globals.HEIGHT-64));
            }
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            Globals.gt = gameTime;
            ObjectDB.UpdateAll();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Globals.BGCOLOR);

            Globals.sb.Begin();
            ObjectDB.DrawAll();
            Globals.sb.End();

            base.Draw(gameTime);
        }
    }
}
