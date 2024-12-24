using HadMonogame.Skripts.Enemy;

namespace HadMonogame.Skripts
{
    internal class GameUpdate
    {
        private static float _lastGameTime = 0;
        private static float _lastGameTime2 = 0;
        private Hotkeys _hotkeys = new Hotkeys();
        private Snake _had = new Snake();

        public void GameUpdate1(float gameTime, Game1 game, Settings settings)
        {
            _hotkeys.HotkeysMove(game, settings);

            if (GameTimeCounter(gameTime, _lastGameTime, settings.casPosunu, ref _lastGameTime))
            {
                if (settings.List.Count == 0) _had.Spawn(settings);
                else if (settings.start)
                {
                    _had.MainProgram(settings);
                    Enemy.Enemy.Main(settings);
                }
            }

            if (GameTimeCounter(gameTime, _lastGameTime2, 1f, ref _lastGameTime2))
            {
                Missile.MissileRemove(settings);                                                                                  // smaze strelu az dosahne urcite vzdalenosti
            }
            Missile.MissileOnMove(settings);


        }



        private static bool GameTimeCounter(float gameTime, float lastGameTime, float CountedTime, ref float newLastGameTime)
        {
            if (gameTime - lastGameTime > CountedTime) { newLastGameTime = gameTime; return true; }
            return false;
        }
































    }
}
