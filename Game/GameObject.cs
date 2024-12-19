using System;
using AlienBreed;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AlienBreed.Game;

public class GameObject
{

    protected Sprite Sprite;
    protected Vector2 Position;
    private Vector2 _size;
    
    public Vector2 Size { get => _size;
        set => _size = value;
    }
    public Rectangle Rect { get => new Rectangle((int) Position.X, (int) Position.Y, (int)(_size.X*Sprite.Size.X), (int)(_size.Y*Sprite.Size.Y)); }
    
    public GameObject(int currentFrame, Vector2 position, Vector2 size, Vector2 spriteSize)
    {
        Sprite = new Sprite(currentFrame,spriteSize,Color.White);
        Position = position; 
        Size = size;
    }
    
    public virtual void Update(GameTime gameTime, LevelManager levelManager) {
        
    }
    
    public void Draw(SpriteBatch spriteBatch,SpriteSheet spriteSheet) {
        Sprite.Draw(spriteBatch,spriteSheet,Rect);
    }
    
}