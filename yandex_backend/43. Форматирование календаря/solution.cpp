#include <iostream>
#include <vector>
#include <string>
#include <sstream>
#include <unordered_map>

using namespace std;

void formatCalendar(int nDays, const string& weekday) {
    unordered_map<string, int> weekdays = {
        {"Monday", 0},
        {"Tuesday", 1},
        {"Wednesday", 2},
        {"Thursday", 3},
        {"Friday", 4},
        {"Saturday", 5},
        {"Sunday", 6}
    };
    
    int startDay  = weekdays.at(weekday);

    vector<vector<string>> calendar;
    vector<string> week;

    for (int i = 0; i < startDay; ++i) {
        week.push_back("..");
    }

    int day = 1;
    while (day <= nDays) {
        if (day < 10) {
            week.push_back("." + to_string(day));
        } else {
            week.push_back(to_string(day));
        }

        if (week.size() == 7) {
            calendar.push_back(week);
            week.clear();
        }
        day++;
    }

    if (!week.empty()) {
        calendar.push_back(week);
    }

    for (const auto& w : calendar) {
        for (size_t i = 0; i < w.size(); ++i) {
            cout << w[i] << (i == w.size() - 1 ? "" : " ");
        }
        cout << endl;
    }
}

int main() {
    string inputLine;
    getline(cin, inputLine);
    
    stringstream ss(inputLine);
    int nDays;
    string weekday;
    ss >> nDays >> weekday;

    formatCalendar(nDays, weekday);
    
    return 0;
}