using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodgem
{
    class PlayerShip : GameObject
    {
        public PlayerShip() : base("spr_playership")
        {

        }

        public override void Init()
        {
            base.Init();
            velocity.X = 40;
            velocity.Y = 40;
            position.X = GameEnvironment.Screen.X / 2 - this.texture.Width / 2;
            position.Y = GameEnvironment.Screen.Y - this.texture.Height;
        }
        public override void Update()
        {
            ////INPUT EN BORDERCOLLISION
            //RIGHT KEYS
            if (GameEnvironment.keyboardState.IsKeyDown(Keys.Right))
            {
                if (position.X > GameEnvironment.Screen.X-texture.Width)
                {
                    position.X = GameEnvironment.Screen.X - texture.Width;
                }
                position.X += velocity.X;
                velocity.X = 0;
            }
            //LEFT KEYS
            if (GameEnvironment.keyboardState.IsKeyDown(Keys.Left))
            {
                if (position.X < 0)
                {
                    position.X = 0;
                }
                position.X -= velocity.X;
                velocity.X = 0;
            }
            //VELOCITY RESET
            if (GameEnvironment.keyboardState.IsKeyUp(Keys.Right) && GameEnvironment.keyboardState.IsKeyUp(Keys.Left)) velocity.X = 40; 
            if (GameEnvironment.keyboardState.IsKeyUp(Keys.Up) && GameEnvironment.keyboardState.IsKeyUp(Keys.Down)) velocity.Y = 40; 



        }
    }
}


