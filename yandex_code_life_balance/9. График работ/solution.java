import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.PriorityQueue;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(System.out));

        int n = Integer.parseInt(reader.readLine());
        List<long[]> tasks = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            String[] parts = reader.readLine().split(" ");
            tasks.add(new long[]{Long.parseLong(parts[0]), Long.parseLong(parts[1])});
        }

        tasks.sort(Comparator.comparingLong(a -> a[0])); // sort by d_i

        PriorityQueue<Long> stressHeap = new PriorityQueue<>(); // Heap for storing stresses of completed tasks (min-heap)
        long totalStress = 0;

        for (long[] task : tasks) {
            long d = task[0];
            long w = task[1];
            // If there is time to complete a task, add it to the heap
            if (stressHeap.size() < d) {
                stressHeap.offer(w);
            } else {
                // If there is not enough time, we replace the task with a minimum stress if the current one is more important
                if (!stressHeap.isEmpty() && w > stressHeap.peek()) {
                  totalStress += stressHeap.poll();  // Remove minimal stress from completed tasks
                  stressHeap.offer(w); // Add current task
                } else {
                    // If the current task cannot be included, add its stress to the total
                    totalStress += w;
                }
            }
        }

        writer.write(String.valueOf(totalStress));
        writer.newLine();

        reader.close();
        writer.close();
    }
}