import sys
from typing import List, Set

def find_common_and_all_languages(students: List[List[str]]) -> tuple[Set[str], Set[str]]:
    all_languages = set()
    if students:
        common_languages = set(students[0]) 
    else:
        common_languages = set() 

    for student_languages in students:
        all_languages.update(student_languages)
        common_languages = common_languages.intersection(student_languages)

    return common_languages, all_languages
def main() -> None:
    n = int(input())
    students: List[List[str]] = []
    for _ in range(n):
        m = int(input())
        student_languages: List[str] = set(input() for _ in range(m))
        students.append(student_languages)

    common_languages, all_languages = find_common_and_all_languages(students)

    print(len(common_languages))
    print(*common_languages, sep='\n')
    print(len(all_languages))
    print(*all_languages, sep='\n')

if __name__ == "__main__":
    main()