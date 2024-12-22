using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace HadMonogame.Skripts
{
    public static class Hotkeys
    {
        private static Stopwatch sw = Stopwatch.StartNew();


        internal static void HotkeysMove(Game1 game, ref Settings gameSettings)
        {
            switch (true)
            {
                case var _ when Keyboard.GetState().IsKeyDown(Keys.W):
                    if (!Had.gs.stopSmer.Contains("up")) Had.gs.smer = "up"; Had.gs.start = true;
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.A):
                    if (!Had.gs.stopSmer.Contains("left")) Had.gs.smer = "left"; Had.gs.start = true;
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.S):
                    if (!Had.gs.stopSmer.Contains("down")) Had.gs.smer = "down"; Had.gs.start = true;
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.D):
                    if (!Had.gs.stopSmer.Contains("right")) Had.gs.smer = "right"; Had.gs.start = true;
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.Space):
                    if (sw.Elapsed.TotalSeconds > 1) { Strike.MissileFire(); sw.Restart(); }
                    break;


                case var _ when Keyboard.GetState().IsKeyDown(Keys.Enter):
                    gameSettings = new();
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.Escape):
                    game.Exit();
                    break;

            }
        }
    }
}
