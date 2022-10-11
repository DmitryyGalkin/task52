/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
Console.Clear();

Console.WriteLine("Введите значение m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n:");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];



FillArray(array);
PrintArray(array);
CalculateArithmeticMean(array);
Console.WriteLine();
PrintAvergeArray(CalculateArithmeticMean(array));

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }

}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}

double[] CalculateArithmeticMean(int[,] array)
{
    double sum;
    double[] average = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];

        }
        average[i] = sum / array.GetLength(0);
    }
    return average;
}
void PrintAvergeArray(double[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)} ");

    }
}