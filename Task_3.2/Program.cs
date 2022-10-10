// Подсчитать сумму цифр в числе

//System.Console.Write("Введите число:   ");
//string writeA = Console.ReadLine();
//int A = Convert.ToInt32(writeA);

//int GetNumbersSum(int A)
//{
//    int number = 1;
//    int sum = 0;
  //  for (int i = 0; i < A; i++)
    //{
    //    sum = sum + number;
      //  number++;
   // }
  //  return sum;
//}

//int NumbersSum = GetNumbersSum(A);
//System.Console.WriteLine($"Сумма чисел от 1 до {A} составляет {NumbersSum}");

int number = new Random().Next(1, 100000);
int sumDigit = 0;
System.Console.Write($"Сумма цифр числа {number} равна ");

while (number > 0)
{
    int digit = number % 10;
    sumDigit = sumDigit + digit;
    number = number / 10;
}

System.Console.WriteLine(sumDigit);
System.Console.WriteLine();