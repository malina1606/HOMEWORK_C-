/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

Console.WriteLine("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [,] arrayA= new int [M, N];
int [,] A = new int [M, N];

/*static int[,] GenerateMatrix (int [,] array, int M, int N) {
    Random rand = new Random();
    int [,] array1 = new int [M, N];
    for (int i = 0; i < M; i++){
        for (int j = 0; j < N; j++){
            array1[i, j] = rand.Next(10);
            Console.Write(" " + array1[i, j]);
        }
        Console.WriteLine();
    }
    return (array1);
}

A=GenerateMatrix(arrayA, M, N);
Console.WriteLine();
for (int i = 0; i < M; i++){
    for (int j = 0; j < N-1; j++){
Console.Write(" " + A[i, j]);

    }
}*/


Random rand = new Random();
    for (int i = 0; i < M; i++){
        for (int j = 0; j < N; j++){
            A[i, j] = rand.Next(10);
            Console.Write(" " + A[i, j]);
        }
        Console.WriteLine();
    }

 Console.WriteLine(); 
 

for (int i = 0; i < M; i++){
    for (int j = 0; j < N; j++){
        for (int k = 0; k < N; k++) {
        if (A[i,j] <= A[i,k]) continue; 
            int q = A[i,j];
            A[i,j] = A[i,k];
            A[i,k] = q;  
        }
    }
} 

for(int i=0; i < M; i++){
    for (int j=0; j < N; j++) {
        Console.Write(" "+ A[i,j]);
    }
    Console.WriteLine();
}

