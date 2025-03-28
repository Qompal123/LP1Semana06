using System;
using Humanizer;

namespace MyRoguelike
{
    public class Program
    {
        private static void Main()
        {
            Level lvl = new Level(125, Toughness.Nightmare);

            lvl.SetEnemyInRoom(0, new Enemy("Jumbo"));

            lvl.SetEnemyInRoom(60, new Enemy("Loros"));

            lvl.SetEnemyInRoom(41, new Enemy("Darth"));

            lvl.SetEnemyInRoom(9, new Enemy("Zulom"));

            lvl.SetEnemyInRoom(120, new Enemy("Vicious"));

            lvl.SetEnemyInRoom(72, new Enemy("Mendium"));


            Console.WriteLine($"Toughness: {lvl.GetToughness()}");

            Console.WriteLine($"Number of rooms: {lvl.GetNumRooms()}");

            Console.WriteLine($"Number of enemies: {lvl.GetNumEnemies()}");


            lvl.PrintEnemies();

            /*
            The screen will show:
                Toughness: Nightmare
                Number of rooms: 125
                Number of enemies: 6
                Zeroth room: Jumbo
                Ninth room: Zulom
                Forty-First room: Darth
                Sixtieth room: Loros
                Seventy-Second room: Mendium
                Hundred and Twentieth room: Vicious
            */

        }
    }

    public class Level
    {
        private Toughness toughness;

        private Enemy[] rooms;

        public Level(int numRooms, Toughness toughness)
        {
            this.toughness = toughness;
            rooms = new Enemy[numRooms];
        }

        public void SetEnemyInRoom(int roomInd, Enemy enemy)
        {
            rooms[roomInd] = enemy;
        }

        public Toughness GetToughness()
        {
            return toughness;
        }

        public int GetNumRooms()
        {
            return rooms.Length;
        }

        public int GetNumEnemies()
        {
            int count = 0;
            foreach (Enemy room in rooms)
            {
                if (room != null)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i.ToOrdinalWords(new System.Globalization.CultureInfo("en")).Transform(To.TitleCase)} room: {rooms[i].GetName()}");
                }
            }
        }

    }
}
