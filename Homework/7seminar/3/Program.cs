/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/

Console.WriteLine("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [M, N];
int [] sum= new int [N];
Random rand = new Random();
    for (int i = 0; i < M; i++){
        for (int j = 0; j < N; j++){
            array[i, j] = rand.Next(10);
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine();
    }
for (int k = 0; k < M; k++) {
    for (int l = 0; l < N; l++) {
        sum[k] += array[l,k];
        
    }
//Console.Write("Сумма столбцов : " + sum[k] + " ");
}
Console.Write("Среднее арифметическое столбцов : " );
for (int i = 0; i < N; i++ ) {
    Console.Write((double)sum[i]/M + " ");
}
