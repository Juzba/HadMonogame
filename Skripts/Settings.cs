using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace HadMonogame.Skripts
{
    internal class Settings
    {
        public int Speed;
        public readonly int posun;
        public readonly int posunMissile;
        public readonly int removeMissileRange;
        public readonly float casPosunu;
        public readonly float casPosunuStrike;
        public readonly int Width;
        public readonly int Height;

        public List<Had> List;
        public List<Strike> ListOfMissiles;
        public float lastGameTime;
        public float lastGameTimeStrike;
        public int x;
        public int y;
        public bool start;
        public string smer;
        public string stopSmer;

        public Settings()
        {
            Speed = 1;
            posun = 90; 
            posunMissile = 5;
            removeMissileRange = 1000;
            casPosunu = 0.5f;
            casPosunuStrike = 0.2f;
            Width = 142;
            Height = 142;

            List = new();
            ListOfMissiles = new();
            lastGameTime = 0f;
            lastGameTimeStrike = 0f;
            x = 200;
            y = 200;
            start = false;
            smer = "up";
            stopSmer = "down";
        }
    }

}
