using Dodgem.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Dodgem
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    class dodgem : GameEnvironment
    {

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>

        protected override void LoadContent()
        {
            base.LoadContent();
            screen = new Point(300, 500);
            ApplyResolutionSettings();

            gameStateList.Add(new StartingState());
            gameStateList.Add(new PlayingState());
            GameEnvironment.SwitchTo(0);





        }

      
    }
}
