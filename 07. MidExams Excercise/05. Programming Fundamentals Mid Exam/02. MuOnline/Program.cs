namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split(('|'), StringSplitOptions.RemoveEmptyEntries);
            int health = 100;
            int bitcoin = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string command = rooms[i];
                string[] commandArr = command.Split((" "),StringSplitOptions.RemoveEmptyEntries);
                int number = int.Parse(commandArr[1]);
                if (commandArr[0]=="potion")
                {
                    int cuurHealth = health;
                    if (health+number<=100)
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        health += number;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {100 - cuurHealth} hp.");
                        health = 100;

                    }
                   
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (commandArr[0] == "chest")
                
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoin += number;
                }
                else 
                {
                    if (health-number>0)
                    {
                        health -= number;
                        Console.WriteLine($"You slayed {commandArr[0]}.");
                    }
                    else if (health-number<=0)
                    {
                        Console.WriteLine($"You died! Killed by {commandArr[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                   
                }


            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoin}");
            Console.WriteLine($"Health: {health}");
        }
    }
}