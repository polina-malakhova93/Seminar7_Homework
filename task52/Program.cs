
int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");

int[,] numbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 10);
    }
}
PrintArray(numbers);

double[] sum = new double[m];
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum[i] += numbers[j, i];
    }
}

PrintArrayAverage(sum);

void PrintArrayAverage(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]/m  + " ");
    }
    Console.WriteLine();
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
