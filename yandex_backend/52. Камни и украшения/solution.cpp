#include <iostream>
#include <string>
#include <set>

using namespace std;

int main() {
  string j, s;
  getline(cin, j);
  getline(cin, s);

  set<char> jewelry_set(j.begin(), j.end());
  int count = 0;

  for (char c : s) {
    if (jewelry_set.count(c)) {
      count++;
    }
  }

  cout << count << endl;
  return 0;
}