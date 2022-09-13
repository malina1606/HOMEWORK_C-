/*Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.*/

Console.WriteLine("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [M, N];
Random rand = new Random();
    for (int i = 0; i < M; i++){
        for (int j = 0; j < N; j++){
            array[i, j] = rand.Next(100);
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine();
    }

Console.WriteLine("Введите номер строки b: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца b: ");
int b = Convert.ToInt32(Console.ReadLine());
if ((a>=0 && a<=M-1) && (b>=0 && b<=N-1)) {
    Console.WriteLine("Элемент массива с индексом [a][b]: " + array[a,b]);
}
else {
    Console.WriteLine("Элемент массива с индексом [a][b] в массиве нет " );
}