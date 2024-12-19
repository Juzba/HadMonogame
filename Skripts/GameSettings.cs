using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadMonogame.Skripts
{
    internal class GameSettings
    {
        public int Speed;
        public readonly int posun;
        public readonly float casPosunu;
        public readonly int Width;
        public readonly int Height;

        public GameSettings()
        {
            Speed = 1;
            posun = 125; ;
            casPosunu = 4f;
            Width = 200;
            Height = 200;
        }
    }

}
