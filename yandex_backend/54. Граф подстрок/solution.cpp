#include <iostream>
#include <vector>
#include <string>
#include <set>
#include <map>

using namespace std;

int main() {
    int t;
    cin >> t;

    vector<string> words(t);
    for (int i = 0; i < t; ++i) {
        cin >> words[i];
    }

    set<string> nodes;
    map<pair<string, string>, int> edges;

    for (const string& word : words) {
        for (int i = 0; i < word.size() - 2; ++i) {
            string sub1 = word.substr(i, 3);
            nodes.insert(sub1);
            if (i < word.size() - 3) {
                string sub2 = word.substr(i + 1, 3);
                pair<string, string> edge = make_pair(sub1, sub2);
                if (edges.count(edge)) {
                    edges[edge]++;
                } else {
                    edges[edge] = 1;
                }
            }
        }
    }

    cout << nodes.size() << endl;
    cout << edges.size() << endl;

    for (const auto& pair : edges) {
        cout << pair.first.first << " " << pair.first.second << " " << pair.second << endl;
    }

    return 0;
}