using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = string.Empty, usernameReversed = string.Empty;
            int attempts = 0;
            username = Console.ReadLine();
            string password = Console.ReadLine();
            for (int i = username.Length - 1; i >= 0; i--)
            {
                usernameReversed += username[i];
            }
            while (usernameReversed != password)


            {
                attempts++;
               
                if (attempts >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");

                  
                }
                password = Console.ReadLine();
            }


            if (usernameReversed == password)
            {


                Console.WriteLine($"User {username} logged in.");
            }

        }
    }
}
