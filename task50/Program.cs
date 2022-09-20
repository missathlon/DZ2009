// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// Пример
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ввод:
// 2 строка
// 1 столбец
// Вывод:
// 4


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}

void ShowElement(int[,] matrix, int i, int j)
{
    if (i >= matrix.GetLength(0)
        || j >= matrix.GetLength(1))
        Console.WriteLine("Net takogo elementa");
    else Console.Write(matrix[i, j]);
}

Console.Write("Amount of srtings: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Amount of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);

Console.Write("Number of string: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of column: ");
int j = Convert.ToInt32(Console.ReadLine());

ShowElement(matrix, i, j);