/*Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.*/
int i=0;
int num =1;
Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
while (i < N){
    array[i]=num * num * num;
    Console.Write(array[i]+" ");
    num++;
    i++;
}
