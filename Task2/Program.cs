// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(System.Console.ReadLine());
// }

// int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
// {
//     int[,] matrix = new int[row, col];
//     Random rand = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FindNumber(int[,] newmatrix, int a, int b)
// {
//     for (int i = 0; i < newmatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < newmatrix.GetLength(1); j++)
//         {
//             if (a == i && b == j)
//             {
//                 System.Console.Write(newmatrix[i, j]);
//             }
//             else if (a != i && b != j)
//             {
//                 System.Console.Write("Error");
//             }
//         }
//     }
// }

// int[,] matrix = FillMatrix(ReadInt("Insert number row: "), ReadInt("Insert number col: "), 0, 99);
// PrintMatrix(matrix);
// FindNumber()

Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] randomArray = new double[m, n];

Console.Write("Введите первую позицию: ");
int m2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую позицию: ");
int n2 = Convert.ToInt32(Console.ReadLine());

void numb(int m, int n)
{
    int i, j;
    Random rand = new Random();

    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.NextDouble();
            Console.Write($"{randomArray[i, j]:F2} ");
        }
        Console.WriteLine();
    }
}

numb(m, n);

if (m2 < 1 || n2 < 1)
{
    Console.Write("Позиции строк не могут быть отрицательными");
}
else if (m2 <= m + 1 && n2 <= n + 1)
{    
    Console.Write($"Значение элемента равно {randomArray[m2 - 1, n2 - 1]:F2} ");
}
else 
{
    Console.Write("Такого элемента нет в массиве");
}