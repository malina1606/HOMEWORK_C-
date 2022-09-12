/* Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

int count = 0;
Console.WriteLine("Введите размерность массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

for (int i = 0; i<N; i++) {
    Console.WriteLine("Введите элемент массива: ");
    int value = Convert.ToInt32(Console.ReadLine());
    array[i] = value;
    if (array[i] > 0) {
        count++;
    }
}

for(int j=0; j < N; j++)
Console.Write(" "+ array[j]+ " ");
Console.WriteLine("Количество положительных элементов массива: " + count);