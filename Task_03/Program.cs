// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое в каждом столбце.

int[,] FillArray(int row, int column)
{
	int[,] array = new int[row, column];
	Random rnd = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = rnd.Next(1, 20); 
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

void AverageColumn(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
        double average = 0;
		for (int j = 0; j < array.GetLength(1); j++)
		{
			average += array[j, i];
		}
        Console.Write($"{average/array.GetLength(0):0.00}    "); 
	} 
}


int[,] array = FillArray(5, 5);
PrintArray(array);
Console.WriteLine("Среднее арифметическое в каждом столбце:");
AverageColumn(array);
