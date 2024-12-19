using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace HadMonogame.Skripts;

public class Main
{
    static GameSettings gs = new();

    public static List<Cube> List = new();
    private static float _lastGameTime = 0f;
    private static int _x = 0;
    private static int _y = 0;
    private static bool _start;
    private static string _smer = "right";
    private static string _stopSmer = "left";

    private static void MainProgram()
    {
        switch (_smer)
        {
            case ("up"):
                _y -= gs.posun;
                break;
            case ("down"):
                _y += gs.posun;
                break;
            case ("right"):
                _x += gs.posun;
                break;
            case ("left"):
                _x -= gs.posun; 
                break;
        }

        List.Add(new Cube(_x, _y));
        List.RemoveAt(0);

        if(_smer == "up") _stopSmer = "down";
        else if(_smer == "down") _stopSmer = "up";
        else if(_smer == "right") _stopSmer = "left";
        else if(_smer == "left") _stopSmer = "right";
    }

    private static void Spawn()
    {
        for (int i = 0; i < 3; i++)
        {
            _x += gs.posun;
            List.Add(new Cube(_x, _y));
        }
    }


    private static void MoveLogic()
    {
        switch (true)
        {
            case var _ when Keyboard.GetState().IsKeyDown(Keys.W):
                if (_stopSmer != "down") _smer = "up";
                break;
            case var _ when Keyboard.GetState().IsKeyDown(Keys.A):
                if (_stopSmer != "right") _smer = "left";
                break;
            case var _ when Keyboard.GetState().IsKeyDown(Keys.S):
                if (_stopSmer != "up") _smer = "down";
                break;
            case var _ when Keyboard.GetState().IsKeyDown(Keys.D):
                if (_stopSmer != "left") _smer = "right";
                break;
        }

    }


    public static void IfChangeState(float gameTime, Game1 game)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) game.Exit();
        else if (Keyboard.GetState().IsKeyDown(Keys.Enter)) { _start = !_start; System.Threading.Thread.Sleep(500); }
        else if (Keyboard.GetState().IsKeyDown(Keys.Space)) { List.Clear(); _x = 0; _y = 0; _start = false; }
        MoveLogic();


        if (gameTime - _lastGameTime > gs.casPosunu)    // Kontroluje cas a pohne se pri kazdem intervalu
        {
            _lastGameTime = gameTime;
            if (List.Count == 0) Spawn();
            else if (_start)
            {
                Debug.WriteLine("StopSmer = {0}", _stopSmer);
                MainProgram();
            }
        }









    }










}


















