using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace HadMonogame.Skripts
{
    internal class GameSettings
    {
        public int Speed;
        public readonly int posun;
        public readonly float casPosunu;
        public readonly float casPosunuStrike;
        public readonly int Width;
        public readonly int Height;

        public List<Cube> List;
        public List<Strike> ListOfStrikes;
        public float lastGameTime;
        public int x;
        public int y;
        public bool start;
        public string smer;
        public string stopSmer;

        public GameSettings()
        {
            Speed = 1;
            posun = 90; 
            casPosunu = 0.5f;
            casPosunuStrike = 0.25f;
            Width = 142;
            Height = 142;

            List = new();
            ListOfStrikes = new();
            lastGameTime = 0f;
            x = 200;
            y = 200;
            start = false;
            smer = "right";
            stopSmer = "left";
        }
    }

}
