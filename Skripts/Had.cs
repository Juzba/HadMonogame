using Microsoft.Xna.Framework;

namespace HadMonogame.Skripts;

public class Had
{

    public int X;
    public int Y;

    public Had(int x, int y)
    {
        X = x;
        Y = y;
    }



    internal static Settings gs = new();
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

        gs.List.Add(new Had(gs.x, gs.y));
        gs.List.RemoveAt(0);
    }

    internal static void Spawn()
    {
        for (int i = 0; i < 9; i++)
        {
            gs.x += gs.posun;
            gs.List.Add(new Had(gs.x, gs.y));
        }
    }

   

}


















