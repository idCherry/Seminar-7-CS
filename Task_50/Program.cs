// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Двумерный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] array)
{
    Console.Write("Введите индекс i: ");
    int indexI = int.Parse(Console.ReadLine());

    Console.Write("Введите индекс j: ");
    int indexJ = int.Parse(Console.ReadLine());

    if (indexI < array.Length && indexJ < array.Length) Console.Write($"Элемент данных позиций -> {array[indexI, indexJ]}");
    if (indexI > array.Length || indexJ > array.Length) Console.Write("Такого числа в массиве нет");
    
}
int[,] arr = GetArray(7,7);
PrintArray(arr);

FindNumber(arr);