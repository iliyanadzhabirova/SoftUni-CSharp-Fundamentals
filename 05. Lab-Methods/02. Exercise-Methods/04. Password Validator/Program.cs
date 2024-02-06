using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string password=Console.ReadLine();

            GetPassWord(password);
        }
        static void GetPassWord(string password)
        {
            int counter = 0;
            if (password.Length>=6&&password.Length<=10)
            {
                counter++;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            bool isAlpha = password.All(Char.IsLetterOrDigit);
            if (isAlpha==true)
            {
                counter++;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            
            
             int DigitCount = 0;
            bool areTwoDigits = false;
                foreach (char c in password)
                {
                    if (c >= '0' && c <= '9')
                    {
                      DigitCount++;
                        if (DigitCount >= 2)
                        {
                           
                        areTwoDigits= true;
                        break;
                    }
                    }
                        
                }
                if (areTwoDigits==false)
                {
                Console.WriteLine("Password must have at least 2 digits");
                }
                else
                {
                    counter++;
                }

            if (counter==3)
            {
                Console.WriteLine("Password is valid");
            }
            
           

        }
    }
}