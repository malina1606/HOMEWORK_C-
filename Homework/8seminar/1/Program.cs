/*Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

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
for (int i = 0; i < M; i++) {
    for (int j = 0; j < N; j++) {
        sum[i] += array[i,j];
        
    }
Console.Write("" + sum[i] + " ");
}
int index = 0;
int min = sum[0];
for (int i = 0; i < M; i++ ) {
    if (sum[i] < min)
        min = sum[i];
}    
for (int i = 0; i < N; i++) {
    if (min == sum[i])
        index = i;    

}
Console.WriteLine("Индекс строки с наименьшей суммой : " + index);