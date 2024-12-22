namespace HadMonogame.Skripts
{
    internal class GameUpdate
    {

        public static void GameUpdate1(float gameTime, Game1 game)
        {
            Hotkeys.HotkeysMove(game, ref Had.gs);

            if (GameTimeCounter(gameTime, Had.gs.lastGameTime, Had.gs.casPosunu, ref Had.gs.lastGameTime))
            {
                if (Had.gs.List.Count == 0) Had.Spawn();
                else if (Had.gs.start) Had.MainProgram();
            }

            if (GameTimeCounter(gameTime, Had.gs.lastGameTimeStrike, Had.gs.casPosunuStrike, ref Had.gs.lastGameTimeStrike))
            {
                Strike.MissileRemove();                                                                                  // smaze strelu az dosahne urcite vzdalenosti
            }
            Strike.MissileOnMove();


        }



        private static bool GameTimeCounter(float gameTime, float lastGameTime, float CountedTime, ref float newLastGameTime)
        {
            if (gameTime - lastGameTime > CountedTime) { newLastGameTime = gameTime; return true; }
            return false;
        }
































    }
}
