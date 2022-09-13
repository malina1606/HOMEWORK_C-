/*Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.*/

Console.WriteLine("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());
double [,] array = new double[M, N];
Random rand = new Random();
    for (int i = 0; i < M; i++){
        for (int j = 0; j < N; j++){
            array[i, j] = rand.NextDouble() * 100;
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine();
    }