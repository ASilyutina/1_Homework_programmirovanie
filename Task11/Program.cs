// Найти третью цифру числа или сообщить, что её нет

int Number = new Random().Next(1, 3000);
System.Console.WriteLine();
System.Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0) Console.WriteLine($"Третьей с конца цифрой числа {Number} является цифра {Number / 100 % 10}");
else Console.WriteLine($"У числа {Number} нет третьей цифры");

Console.WriteLine();