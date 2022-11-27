/*Задача 58: Задайте две матрицы. Напишите программу, которая
 будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int[,] IntitFirstMatrix(int m, int n)
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
int[,] IntitSecondMatrix(int n, int k)
{
    Random rnd = new();
    int[,] matrix = new int[n, k];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
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
int[,] ProductOfMatrices(int[,] firstmatrix, int[,] secondmatrix)
{
    int[,] matrix = new int[firstmatrix.GetLength(0), secondmatrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            for (int l = 0; l < firstmatrix.GetLength(1); l++)
            {
                matrix[i, j] = matrix[i, j] + firstmatrix[i, l] * secondmatrix[l, j];
            }
        }
    }
    return matrix;
}

int m = GetNumber("Введие m ");
int n = GetNumber("Введите n ");
int k = GetNumber("Введите k ");
int[,] firstmatrix = IntitFirstMatrix(m, n);
int[,] secondmatrix = IntitSecondMatrix(n, k);
int[,] resultmatrix = ProductOfMatrices(firstmatrix, secondmatrix);
PrintArray(firstmatrix);
PrintArray(secondmatrix);
PrintArray(resultmatrix);
