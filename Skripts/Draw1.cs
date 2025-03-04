﻿using HadMonogame.Skripts.Enemy;
using HadMonogame.Skripts.others;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HadMonogame.Skripts;

internal class Draw1
{
    
    private static SpriteFont _font;
    private static Texture2D _playerBody;
    private static Texture2D _playerHead;
    private static Texture2D _playerHead1;
    private static Texture2D _playerHead2;
    private static Texture2D _playerHead3;
    private static Texture2D _backGround;
    private static Texture2D _strike1;
    private static Texture2D _strike2;
    private static int _count = 0;
    


    public void Draw1Content(Game1 game1)
    {
        _font = game1.Content.Load<SpriteFont>("font/DFont");
        _playerBody = game1.Content.Load<Texture2D>("sprites/body");
        _playerHead = game1.Content.Load<Texture2D>("sprites/head");
        _playerHead1 = game1.Content.Load<Texture2D>("sprites/head1");
        _playerHead2 = game1.Content.Load<Texture2D>("sprites/head2");
        _playerHead3 = game1.Content.Load<Texture2D>("sprites/head3");
        _backGround = game1.Content.Load<Texture2D>("sprites/leafs");
        _strike1 = game1.Content.Load<Texture2D>("sprites/strike1");
        _strike2 = game1.Content.Load<Texture2D>("sprites/strike2");
    }

    public void Draw1Main(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice, Settings settings)
    {
        var snakeFace = HeadAnimation(_playerHead1, _playerHead3, _playerHead2);

        spriteBatch.Draw(_backGround, new Rectangle(0, 0, graphicsDevice.Viewport.Width, graphicsDevice.Viewport.Height), Color.White);


        foreach (var item in settings.List)                                                                                            // Snake
        {
            if (item == settings.List[settings.List.Count - 1])                                                                          // Head
            {
                spriteBatch.Draw(
                snakeFace,
                new Rectangle(item.X, item.Y, settings.Width, settings.Height),
                null,
                Color.White,
                RotationDraw.Rotation(RotationDraw.HeadRotation, settings.stopSmer),
                RotationDraw.RotationVector(RotationDraw.HeadRotationVector, settings.stopSmer),
                SpriteEffects.None,
                0f);
            }
            else                                                                                                                    // Body
            {
                spriteBatch.Draw(_playerBody, new Rectangle(item.X, item.Y, settings.Width, settings.Height), Color.White);
            }
            spriteBatch.DrawString(_font, "Pocet strel v letu:" + settings.ListOfMissiles.Count, new Vector2(1000, 10), Color.Red);
            spriteBatch.DrawString(_font, ($"HeadPosition: {settings.x}, {settings.y}."), new Vector2(1000, 110), Color.Red);

        }

        foreach (var item in settings.ListOfMissiles)                                                                                 // Missile
        {
            spriteBatch.Draw(
                AnimationTime(_strike1, _strike2),
                new Rectangle(item.X, item.Y, 100, 100),
                null,
                Color.White,
                RotationDraw.Rotation(RotationDraw.MissileRotation, item.Direction),
                RotationDraw.RotationVector(RotationDraw.MissileRotationVector, item.Direction),
                SpriteEffects.None, 0f);

        }



        if (_count > 19) _count = 0; else _count++;
    }



    private static Texture2D HeadAnimation(Texture2D texture1, Texture2D texture2, Texture2D texture3)
    {
        if (Missile.ChangeFace) { _count = -25; Missile.ChangeFace = false; }
        else if (_count < 0) return texture3;


        if (_count < 10) { return texture1; }
        else { return texture2; }
    }

    private static Texture2D AnimationTime(Texture2D texture1, Texture2D texture2)
    {
        if (_count < 10) { return texture1; }
        else { return texture2; }
    }






}
