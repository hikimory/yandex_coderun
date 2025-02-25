#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    int n;
    std::cin >> n;

    std::vector<int> a(n);
    for (int i = 0; i < n; ++i) {
        std::cin >> a[i];
    }

    std::sort(a.begin(), a.end());

    int count = 0;
    int i = 0;
    while (i < n) {
        int j = i;
        while (j < n && a[i] == a[j]) {
            j++;
        }
        if (j - i == 1) {
            count++;
        }
        i = j;
    }

    std::cout << count << std::endl;

    return 0;
}