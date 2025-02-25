#include <iostream>
#include <vector>
#include <algorithm>
#include <limits>

using namespace std;

int main() {
    int t;
    cin >> t;

    for (int i = 0; i < t; i++) {
        int n;
        cin >> n;

        vector<int> a(n);
        for (int j = 0; j < n; j++) {
            cin >> a[j];
        }

        sort(a.begin(), a.end()); 
        int minXor = numeric_limits<int>::max(); 

        for (int j = 1; j < n; j++) {
            int xorVal = a[j] ^ a[j - 1];
            minXor = min(minXor, xorVal);
        }

        cout << minXor << endl;
    }

    return 0;
}