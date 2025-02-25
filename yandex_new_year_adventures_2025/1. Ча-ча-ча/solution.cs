using System;
using System.Linq;

class Program 
{
    static void Main() 
    {
        string grades = Console.ReadLine();
        char worstGrade = grades.Max();

        double sum = 0;
        foreach (char grade in grades)
            sum += 'Z' - grade;

        double average = sum / grades.Length;

        int roundedAverage = (int)Math.Round(average, MidpointRounding.AwayFromZero);

        char finalGrade = (char)('Z' - roundedAverage);

        if (finalGrade < worstGrade - 1)
            finalGrade = (char)(worstGrade - 1);

        Console.WriteLine(finalGrade);
    }
}