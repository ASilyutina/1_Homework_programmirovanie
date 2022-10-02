// Показать четные числа от 1 до N

Console.WriteLine("Введите длину: ");
int n = Convert.ToInt32(Console.ReadLine());
    
for (int i = 2; i <= n; i += 2)
    Console.WriteLine(i);

// 2ой способ -Показать четные числа от 1 до N

Console.Write("Введите число:   ");
string txtN = Console.ReadLine();
int endNum = Convert.ToInt32(txtN);
int num = 0;
Console.WriteLine($"Чётные числа из диапазона от 1 до {endNum}:");
while (num < endNum)
{
    num++;
    if (num % 2 == 0) Console.Write($"{num} ");
}
Console.WriteLine(); Console.WriteLine();