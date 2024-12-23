using HadMonogame.Skripts.Enemy;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace HadMonogame.Skripts.Enemy
{
    internal class Settings
    {
        public int Speed;
        public readonly int posun;
        public readonly int posunMissile;
        public readonly int removeMissileRange;
        public readonly float casPosunu;
        public readonly int Width;
        public readonly int Height;

        public List<Had> List;
        public List<Missile> ListOfMissiles;
        public List<Enemy> EnemyList;
        public int x;
        public int y;
        public bool start;
        public string smer;
        public string stopSmer;

        public Settings()
        {
            Speed = 1;
            posun = 90; 
            posunMissile = 10;
            removeMissileRange = 1000;
            casPosunu = 0.5f;
            Width = 142;
            Height = 142;

            List = new();
            ListOfMissiles = new();
            x = 200;
            y = 200;
            start = false;
            smer = "right";
            stopSmer = "left";
        }
    }

}
