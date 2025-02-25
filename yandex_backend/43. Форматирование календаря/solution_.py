import sys
from typing import Dict, List

def format_calendar(nDays: int, weekday: str) -> None:
    weekdays: Dict[str, int] = {
        "Monday": 0,
        "Tuesday": 1,
        "Wednesday": 2,
        "Thursday": 3,
        "Friday": 4,
        "Saturday": 5,
        "Sunday": 6
    }
    
    start_day: int = weekdays[weekday]
    
    calendar: List[List[str]] = []
    week: List[str] = []
    
    for _ in range(start_day):
        week.append("..")
    
    day: int = 1
    while day <= nDays:
        if day < 10:
            week.append(f".{day}")
        else:
            week.append(str(day))
        
        if len(week) == 7:
            calendar.append(week)
            week = []
        day += 1
        
    if week:
      calendar.append(week)
    
    for week in calendar:
        print(" ".join(week))

def main():
    input_str: List[str] = input().split()
    format_calendar(int(input_str[0]), input_str[1])

if __name__ == '__main__':
    main()