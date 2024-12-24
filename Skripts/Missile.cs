using HadMonogame.Skripts.Enemy;
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

    public static void MissileFire(Settings settings)
    {
        settings.ListOfMissiles.Add(new Missile(settings.x, settings.y, settings.smer));
        ChangeFace = true;
    }


    public static void MissileRemove(Settings settings)
    {
        foreach (var missile in settings.ListOfMissiles)
            if (missile.X > missile.StartX + settings.removeMissileRange || missile.X < missile.StartX + (-1 * settings.removeMissileRange)
                || missile.Y > missile.StartX + settings.removeMissileRange || missile.Y < missile.StartX + (-1 * settings.removeMissileRange))
            { settings.ListOfMissiles.Remove(missile); break; }
    }


    public static void MissileOnMove(Settings settings)
    {
        if (settings.ListOfMissiles.Count > 0)
        {
            foreach (var missile in settings.ListOfMissiles)
            {
                switch (missile.Direction)
                {
                    case "up":
                        missile.Y -= settings.posunMissile;
                        break;
                    case "down":
                        missile.Y += settings.posunMissile;
                        break;
                    case "left":
                        missile.X -= settings.posunMissile;
                        break;
                    case "right":
                        missile.X += settings.posunMissile;
                        break;
                }
            }
        }
    }
}
