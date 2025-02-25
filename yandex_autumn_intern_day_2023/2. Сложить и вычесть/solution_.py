import sys
from typing import List

def calculate(s: str) -> int:
    result: int = 0
    current_number: int = 0
    operation: str = '+'
    l: int = len(s) - 1
    for i in range(len(s)):
        c: str = s[i]

        if c.isdigit():
            current_number = current_number * 10 + int(c)

        if not c.isdigit() or i == l:
            if operation == '+':
                result += current_number
            elif operation == '-':
                result -= current_number
            current_number = 0
            operation = c 

    return result

def main():
    s: str = input()
    print(calculate(s))

if __name__ == '__main__':
    main()