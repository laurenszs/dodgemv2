using Dodgem.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dodgem
{
    class PlayingState : GameState
    {
        int metVel = 3, shipVel = 5, beamVel = 14;
        int meteorAmount = 3, shipAmount = 2, beamAmount = 1;
        int heartAmount;
        int[] obstacle = new int[] { 10, 35, 110, 300, 200, 264, 70, 38 };

        int[] heartX = new int[] { 0, 37, 74 };
        PlayerShip thePlayer = new PlayerShip();
        public Random random = new Random();

        public PlayingState()
        {
            heartAmount = 3;
            gameObjectList.Add(new GameObject("spr_background"));

            gameObjectList.Add(thePlayer);


            for (int iMeteor = 0; iMeteor < meteorAmount; iMeteor++)
            {
                gameObjectList.Add(new Meteorite("meteorite_one", obstacle[iMeteor], obstacle[iMeteor], metVel));
            }
            for (int iShip = 0; iShip < shipAmount; iShip++)
            {
                gameObjectList.Add(new EnemyShip("spr_ship", obstacle[iShip], obstacle[iShip], shipVel));
            }
            for (int iBeam = 0; iBeam < beamAmount; iBeam++)
            {
                gameObjectList.Add(new LaserBeam("spr_laserbeam", obstacle[iBeam], obstacle[iBeam], beamVel));
            }


        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            System.Diagnostics.Debug.WriteLine("hearts: " + heartAmount);
            foreach (GameObject gameObject in gameObjectList)
            {
                if (gameObject.Overlaps(thePlayer))
                {
                    if (gameObject is Meteorite)
                    {
                        heartAmount -= 1;
                    }
                    if (gameObject is EnemyShip)
                    {
                     
                    }
                    if (gameObject is LaserBeam)
                    {
                     
                    }
                }
            }
            for (int iHeart = 0; iHeart < heartAmount; iHeart++)
            {
                gameObjectList.Add(new Playerlife("spaceheart", heartX[iHeart], 0));
            }
        }
    }
}
