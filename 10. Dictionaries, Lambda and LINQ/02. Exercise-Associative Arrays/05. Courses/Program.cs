Dictionary<string,List<string>>courses=new Dictionary<string, List<string>>();

string input=Console.ReadLine();
while (input != "end")
{
    string[] courseInfo = input.Split(":",StringSplitOptions.RemoveEmptyEntries);
    string courseName = courseInfo[0].Trim();
    string studentname = courseInfo[1];
  
    if (!courses.ContainsKey(courseName))
    {
        courses[courseName] = new List<string>();
      
    }
   if (!courses[courseName].Contains(studentname))
    {
        courses[courseName].Add(studentname);      
    }

    input=Console.ReadLine();
}
foreach (var kvp in courses)
{
    int studentsNumber = kvp.Value.Count;
    Console.WriteLine($"{kvp.Key+':'} {studentsNumber}");
    foreach (var item in kvp.Value)
    {
        Console.WriteLine($"--{item}");
    }
}