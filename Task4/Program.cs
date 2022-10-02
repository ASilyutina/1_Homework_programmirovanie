// Выяснить является ли число чётным
 Console.WriteLine("введите число: ");
 int n = Convert.ToInt32(Console.ReadLine()); 
if (n % 2 == 0) Console.WriteLine($"число {n} четное число");
else Console.WriteLine($"число {n} не четное число");

// 2ой способ Выяснить является ли число чётным

Console.Write("Введите число:    ");
string writeNumber = Console.ReadLine();
int number = Convert.ToInt32(writeNumber);
string result = $"Число {number} является чётным";

if (number % 2 != 0) result = result.Replace("является", "не является");

Console.WriteLine(result);
Console.WriteLine();