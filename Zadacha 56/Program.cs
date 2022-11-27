/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] IntitMatrix(int m, int n)
{
    Random rnd = new();
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)

        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else

            Console.WriteLine("Введено не число. Повторите ввод.");

    return result;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void SumStringMatrix(int[,] matrix)
{
    int index = 0;
    int minSumma = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summa = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa = summa + matrix[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки = {summa}");
        if (i == 0)
        {
            minSumma = summa;
            index = i + 1;
        }
        else if (summa < minSumma)
        {
            minSumma = summa;
            index = i + 1;
        }
    }
    Console.WriteLine();
    Console.Write($"Номер строки с наименьшей суммой элементов: {index}");
}

int m = GetNumber("Введие количство строк ");
int n = GetNumber("Введите количество столбцов ");
int[,] matrix = IntitMatrix(m, n);
PrintArray(matrix);
SumStringMatrix(matrix);
