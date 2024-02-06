// See https://aka.ms/new-console-template for more information
//•	Delete
//{ element} – delete all elements in the array, which are equal to the given element.
//•	Insert {element} { position} – insert the element at the given position.

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string input =Console.ReadLine();
while (input!="end")
{
    string[] command = input.Split();
    if (command.Contains("Delete"))
    {
        int elemenToDelete = int.Parse(command[1]);
        for (int i = 0; i <numbers.Count; i++)
        {       
            if (numbers[i] ==elemenToDelete)
            {
                numbers.Remove(elemenToDelete);
            }
        }
    }
    else if (command.Contains("Insert"))
    {
        int elementToInsert=int.Parse(command[1]);
        int indexToInsert = int.Parse(command[2]);
        numbers.Insert(indexToInsert,elementToInsert);
    }
   
    input = Console.ReadLine();
}
Console.WriteLine(string.Join(" ",numbers));