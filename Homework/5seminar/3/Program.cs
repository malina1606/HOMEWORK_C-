/*Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива. */


int start = 1;
int stop = 1000000;
int diff = 0;
Console.WriteLine("Введите размерность массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

for (int i=0; i<N; i++) {
    int value = new Random().Next(start,stop+1);
    array[i] = value;
}
int min = array[0];
int max = array[N-1];
for (int j = 0; j < N; j++){
            if (array[j] > max)
                max = array[j];
}      
for (int k = 0; k < N; k++){
            if (array[k] < min)
                min = array[k];
}      
diff = max - min;
for(int i=0; i < N; i++)
Console.Write(" "+ array[i]+ " ");
Console.WriteLine("Разницу между максимальным и минимальным элементом массива: " + diff);