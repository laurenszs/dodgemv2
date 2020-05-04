using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frogger.GameObjects
{
    public interface ITextGameObject
    {
        Color Color { get; set; }
        Vector2 Size { get; }
        string Text { get; set; }

        void Draw(SpriteBatch spriteBatch);
    }
}