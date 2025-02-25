using System;
using System.Collections.Generic;

public class Solution
{
    public static void FormatCalendar(int nDays, string weekday)
    {
        Dictionary<string, int> weekdays = new Dictionary<string, int>()
        {
            {"Monday", 0},
            {"Tuesday", 1},
            {"Wednesday", 2},
            {"Thursday", 3},
            {"Friday", 4},
            {"Saturday", 5},
            {"Sunday", 6}
        };

        int startDay = weekdays[weekday];

        List<List<string>> calendar = new List<List<string>>();
        List<string> week = new List<string>();

        for (int i = 0; i < startDay; i++)
            week.Add("..");

        int day = 1;
        while (day <= nDays)
        {
            if (day < 10)
                week.Add("." + day.ToString());
            else
                week.Add(day.ToString());

            if (week.Count == 7)
            {
                calendar.Add(week);
                week = new List<string>();
            }
            day++;
        }

        if (week.Count > 0)
            calendar.Add(week);

        foreach (var w in calendar)
            Console.WriteLine(string.Join(" ", w));
    }

    public static void Main(string[] args)
    {
        string[] parts = Console.ReadLine().Split(' ');
        FormatCalendar(int.Parse(parts[0]), parts[1]);
    }
}