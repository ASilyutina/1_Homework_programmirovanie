// Найти максимальное из трех чисел
int A = 70;
int B = 100;
int C = 15;
 if (A > B && A > C)
                    Console.WriteLine("A"); 
                else if (B > C)
                    Console.WriteLine("B"); 
                else
                    Console.WriteLine("C"); 




 // 2ой способ -Найти максимальное из трех чисел


int[] Numbers = { 100, 81, 2 };

for (int i = 0; i < 3; i++)
{
    int max = Numbers[0];
    
    if (Numbers[i] > max)
    {
        max = Numbers[i];
        System.Console.WriteLine();
        System.Console.WriteLine($"Максимальное число {max}");
    }
}
System.Console.WriteLine();
