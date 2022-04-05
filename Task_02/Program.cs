// Напишите программу, которая на вход принимает позиции элемента в двуменом массиве
// и возвращает значение этого элемента или же указание, что такого элемента не существует

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int value = int.Parse(strValue);
    return value;
}

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

bool ElementExist(int[,] arr, int x, int y)
{
    if (x > arr.GetLength(0) || y > arr.GetLength(1))
    {
        return false;
    }
    return true;
}

int[,] arr = FillArray(5, 5);
PrintArray(arr);
int x = Prompt("Введите координату x: ");
int y = Prompt("Введите координату y: ");

if(ElementExist(arr, x, y))
Console.WriteLine($"Значение элемента: {arr[x, y]}");
else Console.WriteLine("Такого элемента не существует");

