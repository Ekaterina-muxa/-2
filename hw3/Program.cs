/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matr)
{ 
 for (int i = 0; i < m; i++)
 { 
    for (int j = 0; j < n; j++)
 { 
    Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
 }

void FillArray(int[,] matr)
{ 
    for (int i = 0; i < m; i++)
 { 
    for (int j = 0; j < n; j++)
 { 
    matr[i,j] = new Random().Next(1,100);}
 }
}

void AverageArray(int[,] matr)
{
for (int j = 0; j < n; j++)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + matr[i, j];
    }
    Console.WriteLine($"{ sum / m} ");
}
}

int[,] matrix = new int[m,n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
AverageArray(matrix);
