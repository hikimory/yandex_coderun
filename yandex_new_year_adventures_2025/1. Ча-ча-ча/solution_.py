import sys

def round_away_from_zero(number: float) -> int:
    if number % 1 == 0.5:
        if number > 0:
           number+=0.5
        else:
           number-=0.5

    return int(round(number))

def main():
    grades: str = input()
    worst_grade: str = max(grades)

    total_diff: int = 0
    for grade in grades:
        total_diff += ord('Z') - ord(grade)

    average_diff: float  = total_diff / len(grades)

    rounded_average_diff: int = round_away_from_zero(average_diff)

    final_grade: int = ord('Z') - rounded_average_diff

    if final_grade < ord(worst_grade) - 1:
        final_grade = ord(worst_grade) - 1

    print(chr(final_grade))

if __name__ == '__main__':
    main()