/*
* Student ID : 1690703754
* Name       :Lab06
* Section    :129D
* No.        :6
* Course     :GI113 Computer Programming (Gi)
*/
namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int pistolDmg = 45;
            int ChainsawDmg = 100;
            int zombieHp = 100;
            int heroHp = 100;
            int dogfoodHeal = 50;
            Console.WriteLine("GAME TITLE:Dead Dawn");

            Console.WriteLine("ACTION 1: SHOOT WITH PISTOL");
            Console.WriteLine("ACTION 2: SWING CHAINSAW");
            Console.WriteLine("ACTION 3: EAT DOG FOOD");

            Console.WriteLine("+++> CHOOSE YOUR NEXT MOVE (1-3): ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int choice);

            if (!isValidInput || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input, please choose between 1-3 only! ");
            }
            else if (choice == 1)
            {
                zombieHp -= pistolDmg;
                Console.WriteLine($"You shoot the zombie with your pistol, dealing {pistolDmg} damage. Zombie HP is now {zombieHp}.");
            }
            else if (choice == 2)
            {
                zombieHp -= ChainsawDmg;
                Console.WriteLine($"You swing your chainsaw at the zombie, dealing {ChainsawDmg} damage. Zombie HP is now {zombieHp}.");
            }
            else if (choice == 3)
            {
                heroHp += dogfoodHeal;
                Console.WriteLine($"You eat dog food and heal yourself for {dogfoodHeal} HP. Your HP is now {heroHp}.");
            }
        }
    }
}
