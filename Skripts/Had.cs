using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace HadMonogame.Skripts;

public class Had
{
    internal static GameSettings gs = new();
    internal static void MainProgram()
    {
        switch (gs.smer)
        {
            case ("up"):
                gs.y -= gs.posun; gs.stopSmer = "down";
                break;
            case ("down"):
                gs.y += gs.posun; gs.stopSmer = "up";
                break;
            case ("right"):
                gs.x += gs.posun; gs.stopSmer = "left";
                break;
            case ("left"):
                gs.x -= gs.posun; gs.stopSmer = "right";
                break;
        }

        gs.List.Add(new Cube(gs.x, gs.y));
        gs.List.RemoveAt(0);
    }

    internal static void Spawn()
    {
        for (int i = 0; i < 3; i++)
        {
            gs.x += gs.posun;
            gs.List.Add(new Cube(gs.x, gs.y));
        }
    }

    public static float HeadRotation()
    {
        switch (gs.stopSmer)
        {
            case ("down"):
                return 3.14f;
            case ("up"):
                return 0f;
            case ("right"):
                return 1.57f;
            case ("left"):
                return 4.71f;
            default: return 0f;
        }
    }

    public static Vector2 HeadRotationVector()
    {
        switch (gs.stopSmer)
        {
            case ("down"):
                return new Vector2(520, 510);
            case ("up"):
                return new Vector2(0,0);
            case ("right"):
                return new Vector2(3, 515);
            case ("left"):
                return new Vector2(512, -5);
            default: return new Vector2(0, 0);
        }
    }

}


















