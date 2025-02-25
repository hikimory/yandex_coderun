import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.HashSet;
import java.util.Set;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(System.out));

        int n = Integer.parseInt(reader.readLine());

        Set<String> allLanguages = new HashSet<>();
        Set<String> commonLanguages = null;

        for (int i = 0; i < n; i++) 
		{
            int m = Integer.parseInt(reader.readLine());
            Set<String> studentLanguages = new HashSet<>();

            for (int j = 0; j < m; j++) 
			{
                String language = reader.readLine();
                studentLanguages.add(language);
                allLanguages.add(language);
            }

            if (commonLanguages == null) 
			{
                commonLanguages = new HashSet<>(studentLanguages);
            } else 
			{
                commonLanguages.retainAll(studentLanguages);
            }
        }

        System.out.println(commonLanguages.size());
        for (String language : commonLanguages) 
		{
            System.out.println(language);
        }

        System.out.println(allLanguages.size());
        for (String language : allLanguages) 
		{
            System.out.println(language);
        }

        reader.close();
        writer.close();
    }

}
