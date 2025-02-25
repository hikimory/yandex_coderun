import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.List;

public class Main {
	static long gcd(long a, long b) {
        while (b != 0) {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

	static long lcm(long a, long b) {
        return (a / gcd(a, b)) * b; // Улучшенное вычисление НОК
    }

	static List<Long> findDivisors(long n) {
        List<Long> divisors = new ArrayList<>();
        for (long i = 1; i * i <= n; i++) {
            if (n % i == 0) {
                divisors.add(i);
                if (i != n / i) {
                    divisors.add(n / i);
                }
            }
        }
        return divisors;
    }

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(System.out));
		
		String[] input = reader.readLine().split(" ");
		long x = Long.parseLong(input[0]);
        long y = Long.parseLong(input[1]);

        if (y % x != 0) {
            System.out.println(0);
            return;
        }

        long z = y / x;
        List<Long> divisors = findDivisors(z);

        int count = 0;
        for (long d : divisors) {
            long p = x * d;
            long q = y / d;
            if (gcd(p, q) == x && lcm(p, q) == y) {
                count++;
            }
        }

		writer.write(String.valueOf(count));
        reader.close();
        writer.close();
    }

}
