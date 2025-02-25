import sys
from itertools import combinations

def can_choose_boxes(n, boxes):
    total_mandarins = sum(box[0] for box in boxes)
    total_oranges = sum(box[1] for box in boxes)
    
    boxes.sort(key=lambda x: (-x[0], -x[1]))
    
    current_mandarins = 0
    current_oranges = 0
    
    for box in boxes:
        current_mandarins += box[0]
        current_oranges += box[1]
        
        if current_mandarins >= total_mandarins // 2 and current_oranges >= total_oranges // 2:
            return "Yes"
    
    return "No"

def main():
    n = int(input())
    fruits = []
    for _ in range(2*n-1):
        mandarins, oranges = map(int, input().split())
        fruits.append((mandarins, oranges))

    print(can_choose_boxes(n, fruits))

if __name__ == '__main__':
    main()