Dictionary<string,List<double>>students= new Dictionary<string,List<double>>();

int n=int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    string studentName= Console.ReadLine();
    double grade=double.Parse(Console.ReadLine());

    if (!students.ContainsKey(studentName))
    {
        students[studentName] = new List<double>();
    }
    students[studentName].Add(grade);
}
foreach (var kvp in students)
{
    double avgGrade = kvp.Value.Average();
    if (avgGrade>=4.5)
    {
        Console.WriteLine($"{kvp.Key} -> {avgGrade:f2}");
    }
}
    