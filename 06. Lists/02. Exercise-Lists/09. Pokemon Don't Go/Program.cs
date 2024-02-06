// See https://aka.ms/new-console-template for more information

List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> DeletedNumbers = new List<int>();

double totalSum = 0;

while (list.Count != 0)
{
    //bool check = true;
    bool checkInsideIndex = true;
    int index = int.Parse(Console.ReadLine());
    int numberIndex = 0;

    if (index < 0)
    {
        //DeletedNumbers.Add(list[0]);
        numberIndex = list[0];
        totalSum += list[0];
        list.RemoveAt(0);
        list.Insert(0, list[list.Count - 1]);
        checkInsideIndex = false;
    }
    else if (index > list.Count - 1)
    {
        //DeletedNumbers.Add(list[list.Count - 1]);
        numberIndex = list[list.Count - 1];
        totalSum += list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        list.Add(list[0]);
        checkInsideIndex = false;
    }

    if (checkInsideIndex)
    {
        numberIndex = list[index];
        totalSum += numberIndex;
        list.RemoveAt(index);
    }

    //if (index > list.Count - 1)
    //{
    //    NumberIndex = list[list.Count - 1];
    //    index = list.Count - 1;
    //    check = false;
    //}
    //else if (index < 0)
    //{
    //    NumberIndex = list[0];
    //    index = 0;
    //    check = false;
    //}
    //else
    //{

    //    NumberIndex = list[index];
    //}

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] <= numberIndex)
        {
            list[i] += numberIndex;
        }
        else if (list[i] > numberIndex)
        {
            list[i] -= numberIndex;
        }
    }
    //DeletedNumbers.Add(NumberIndex);
    //if (check == true)
    //{
    //    list.RemoveAt(index);
    //}
}
//double sum = DeletedNumbers.Sum();
Console.WriteLine(totalSum);

