#pragma warning disable

// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9
/*
Console.WriteLine("Введите первое число");
int firstDigit = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondDigit = int.Parse(Console.ReadLine());

int[,] array = new int[4,4];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        System.Console.WriteLine();
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "  ");
        }
        System.Console.WriteLine();
    }
}

void FindElementArray()
{
    int Element=0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == firstDigit && j == secondDigit)
            {
                Element = array[i,j];
                Console.WriteLine($"({firstDigit}, {secondDigit}) => {Element}");
            }
        }
    }
    if(array.GetLength(0) <= firstDigit && array.GetLength(1) <= secondDigit)
    {
        Console.WriteLine($"({firstDigit}, {secondDigit}) => Такого элемента нет");
    }
}
CreateArray();
PrintArray();
FindElementArray();
*/

// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1
/*
int[,] array = new int[4,4];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        System.Console.WriteLine();
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "  ");
        }
        System.Console.WriteLine();
    }
}

void CreateArray2()
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
    }
}

CreateArray();
PrintArray();
Console.WriteLine(" => ");
CreateArray2();
PrintArray();
*/

// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2
/*
int[,] array = new int[4,5];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

int FindMinIndex()
{
    int minIndex = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumElements=0;
                
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElements += array[i,j];
        }
        if (sumElements < minSum)
        {
            minSum = sumElements;
            minIndex = i;
        }
    }
    Console.WriteLine($"=> Строка с индексом {minIndex}");
    return minIndex;
}

CreateArray();
PrintArray();
FindMinIndex();
*/