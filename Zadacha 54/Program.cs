/*Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
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

int m = GetNumber("Введие количство строк ");
int n = GetNumber("Введите количество столбцов ");
int[,] matrix = IntitMatrix(m, n);
PrintArray(matrix);
int tmp;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = matrix.GetLength(1) - 1; j > 0; j--)
    {
        for (int k = 0; k < j; k++)
        {
            if (matrix[i, k] < matrix[i, k + 1])
            {
                tmp = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = tmp;
            }
        }
    }
}
PrintArray(matrix);
