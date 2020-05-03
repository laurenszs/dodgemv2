using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodgem.GameObjects
{
    class Playerlife : GameObject
    {

        public Playerlife(string assetname, float posX, float posY) : base(assetname)
        {
            position.X = posX;
            position.Y = posY;

        }
        public override void Update()
        {
            position.Y += velocity.Y;
            if (position.Y + texture.Height < 0)
            {
                position.Y = GameEnvironment.Screen.Y;
            }
            if (position.Y - texture.Height > GameEnvironment.Screen.Y)
            {
                position.X = random.Next(0, GameEnvironment.Screen.X - texture.Width);
                position.Y = 1;
            }
        }
    }
}
