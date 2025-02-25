import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(System.out));

        int N = Integer.parseInt(reader.readLine());
        int[] shirts = new int[N];
        String[] shirtColors = reader.readLine().split(" ");
        for (int i = 0; i < N; i++) {
            shirts[i] = Integer.parseInt(shirtColors[i]);
        }

        int M = Integer.parseInt(reader.readLine());
        int[] pants = new int[M];
        String[] pantColors = reader.readLine().split(" ");
        for (int i = 0; i < M; i++) {
            pants[i] = Integer.parseInt(pantColors[i]);
        }

        int i = 0, j = 0;
        int minDiff = Integer.MAX_VALUE;
        int shirtColor = 0, pantColor = 0;

        while (i < N && j < M) {
            int diff = Math.abs(shirts[i] - pants[j]);
            if (diff < minDiff) {
                minDiff = diff;
                shirtColor = shirts[i];
                pantColor = pants[j];
            }
            if (shirts[i] < pants[j]) {
                i++;
            } else {
                j++;
            }
        }

        writer.write(shirtColor + " " + pantColor);

        reader.close();
        writer.close();
    }
}