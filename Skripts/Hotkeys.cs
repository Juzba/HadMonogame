using HadMonogame.Skripts.Enemy;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HadMonogame.Skripts
{
    public class Hotkeys
    {
        private static Stopwatch sw = Stopwatch.StartNew();


        internal void HotkeysMove(Game1 game, Settings settings)
        {
            switch (true)
            {
                case var _ when Keyboard.GetState().IsKeyDown(Keys.W):
                    if (!settings.stopSmer.Contains("up")) settings.smer = "up"; settings.start = true;
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.A):
                    if (!settings.stopSmer.Contains("left")) settings.smer = "left"; settings.start = true;
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.S):
                    if (!settings.stopSmer.Contains("down")) settings.smer = "down"; settings.start = true;
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.D):
                    if (!settings.stopSmer.Contains("right")) settings.smer = "right"; settings.start = true;
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.Space):
                    if (sw.Elapsed.TotalSeconds > 1 || settings.ListOfMissiles.Count == 0) { Missile.MissileFire(settings); sw.Restart(); }
                    break;


                case var _ when Keyboard.GetState().IsKeyDown(Keys.Enter):
                    if(sw.Elapsed.TotalSeconds > 1){ Settings.SettingThis = new();sw.Restart();}
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.Escape):
                    game.Exit();
                    break;

            }
        }
    }
}
