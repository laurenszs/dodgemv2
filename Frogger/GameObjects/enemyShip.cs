using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodgem.GameObjects
{
    class EnemyShip : GameObject
    {

        public EnemyShip(string assetname, float posX, float posY, float velY) : base(assetname)
        {
            position.X = posX;
            position.Y = posY;
            velocity.Y = velY;
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
                this.position.X = random.Next(0, GameEnvironment.Screen.X - texture.Width);
                position.Y = 1;
            }
        }
    }
}
