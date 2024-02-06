namespace Problem_1___Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
//•	On the 1st line, you will receive the days of the plunder – an integer number in the range[0…100000]
//•	On the 2nd line, you will receive the daily plunder – an integer number in the range[0…50]
//•	On the 3rd line, you will receive the expected plunder – a real number in the range[0.0…10000.0]

            int days=int.Parse(Console.ReadLine());
            int dailyPlunder=int.Parse(Console.ReadLine());
            double expectedPlunder=double.Parse(Console.ReadLine());

            double totalPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                totalPlunder +=(double) dailyPlunder;

                if (i %3==0)
                {
                    
                    totalPlunder += (double)dailyPlunder/2 ;
                }
                if (i%5==0)

                {
                    
                    totalPlunder = totalPlunder * 0.7;
                }
               
                 
                
                
            }
            if (totalPlunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage= (totalPlunder/ expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }

        }
    }
}