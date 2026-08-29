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

            Console.WriteLine($"Name: {Aiden}");
            Console.WriteLine($"class: {Warrior}");
            Console.WriteLine($"HP: {400}");
            Console.WriteLine($"Speed: {60}");
            Console.Writeline($"attack; {84}");
            Console.Writeline($"luck; {50}");
            Console.WriteLine($"Name: {Orion}");
            Console.WriteLine($"class: {Wizar}");
            Console.WriteLine($"HP: {2500}");
            Console.WriteLine($"Speed: {40}");
            Console.Writeline($"attack; {120}");
            Console.Writeline($"luck; {70}");
            Console.WriteLine($"Name: {Raven}");
            Console.WriteLine($"class: {Assassin}");
            Console.WriteLine($"HP: {150}");
            Console.WriteLine($"Speed: {99}");
            Console.Writeline($"attack; {100}");
            Console.Writeline($"luck; {60}");
            Console.WriteLine($"Name: {Zane}");
            Console.WriteLine($"class: {Tank}");
            Console.WriteLine($"HP: {1000}");
            Console.WriteLine($"Speed: {25}");
            Console.Writeline($"attack; {30}");
            Console.Writeline($"luck; {31}");
        }
    }
}
