using System.Collections;
using System.Runtime.CompilerServices;

namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"rank: {rank}");
            Console.WriteLine($"level: {level} / {MaxLevel}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"attack Power: {attackPower}");
            Console.WriteLine($"crit Multiplier: {critMultiplier}");
            Console.WriteLine($"is Boss {isBoss}");

            Console.WriteLine("----- Implicit Conversion: Hp as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"Hp (double): {currentHpDouble}");

            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hppercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"Hp percent (exact): {hppercentExact}%");

            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            double castPower = (int)attackPower;
            Console.WriteLine($"Attack Power(int cast): {castPower}");

            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int castCrir = (int)critMultiplier;
            Console.WriteLine($"Crit Muliplier; (int cast): {castCrir}");
            Console.WriteLine("Crit Muliplier (Convert rounded): " + Convert.ToInt32(critMultiplier));
        }
    }
}