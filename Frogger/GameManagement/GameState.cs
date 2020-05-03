using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GameState
{
    protected List<GameObject> gameObjectList;
    public int gameRoom = 0;
    
    public GameState()
    {
        gameObjectList = new List<GameObject>();

    }

    public virtual void Init()
    {
        foreach (GameObject gameObject in gameObjectList)
            gameObject.Init();
    }

    public virtual void Update(GameTime gameTime)
    {
        foreach (GameObject gameObject in gameObjectList)
            gameObject.Update();

    }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
       
        foreach (GameObject gameObject in gameObjectList)
        {
            gameObject.Draw(spriteBatch);
        }
    }
}
