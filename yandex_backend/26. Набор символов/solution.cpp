#include <iostream>
#include <string>
#include <set>
#include <climits>

using namespace std;

int main() {
  string s;
  getline(cin, s);

  string c_str;
  getline(cin, c_str);
  set<char> c(c_str.begin(), c_str.end());

  int n = s.length();
  int min_len = INT_MAX;

  for (int i = 0; i < n; ++i) {
    for (int j = i; j < n; ++j) {
      string sub = s.substr(i, j - i + 1);
      set<char> sub_set(sub.begin(), sub.end());
      if (sub_set == c) {
        min_len = min(min_len, (int)sub.length());
      }
    }
  }

  if (min_len == INT_MAX) {
    cout << 0 << endl;
  } else {
    cout << min_len << endl;
  }

  return 0;
}