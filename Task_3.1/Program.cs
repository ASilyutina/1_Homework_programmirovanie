// 3.1) Найти кубы чисел от 1 до N

Console.WriteLine("Введите последнее число диапазона: ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);


int[] GetCubeTable(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}

void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{number} ^ 3 = ");
        System.Console.WriteLine(array[i]);
        number++;
    }
}

int[] CubeTable = GetCubeTable(N);
PrintCubs(CubeTable);