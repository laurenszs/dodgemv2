using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dodgem.GameStates;
using Dodgem;

namespace Frogger.GameStates
{
    class DeathState : GameState
    {
        PlayingState playingstate = new PlayingState();
        public DeathState()
        {
            gameObjectList.Add(new GameObject("gameOver"));
           
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            playingstate.Init();

            if (GameEnvironment.keyboardState.IsKeyDown(Keys.Space))
                GameEnvironment.SwitchTo(1);
        }
    }
}
