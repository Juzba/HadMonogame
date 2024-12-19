using System.Collections.Generic;

namespace HadMonogame
{
    public static class Main
    {
        public static int speed = 1;
        private static float casPosunu = 1f;


        public static List<Cube> List = new();
        private static float LastGameTime = 0f;
        private static int X = 0;
        private static int Y = 0;

        public static void MainProgram()
        {
            if (List.Count == 0)
                for (int i = 0; i < 3; i++)
                {
                    List.Add(new Cube(X, Y));
                    X += 50;
                }
            else if (true) ; /// start
            {
                X += 50;
                List.Add(new Cube(X, Y));
                List.RemoveAt(0);
            }


        }



        public static bool loopTime(float gameTime)
        {
            if (gameTime - LastGameTime >= casPosunu) { LastGameTime = gameTime; return true; }
            else return false;
        }









    }
}
