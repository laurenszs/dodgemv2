using Dodgem.GameObjects;
using Dodgem;
using Frogger.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Dodgem
{
    class PlayingState : GameState
    {
        int metVel = 3, shipVel = 5, beamVel = 14;
        int meteorAmount = 3, shipAmount = 2, beamAmount = 1;
        public int heartAmount = 2, dmgStop = 1, healthgate = 120, dead = 0, damage = 1;
        const int NO_DMG = 0;
        int[] obstacle = new int[] { 10, 35, 110, 300, 200, 264, 70, 38 };

        int[] heartX = new int[] { 0, 37, 74 };
        PlayerShip thePlayer = new PlayerShip();
        public Random random = new Random();


        public PlayingState()
        {
            heartAmount = 3;
            gameObjectList.Add(new GameObject("spr_background"));
            this.Init();

        }

        public override void Init()
        {
            heartAmount = 3;
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
        public override async void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            System.Diagnostics.Debug.WriteLine("hearts: " + heartAmount);
            foreach (GameObject gameObject in gameObjectList)
            {

                if (heartAmount == 2)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(healthgate));
                    dmgStop = damage;
                }

                if (heartAmount == 1)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(healthgate));
                    dmgStop = damage;
                }

                if (heartAmount == dead)
                {

                    dmgStop = NO_DMG;
                    GameEnvironment.SwitchTo(2);
                    heartAmount = 2;
                }

                if (gameObject.Overlaps(thePlayer) == true)
                {
                    if (gameObject is Meteorite || gameObject is EnemyShip || gameObject is LaserBeam)
                    {
                        heartAmount -= dmgStop;
                        dmgStop = NO_DMG;
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
