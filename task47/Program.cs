
int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");

double[,] numbers = new double[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = Convert.ToDouble(new Random().Next(-100, 1000)) / 10;
    }
}
PrintArray(numbers);

void PrintArray(double[,] array)
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