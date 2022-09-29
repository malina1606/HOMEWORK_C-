/*Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
Напишите программу, которая будет построчно выводить массив.*/

Console.WriteLine("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 1;
int stop = 26;
int value = 0;
int [,] array = new int [M, N];
bool flag= true;
bool b=true;
bool Contains(int[,] arr, int value, int M, int N){
    for (int i = 0; i < M; i++){
        for (int j = 0; j < N; j++){
            if (array[i,j] == value){
                b = true;
            }
            else b = false;
        }
    }
    return b;
}


if (M*N > 50) {
    Console.WriteLine("Количество элементов массива больше 50 ");
}
else {
    for (int i = 0; i < M; i++){
        for (int j = 0; j < N; j++){
            value = new Random().Next(start,stop);
            flag = Contains(array,value,M,N);
            if (flag == false) {
                array[i,j] = value;
                //Console.Write(" " + array[i, j]);
            }
            else {
                i++;
            }
        }
        Console.WriteLine();
    }
        for(int i=0; i < M; i++){
            for (int j=0; j < N; j++) {
                Console.Write(" "+ array[i,j]);
            }
            Console.WriteLine();
        }
            
}