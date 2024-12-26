using HadMonogame.Skripts.Enemy;

namespace HadMonogame.Skripts;

public class Snake
{

    public int X;
    public int Y;

    public Snake(int x = 0, int y = 0)
    {
        X = x;
        Y = y;
    }




    internal void MainProgram(Settings settings)
    {
        switch (settings.smer)
        {
            case ("up"):
                settings.y -= settings.posun; settings.stopSmer = "down";
                break;
            case ("down"):
                settings.y += settings.posun; settings.stopSmer = "up";
                break;
            case ("right"):
                settings.x += settings.posun; settings.stopSmer = "left";
                break;
            case ("left"):
                settings.x -= settings.posun; settings.stopSmer = "right";
                break;
        }

        settings.List.Add(new Snake(settings.x, settings.y));

        bool eatEnemy = false;
        foreach (var enemy in settings.EnemyList)
            if (settings.x == enemy.X && settings.y == enemy.Y)
            { 
                settings.EnemyList.Remove(enemy); eatEnemy = true; break;
            }

        if (!eatEnemy) settings.List.RemoveAt(0);
    }

    internal void Spawn(Settings settings)
    {
        for (int i = 0; i < settings.SnakeStartLenght; i++)
        {
            settings.x += settings.posun;
            settings.List.Add(new Snake(settings.x, settings.y));
        }
    }



}


















