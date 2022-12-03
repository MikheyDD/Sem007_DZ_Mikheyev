// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];

FillArray(array);
Print(array);
FindItemByPosition(array);
FindItemByValue(array);


void FindItemByValue(int[,] arr)
{
    Console.WriteLine("Введите значение искомого элемента");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == num)
            {
                Console.WriteLine($"число находится на позиции {i},{j} ");
            }
            else Console.WriteLine("такого числа в массиве нет");
        }
    }
}

void FindItemByPosition(int[,] arr)
{ 
    Console.WriteLine("Введите номер строки искомого элемента");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца искомого элемента");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x <= arr.GetLength(0) && y <= arr.GetLength(1) && x >= 0 && y >= 0)
        {
            Console.WriteLine(arr[x,y]);
        }
        else Console.WriteLine("такого элемента в массиве нет");
}


int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 101);
        }
    }
    return arr;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}