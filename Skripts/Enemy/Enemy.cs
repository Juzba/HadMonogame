using System;

namespace HadMonogame.Skripts.Enemy;


internal class Enemy
{
    public string Name { get; set; }
    public string Direction { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Enemy(string name, string direction, int x, int y)
    {
        Name = name;
        Direction = direction;
        X = x;
        Y = y;
    }


    public static void Main(Settings settings)
    {
        if (settings.EnemyList.Count < 10)
        {
            settings.EnemyList.Add(new Enemy(
                "Zombie", 
                "down", 
                (System.Random.Shared.Next(0, 13) * 9) * 10 + 20,
                (System.Random.Shared.Next(0, 7) * 9) * 10 + 20)
                );
        }
    }





















}
