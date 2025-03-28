using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
       

            Enemy[] inimigos = new Enemy[int.Parse(args[0])];

            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();
                inimigos[i] = new Enemy(name);
            }

            foreach (var inimigo in inimigos)
            {
                inimigo.PickupPowerUp(PowerUp.Health, 50);
                inimigo.PickupPowerUp(PowerUp.Shield, 50);
                inimigo.TakeDamage(80);
                Console.WriteLine($"{inimigo.GetName()} {inimigo.GetHealth()} {inimigo.GetShield()}");
            }
            Console.WriteLine($"Total de PowerUps: {Enemy.GetTotalPowerUps()}");

            
        }
    }
}