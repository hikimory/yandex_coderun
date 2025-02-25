#include <iostream>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

long gcd(long a, long b) {
    while (b != 0) {
        long temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

long lcm(long a, long b) {
    return (a / gcd(a, b)) * b;
}

vector<long> findDivisors(long n) {
    vector<long> divisors;
    for (long i = 1; i * i <= n; ++i) {
        if (n % i == 0) {
            divisors.push_back(i);
            if (i != n / i) {
                divisors.push_back(n / i);
            }
        }
    }
    return divisors;
}

int main() {
    long x, y;
    cin >> x >> y;

    if (y % x != 0) {
        cout << 0 << endl;
        return 0;
    }

    long z = y / x;
    vector<long> divisors = findDivisors(z);

    int count = 0;
    for (long d : divisors) {
        long p = x * d;
        long q = y / d;
        if (gcd(p, q) == x && lcm(p, q) == y) {
            count++;
        }
    }

    cout << count << endl;

    return 0;
}