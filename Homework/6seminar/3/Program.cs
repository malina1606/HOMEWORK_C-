/*Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.*/

int start = 1;
int stop = 10;
int proizv =0;
Console.WriteLine("Введите размерность массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

for (int i=0; i<N; i++) {
    int value = new Random().Next(start,stop+1);
    array[i] = value;
}

for(int i = 0; i < N/2; i++){
    proizv += array[i]*array[N-i-1];
}

Console.WriteLine(string.Join(" ",array));
Console.WriteLine(proizv);