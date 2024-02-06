// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string input = Console.ReadLine();
while (input != "End")
{
    string[] command = input.Split();
    if (command.Contains("Remove"))
    {
        int index = int.Parse(command[1]);
        if (index >= numbers.Count||index<0)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.RemoveAt(index);
        }
        
    }
    else if (command.Contains("Add"))
    {
        int number = int.Parse(command[1]);
        numbers.Add(number);
    }
    else if (command.Contains("Insert"))
    {
        int elementToInsert = int.Parse(command[1]);
        int indexToInsert = int.Parse(command[2]);
        if (indexToInsert>=numbers.Count|| indexToInsert<0)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.Insert(indexToInsert, elementToInsert);
        }
    }
    else if (command.Contains("left"))
    {
        int timesTorepeat = int.Parse(command[2]);
        for (int i = 0; i < timesTorepeat; i++)
        {
            int addelement = numbers[0];
            numbers.Add(addelement);
            numbers.RemoveAt(0);
        }
    }
    else if (command.Contains("right"))
    {
        int timesTorepeat = int.Parse(command[2]);
        for (int i = 0; i < timesTorepeat; i++)
        {

            int removeElement = numbers[numbers.Count-1];
            numbers.Insert(0,removeElement);
            numbers.RemoveAt(numbers.Count-1);
            
        }
    }

    input = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));
//•	Add
//{ number} – add the given number to the end of the list
//•	Insert {number} { index} – insert the number at the given index
//•	Remove {index} – remove the number at the given index
//•	Shift left {count} – first number becomes last. This has to be repeated the specified number of times
//•	Shift right {count} – last number becomes first. To be repeated the specified number of times
//Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".
