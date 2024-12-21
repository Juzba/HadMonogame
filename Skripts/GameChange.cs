namespace HadMonogame.Skripts
{
    internal class GameChange
    {

        public static void GameUpdate(float gameTime, Game1 game)
        {
            Hotkeys.HotkeysMove(game, ref Had.gs);

            if (GameTimeCounter(gameTime, Had.gs.lastGameTime, Had.gs.casPosunu, ref Had.gs.lastGameTime))
            {
                if (Had.gs.List.Count == 0) Had.Spawn();
                else if (Had.gs.start) Had.MainProgram(); 
            }
        }



        private static bool GameTimeCounter(float gameTime, float lastGameTime, float CountedTime, ref float newLastGameTime)
        {
            if (gameTime - lastGameTime > CountedTime)
            { newLastGameTime = gameTime; return true; }
            return false;
        }
































    }
}
