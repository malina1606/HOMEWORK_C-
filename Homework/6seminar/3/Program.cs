/*Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.*/

int start = 1;
int stop = 10;
int index = 1;
int proizv =0;
Console.WriteLine("Введите размерность массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

for (int i=0; i<N; i++) {
    int value = new Random().Next(start,stop+1);
    array[i] = value;
}

int first =1;
first = array[0]*array[N-1];
while (index<N-1) {
    proizv = proizv + array[index-1]*array[N-index];                         // Не могу найти ошибку в вычислениях, подскажите где ошибка
    Console.WriteLine("промежуточное произведение: "+ index +" "+ proizv);
    index++;
}

int a=0;
a = proizv + first;
for(int i=0; i < N; i++)
Console.Write(" "+ array[i]+ " ");
Console.WriteLine("itog: " + proizv);
