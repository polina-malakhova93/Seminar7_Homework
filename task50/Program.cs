int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");
int[,] numbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 100);
    }
}
PrintArray(numbers);

int line = Input("Введите индекс строки: ");
int column = Input("Введите индекс столбца: ");

if (line > (numbers.GetLength(0) - 1) || column > (numbers.GetLength(1) - 1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (i == line && j == column)
            {
                Console.WriteLine(numbers[i, j]);
            }
        }
    }
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
