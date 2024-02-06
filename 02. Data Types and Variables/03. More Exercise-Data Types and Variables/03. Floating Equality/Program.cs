// See https://aka.ms/new-console-template for more information
double number1 = double.Parse(Console.ReadLine());
double number2=double.Parse(Console.ReadLine());

bool result = Math.Abs(number1 - number2) < 0.000001;
Console.WriteLine(result);
