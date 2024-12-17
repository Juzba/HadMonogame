using System.Collections.Generic;

namespace HadMonogame
{
    public static class Main
    {
        public static int speed = 1;
        private static float casPosunu = 1f;


        public static List<Cube> list = new();
        private static float lastGameTime = 0f;
        private static int X = 0;
        private static int Y = 0;

        public static void main()
        {
            if (list.Count == 0)
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new Cube(X, Y));
                    X += 50;
                }
            else if (true) ; /// start
            {
                X += 50;
                list.Add(new Cube(X, Y));
                list.RemoveAt(0);
            }


        }



        public static bool loopTime(float gameTime)
        {
            if (gameTime - lastGameTime >= casPosunu) { lastGameTime = gameTime; return true; }
            else return false;
        }









    }
}
