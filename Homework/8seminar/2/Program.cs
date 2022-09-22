/* Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.*/

Console.WriteLine("Введите порядок квадратных матриц N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [,] arrayA= new int [N, N];
int [,] arrayB = new int [N, N];
int [,] A = new int [N, N];
int [,] B = new int [N, N];

 static int[,] GenerateMatrix (int [,] array, int N) {
    Random rand = new Random();
    int [,] array1 = new int [N, N];
    for (int i = 0; i < N; i++){
        for (int j = 0; j < N; j++){
            array1[i, j] = rand.Next(10);
            Console.Write(" " + array1[i, j]);
        }
        Console.WriteLine();
    }
    return (array1);
}

static int[,] MultiplicationMatrix (int [,] array11, int [,] array22, int N) {
    int [,] arrayC = new int [N, N];
    for (int i = 0; i < N; i++){
        for (int j = 0; j < N; j++){
            for (int k = 0; k < N; k++){
                arrayC[i, j] += array11[i,k]*array22[k,j];
                
            }            
        Console.Write(" " + arrayC[i, j]);
        }
    Console.WriteLine();
    }
    return (arrayC);
    
}

A=GenerateMatrix(arrayA, N);
 Console.WriteLine();
B= GenerateMatrix(arrayB, N);
Console.WriteLine();
MultiplicationMatrix(A, B, N);
