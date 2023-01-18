using System;
using System.Security.Cryptography.X509Certificates;

namespace Structure
{
    public struct Stats
    {


        public int STR;
        public int DEX;
        public int INT;
        public int LUK;

        public Stats(int Str, int Dex, int Int, int Luk)
        {
            this.STR = Str;
            this.DEX = Dex;
            this.INT = Int;
            this.LUK = Luk;
        }


        public int GetCombatPower()
        {
            return STR + DEX+ INT + LUK;
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {

            Player player = new Player();
            player.STR = 10;
            player.DEX = 10;
            player.INT = 10;
            player.LUK = 10;

            Enemy enemy = new Enemy();
            enemy.Stats.STR = 10;
            enemy.DEX = 10;
            enemy.INT = 10;
            enemy.LUK = 10;
            Console.WriteLine($"적의 전투력이 {enemy.Stats.GetCombatPower()} 입니다");
        }
    }

    public class Player
    {
        public int STR;
        public int DEX;
        public int INT;
        public int LUK;
    }

    public class Enemy
    {

        public int STR;
        public int DEX;
        public int INT;
        public int LUK;
    }
}
