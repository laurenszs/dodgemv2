using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodgem.GameStates
{
    class winState : GameState
    {
        winState() {
            gameObjectList.Add(new GameObject("spr_win_screen"));
        }

    }
}
