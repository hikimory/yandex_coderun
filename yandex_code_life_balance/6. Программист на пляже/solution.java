import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(System.out));
		
        int t = Integer.parseInt(reader.readLine());

        for (int i = 0; i < t; i++) {
            int n = Integer.parseInt(reader.readLine());
            String[] input = reader.readLine().split(" ");
            
            int[] a = new int[n];
            for (int j = 0; j < n; j++) {
                a[j] = Integer.parseInt(input[j]);
            }

            Arrays.sort(a);
            int minXor = Integer.MAX_VALUE;

            for (int j = 1; j < n; j++) {
                int xorVal = a[j] ^ a[j - 1];
                minXor = Math.min(minXor, xorVal);
            }

            writer.write(String.valueOf(minXor));
            writer.newLine();
        }
        reader.close();
        writer.close();
    }

}