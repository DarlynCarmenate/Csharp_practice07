// Задайте двумерный массив размером mxn и зполните его случайными вещественныи числами.

double[,] FillArray(int row, int column)
{
	double[,] array = new double[row, column];
	Random rnd = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
		    array[i, j] = rnd.NextDouble() * 100;
		}
	} 
    return array;
}

void PrintArray(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]:0.00}\t"); 
		}
	Console.WriteLine();
	} 
}

double[,] array = FillArray(5, 4);
PrintArray(array);

