using Microsoft.Xna.Framework;

namespace HadMonogame.Skripts
{
    internal class Strike
    {
        public Vector2 Position { get; set; }

        public Strike(Vector2 position)
        {
            Position = position;
        }

        public static void Fire()
        {
            Had.gs.ListOfStrikes.Add(new Strike(new Vector2(Had.gs.x,Had.gs.y)));
        }














    }
}
