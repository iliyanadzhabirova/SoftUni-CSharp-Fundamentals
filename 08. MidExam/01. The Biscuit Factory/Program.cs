namespace _01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int biscuitsPerPerson=int.Parse(Console.ReadLine());
           int countofWorkers=int.Parse(Console.ReadLine());
           int comparingBiscuets=int.Parse(Console.ReadLine());

            double resultPerDay = biscuitsPerPerson * countofWorkers;
            double totalBiscuits = 0;
            for (int i = 1; i <= 30; i++)
            {
                resultPerDay = biscuitsPerPerson * countofWorkers;
                if (i%3==0)
                {
                    resultPerDay = resultPerDay * 0.75;
                    totalBiscuits += (int)(resultPerDay);
                }
                else
                {

                    totalBiscuits += (int)(resultPerDay);
                }

            }
            
            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

            if (comparingBiscuets>totalBiscuits)
            {
                double difference=(comparingBiscuets-totalBiscuits)/comparingBiscuets*100;
                Console.WriteLine($"You produce {difference:f2} percent less biscuits.");

            }
            else
            {
                double difference = (totalBiscuits - comparingBiscuets) / comparingBiscuets * 100;
                Console.WriteLine($"You produce {difference:f2} percent more biscuits.");
            }
        }
    }
}