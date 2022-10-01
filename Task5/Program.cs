// Показать четные числа от 1 до N

Console.WriteLine("Введите длину: ");
int n = Convert.ToInt32(Console.ReadLine());
    
for (int i = 2; i <= n; i += 2)
    Console.WriteLine(i);
