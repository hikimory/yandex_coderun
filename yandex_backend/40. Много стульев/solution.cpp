#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
    int n, m;
    cin >> n >> m;

    vector<int> sellers(n);
    for (int i = 0; i < n; ++i) {
        cin >> sellers[i];
    }

    vector<int> buyers(m);
    for (int i = 0; i < m; ++i) {
        cin >> buyers[i];
    }

    sort(sellers.begin(), sellers.end());
    sort(buyers.begin(), buyers.end());

    long profit = 0;
    int seller_idx = 0;
    int buyer_idx = m - 1;

    while (seller_idx < n && buyer_idx >= 0) {
        if (buyers[buyer_idx] > sellers[seller_idx]) {
            profit += (long)(buyers[buyer_idx] - sellers[seller_idx]);
            seller_idx++;
            buyer_idx--;
        } else {
            buyer_idx--;
        }
    }

    cout << profit << endl;

    return 0;
}