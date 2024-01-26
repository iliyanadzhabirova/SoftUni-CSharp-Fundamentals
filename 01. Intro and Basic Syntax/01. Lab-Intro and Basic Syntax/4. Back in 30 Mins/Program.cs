using System;

namespace _4._Back_in_30_Mins
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine())+30;
            
            if (mins>59)
            {
                hours++;
                mins -=60;
               
            }
        
            if (hours==24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{mins:D2}");
        }
    }
}
