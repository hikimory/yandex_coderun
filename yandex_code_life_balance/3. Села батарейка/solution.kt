import java.io.BufferedReader
import java.io.BufferedWriter
import java.io.InputStreamReader
import java.io.OutputStreamWriter

fun main(args: Array<String>) {
	val reader = BufferedReader(InputStreamReader(System.`in`))
	val writer = BufferedWriter(OutputStreamWriter(System.out))
	
	val n = reader.readLine().toInt()
    val consumptions = reader.readLine().split(" ").map { it.toInt() }
    val totalConsumption = consumptions.sum()
    val fullHours = 100 / totalConsumption
	writer.write(fullHours.toString())

	reader.close()
	writer.close()
}