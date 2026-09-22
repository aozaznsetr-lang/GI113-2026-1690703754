namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 0;

            if(lives > 0)
            {
             Console.WriteLine("Game Over");
            }
            Console.WriteLine("continue Code");

            Console.WriteLine("You level (1-99) ");
            bool inputvalid = int.TryParse(Console.ReadLine(), out int level);

            bool hasKey = true;
            if (!inputvalid || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid level.");
            }
            else if  (level >= 10 )
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5)
            {
                if (hasKey)
                {
                    Console.WriteLine("The door opens.");
                }
                else
                {
                    Console.WriteLine("Locked. Find a key.");
                }
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }

            //bool isPoisoned = true;

            //if (isPoisoned == true)
            //{
                //Console.WriteLine("You died.");
            //}
           // else if (isPoisoned == false)
           // {
                //Console.WriteLine("You live.");
            //}
        }
    }
}
