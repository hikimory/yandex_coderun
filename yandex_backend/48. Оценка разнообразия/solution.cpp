#include <iostream>
#include <vector>
#include <map>
#include <climits>
#include <algorithm>

using namespace std;

int main() {
    int n;
    cin >> n;

    map<int, int> product_category;
    for (int i = 0; i < n; ++i) {
        int product, category;
        cin >> product >> category;
        product_category[product] = category;
    }

    vector<int> product_order(n);
    for (int i = 0; i < n; ++i) {
        cin >> product_order[i];
    }
    
    map<int, vector<int>> category_positions;
    for (int i = 0; i < n; ++i){
        int category = product_category[product_order[i]];
        category_positions[category].push_back(i);
    }
    
    if(category_positions.size() == n){
        cout << n << endl;
        return 0;
    }

    int min_diff = INT_MAX;
    for (const auto& pair : category_positions) {
        const vector<int>& positions = pair.second;
        for (size_t i = 0; i < positions.size() - 1; ++i) {
            int diff = positions[i + 1] - positions[i];
            min_diff = min(min_diff, diff);
        }
    }
    
    if (min_diff == INT_MAX)
        cout << n << endl;
    else 
        cout << min_diff << endl;
    
    return 0;
}