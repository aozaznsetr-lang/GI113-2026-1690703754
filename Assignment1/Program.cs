/*
* Student ID : 1690703754
* Name       :Lab02
* Section    :129D
* No.        :6
* Course     :GI113 Computer Programming (Gi)
*/
using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Dying Light"; // const, PascalCase

            var heroName = "Kyle Crane";       // var บน string
            var heroClass = "Assassin";        // var บน string
            var heroRank = 'S';                 // var บน char

            int heroSurvivorLevel = 25;
            float heroPowerLevel = 25.5f;
            double staminaPrecise = 200.6;
            bool isPlayable = true;

            Console.WriteLine("========================================");
            Console.WriteLine($"              {GameTitle}");
            Console.WriteLine("========================================");
            Console.WriteLine($"Hero Name   : {heroName}");
            Console.WriteLine($"Class       : {heroClass}");
            Console.WriteLine($"Rank        : {heroRank}");
            Console.WriteLine($"Level       : {heroSurvivorLevel}");
            Console.WriteLine($"Power Level : {heroPowerLevel}");
            Console.WriteLine($"Stamina     : {staminaPrecise}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine();

            // Implicit Conversion: int -> double
            double heroLevelAsDouble = heroSurvivorLevel;
            Console.WriteLine($"Level as double (implicit) : {heroLevelAsDouble}");

            // Explicit Cast: double -> int
            int staminaTruncated = (int)staminaPrecise;

            // Convert.ToInt32(): double -> int
            int staminaRounded = Convert.ToInt32(staminaPrecise);

            Console.WriteLine($"Stamina cast (truncates)   : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)   : {staminaRounded}");
        }
    }
}