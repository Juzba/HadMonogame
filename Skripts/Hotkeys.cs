using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadMonogame.Skripts
{
    public static class Hotkeys
    {


      internal static void HotkeysMove(Game1 game, ref GameSettings gameSettings)
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


                case var _ when Keyboard.GetState().IsKeyDown(Keys.Enter):  gameSettings = new();
                    break;
                case var _ when Keyboard.GetState().IsKeyDown(Keys.Escape): game.Exit();
                    break;

            }
        }
    }
}
