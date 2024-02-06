// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System;
using System.Data;
using System.Linq;
List<string> lessons = Console.ReadLine().Split(", ").ToList();
while (true)
{
    string input = Console.ReadLine();

    if (input == "course start")
    {
        break;
    }

    string[] command = input.Split(":").ToArray();
    string action = command[0];
    string lesson = command[1];

    if (action == "Add")
    {
        if (!lessons.Contains(lesson))
        {
            lessons.Add(lesson);
        }
    }
    else if (action == "Insert")
    {
        int index = int.Parse(command[2]);

        if (!lessons.Contains(lesson))
        {
            lessons.Insert(index, lesson);
        }
    }
    else if (action == "Remove")
    {
        if (lessons.Contains(lesson))
        {
            lessons.Remove(lesson);
        }
    }
    else if (action == "Swap")
    {
        string secondLesson = command[2];

        if (lessons.Contains(lesson) && lessons.Contains(secondLesson))
        {
            int firstIndex = lessons.IndexOf(lesson);
            int secondIndex = lessons.IndexOf(secondLesson);

            lessons[firstIndex] = secondLesson;
            lessons[secondIndex] = lesson;

            // Swap exercises if they exist
            if (firstIndex < lessons.Count - 1 && lessons[firstIndex + 1].StartsWith(lesson + "-Exercise"))
            {
                string tempExercise = lessons[firstIndex + 1];
                lessons.RemoveAt(firstIndex + 1);
                lessons.Insert(secondIndex + 1, tempExercise);
            }

            if (secondIndex < lessons.Count - 1 && lessons[secondIndex + 1].StartsWith(secondLesson + "-Exercise"))
            {
                string tempExercise = lessons[secondIndex + 1];
                lessons.RemoveAt(secondIndex + 1);
                lessons.Insert(firstIndex + 1, tempExercise);
            }
        }
    }
    else if (action == "Exercise")
    {
        int index = lessons.IndexOf(lesson);

        if (index != -1)
        {
            string exercise = lesson + "-Exercise";

            if (index == lessons.Count - 1 || !lessons[index + 1].StartsWith(exercise))
            {
                lessons.Insert(index + 1, exercise);
            }
        }
        else
        {
            lessons.Add(lesson);
            lessons.Add(lesson + "-Exercise");
        }
    }
}

for (int i = 0; i < lessons.Count; i++)
{
    Console.WriteLine($"{i + 1}.{lessons[i]}");
}