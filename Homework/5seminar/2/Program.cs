/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).*/

int start = 1;
int stop = 1000000;
int summ = 0;
Console.WriteLine("Введите размерность массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

for (int i=0; i<N; i++) {
    int value = new Random().Next(start,stop+1);
    array[i] = value;
    if ((array[i] % 2 == 0) && (i % 2 !=0)) {
        summ+=array[i];
    }
}

for(int i=0; i < N; i++)
Console.Write(" "+ array[i]+ " ");
Console.WriteLine("Сумма четных элементов, стоящих на нечётных позициях: " + summ);