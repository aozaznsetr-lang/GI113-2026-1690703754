/*
 * Student ID : 1690703754
 * Name       :Lab02
 * Section    :129D
 * No.        :
 * Course     :GI113 Computer Programming (Gi)
 */

namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STAYUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attackpower: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"IsBoss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percent: {hpPercent}%");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DEMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            string heroName = "Aiden";
            int hero1hp = 400;
            float hero1atk = 100;
            double hero1Speed = 60;
            char hero1luck = 84;
            Console.WriteLine("----- HERO 1 -----");
            Console.WriteLine($"Name: {hero1Name}");
            Console.WriteLine($"HP: {hero1Hp}");
            Console.WriteLine($"atk: {hero1atk}");
            Console.WriteLine($"luck: {hero1luck}");
            
            string heroName = "Orion";
            int hero1hp = 450;
            float hero1atk = 260;
            double hero1Speed = 30;
            char hero1luck = 44;
            Console.WriteLine("----- HERO 2 -----");
            Console.WriteLine($"Name: {hero2Name}");
            Console.WriteLine($"HP: {hero2Hp}");
            Console.WriteLine($"atk: {hero2atk}");
            Console.WriteLine($"luck: {hero2luck}");
           
            string heroName = "Raven";
            int hero1hp = 200;
            float hero1atk = 200;
            double hero1Speed = 42;
            char hero1luck = 36;
            Console.WriteLine("----- HERO 3 -----");
            Console.WriteLine($"Name: {hero3Name}");
            Console.WriteLine($"HP: {hero3Hp}");
            Console.WriteLine($"atk: {hero3atk}");
            Console.WriteLine($"luck: {hero3luck}");
            
            string heroName = "Zane";
            int hero4hp = 600;
            float hero4atk = 140;
            double hero4Speed = 66;
            char hero4luck = 40;
            Console.WriteLine("----- HERO 4 -----");
            Console.WriteLine($"Name: {hero4Name}");
            Console.WriteLine($"HP: {hero4Hp}");
            Console.WriteLine($"atk: {hero4atk}");
            Console.WriteLine($"luck: {hero4luck}");
        }
    }
}
