using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dodgem.GameStates;


namespace Dodgem.GameStates
{
    class StartingState : GameState
    {
        public StartingState()
        {
            gameObjectList.Add(new GameObject("spr_start_screen"));
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        

            if (GameEnvironment.keyboardState.IsKeyDown(Keys.Space))
                GameEnvironment.SwitchTo(1);
        }
    }
}
