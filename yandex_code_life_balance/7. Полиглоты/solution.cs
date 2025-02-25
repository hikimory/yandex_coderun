using System;
using System.Collections.Generic;

class Program 
{
    static void Main() 
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> allLanguages = new HashSet<string>();
        HashSet<string> commonLanguages = null;

        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            HashSet<string> studentLanguages = new HashSet<string>();

            for (int j = 0; j < m; j++)
            {
                string language = Console.ReadLine();
                studentLanguages.Add(language);
                allLanguages.Add(language);
            }

            if (commonLanguages == null)
            {
                commonLanguages = studentLanguages;
            }
            else
            {
                commonLanguages.IntersectWith(studentLanguages);
            }
        }

        Console.WriteLine(commonLanguages.Count);
        foreach (string language in commonLanguages)
        {
            Console.WriteLine(language);
        }

        Console.WriteLine(allLanguages.Count);
        foreach (string language in allLanguages)
        {
            Console.WriteLine(language);
        }
    }
}