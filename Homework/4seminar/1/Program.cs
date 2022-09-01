 /*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()*/

int result =1;
Console.WriteLine("Введите натуральное число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int B = Convert.ToInt32(Console.ReadLine());
for (int i=1; i <= B; i++){ 
    result *= A;

}
Console.WriteLine("A^B =" + result);