namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 0;
            bool isEnoughEnergy = true;
            while (input != "End of battle")
            {

                int distance = int.Parse(input);


                if (energy - distance < 0)
                {
                    isEnoughEnergy = false;
                    break;
                }

                energy -= distance;
                counter++;

                if (counter % 3 == 0)
                {
                    energy += counter;
                }

                input = Console.ReadLine();


            }
            if (isEnoughEnergy)
            {
                Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");

            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energy} energy");

            }
        }
    }
}