
int C = new Random().Next(10, 100);
int D = new Random().Next(1, 10);
if (D*D==C)
Console.WriteLine($"Число {C} является квадратом числа {D}");
else Console.WriteLine($"Число {C} не является квадратом числа {D}");

Console.WriteLine();
