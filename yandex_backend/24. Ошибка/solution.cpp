#include <iostream>
#include <vector>
#include <iomanip>

using namespace std;

int main() {
    int n;
    cin >> n;

    vector<pair<double, double>> servers;
    for (int i = 0; i < n; ++i) {
        int a, b;
        cin >> a >> b;
        servers.push_back(make_pair(a / 100.0, b / 100.0));
    }

    double total_error_probability = 0.0;
    for (const auto& server : servers) {
        total_error_probability += server.first * server.second;
    }

    cout << fixed << setprecision(10); // Установка точности для вывода double
    for (const auto& server : servers) {
        double server_error_probability = server.first * server.second;
        double probability_of_error_on_server = server_error_probability / total_error_probability;
        cout << probability_of_error_on_server << endl;
    }

    return 0;
}