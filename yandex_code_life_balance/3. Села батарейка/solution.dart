import 'dart:io';

void main() {
  var reader = stdin;
  var writer = stdout;
  int n = int.parse(reader.readLineSync()!);

  List<int> values = reader.readLineSync()!.split(' ').map(int.parse).toList();
  int totalConsumption = values.reduce((a, b) => a + b);
  writer.writeln(100 ~/ totalConsumption);

}