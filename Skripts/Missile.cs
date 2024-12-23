using Microsoft.Xna.Framework.Graphics;

namespace HadMonogame.Skripts;

internal class Missile
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Direction { get; set; }

    public int StartX { get; }
    public int StartY { get; }

    public Missile(int x, int y, string direction)
    {
        X = x;
        Y = y;
        Direction = direction;
        StartX = x;
        StartY = y;
    }

    public static bool ChangeFace;                    // Zmena obliceje pri vystrelu

    public static void MissileFire()
    {
        Had.gs.ListOfMissiles.Add(new Missile(Had.gs.x, Had.gs.y, Had.gs.smer));
        ChangeFace = true;
    }


    public static void MissileRemove()
    {
        foreach (var missile in Had.gs.ListOfMissiles)
            if (missile.X > missile.StartX + Had.gs.removeMissileRange || missile.X < missile.StartX + (-1 * Had.gs.removeMissileRange)
                || missile.Y > missile.StartX + Had.gs.removeMissileRange || missile.Y < missile.StartX + (-1 * Had.gs.removeMissileRange))
            { Had.gs.ListOfMissiles.Remove(missile); break; }
    }


    public static void MissileOnMove()
    {
        if (Had.gs.ListOfMissiles.Count > 0)
        {
            foreach (var missile in Had.gs.ListOfMissiles)
            {
                switch (missile.Direction)
                {
                    case "up":
                        missile.Y -= Had.gs.posunMissile;
                        break;
                    case "down":
                        missile.Y += Had.gs.posunMissile;
                        break;
                    case "left":
                        missile.X -= Had.gs.posunMissile;
                        break;
                    case "right":
                        missile.X += Had.gs.posunMissile;
                        break;
                }
            }
        }
    }
































}
