using System.Collections.Generic;

namespace HadMonogame.Skripts
{
    internal class GameSettings
    {
        public int Speed;
        public readonly int posun;
        public readonly float casPosunu;
        public readonly int Width;
        public readonly int Height;

        public List<Cube> List;
        public float lastGameTime;
        public int x;
        public int y;
        public bool start;
        public string smer;
        public string stopSmer;

        public GameSettings()
        {
            Speed = 1;
            posun = 125; ;
            casPosunu = 0.5f;
            Width = 200;
            Height = 200;

            List = new();
            lastGameTime = 0f;
            x = 200;
            y = 200;
            start = false;
            smer = "right";
            stopSmer = "left";
        }
    }

}
