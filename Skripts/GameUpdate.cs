using HadMonogame.Skripts.Enemy;

namespace HadMonogame.Skripts
{
    internal class GameUpdate
    {
        private static float _lastGameTime = 0;
        private static float _lastGameTime2 = 0;

        public static void GameUpdate1(float gameTime, Game1 game)
        {
            Hotkeys.HotkeysMove(game, ref Had.gs);

            if (GameTimeCounter(gameTime, _lastGameTime, Had.gs.casPosunu, ref _lastGameTime))
            {
                if (Had.gs.List.Count == 0) Had.Spawn();
                else if (Had.gs.start)
                {
                    Had.MainProgram();
                    Enemy.Enemy.Main();
                }
            }

            if (GameTimeCounter(gameTime, _lastGameTime2, 1f , ref _lastGameTime2))
            {
                Missile.MissileRemove();                                                                                  // smaze strelu az dosahne urcite vzdalenosti
            }
            Missile.MissileOnMove();


        }



        private static bool GameTimeCounter(float gameTime, float lastGameTime, float CountedTime, ref float newLastGameTime)
        {
            if (gameTime - lastGameTime > CountedTime) { newLastGameTime = gameTime; return true; }
            return false;
        }
































    }
}
