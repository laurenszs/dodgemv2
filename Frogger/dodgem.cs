using Dodgem.GameStates;
using Frogger.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Dodgem
{
    //Laurens Cnossen 500821318
    //GPA
    /// <summary>
    //gebasseerd op een spel dat "Dodgem" het wat ik op de middelbare school op mijn rekenmachine had
    //het doel is om alle obstakels te ontwijken en te zien hoe lang je kan overleven.
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
            gameStateList.Add(new DeathState());
            GameEnvironment.SwitchTo(0);





        }


    }
}
