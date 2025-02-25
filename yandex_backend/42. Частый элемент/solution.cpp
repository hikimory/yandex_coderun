#include <iostream>
#include <vector>
#include <unordered_map>
#include <limits>

using namespace std;

int mostFrequentElement(const vector<int>& arr) {
    unordered_map<int, int> counts;
    int maxCount = 0;
    int mostFrequent = numeric_limits<int>::min();

    for (int num : arr) {
        counts[num]++;
        if (counts[num] > maxCount) {
            maxCount = counts[num];
            mostFrequent = num;
        } else if (counts[num] == maxCount && num > mostFrequent) {
            mostFrequent = num;
        }
    }
    return mostFrequent;
}

int main() {
    int n;
    cin >> n;

    vector<int> arr(n);
    for (int i = 0; i < n; ++i) {
        cin >> arr[i];
    }

    int result = mostFrequentElement(arr);
    cout << result << endl;

    return 0;
}