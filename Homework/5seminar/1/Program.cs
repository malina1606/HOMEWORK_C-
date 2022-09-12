/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int start = 100;
int stop = 999;
int count = 0;
Console.WriteLine("Введите размерность массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

for (int i=0; i<N; i++) {
    int value = new Random().Next(start,stop+1);
    array[i] = value;
    if (array[i] % 2 == 0) {
        count++;
    }

}
for(int i=0; i < N; i++)
Console.Write(" "+ array[i]+ " ");
Console.WriteLine("Количество четных элементов массива: " + count);
