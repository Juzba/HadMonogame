using Microsoft.Xna.Framework.Graphics;

namespace HadMonogame.Skripts
{
    internal class Strike
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }

        public int StartX { get; }
        public int StartY { get; }

        public Strike(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction;
            StartX = x;
            StartY = y;
        }

        public static void MissileFire() => Had.gs.ListOfMissiles.Add(new Strike(Had.gs.x, Had.gs.y, Had.gs.smer));
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
}
