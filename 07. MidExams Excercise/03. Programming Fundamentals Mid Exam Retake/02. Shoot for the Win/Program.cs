namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

           
            string command =Console.ReadLine();
            int counter = 0;

            while (command!= "End")
            {
                int index = int.Parse(command);
                int oldValue;

                if (index >= 0 && index < targets.Length && targets[index] != -1)
                {
                    counter++;
                    oldValue = targets[index];
                    targets[index] = -1;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] != -1 && targets[i] > oldValue)
                        {
                            targets[i] -= oldValue;
                        }
                        else if (targets[i] != -1 && targets[i] <= oldValue)
                        {
                            targets[i] += oldValue;
                        }
                    }
                }
                command = Console.ReadLine();
            }

          
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
        }
    }
}