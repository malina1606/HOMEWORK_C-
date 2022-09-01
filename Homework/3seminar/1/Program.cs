/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string) */

int A=0;
string s;
int digit1 =0;
int digit2 =0;
int digit3 =0;
int digit4 =0;
int digit5 =0;
Console.Write("Введите пятизначное число: ");
s = Console.ReadLine();
A=Int32.Parse(s);
if (A > 99999 || A < 10000) {
    Console.WriteLine("Неверные данные");

}

digit1 = A / 10000;
digit2 = (A % 10000) / 1000;
digit3 = (A % 1000) /100;
digit5 = A % 10; 
A /= 10;
digit4 = A % 10;

if ((digit5 == digit1) && (digit2 == digit4)) {
    Console.WriteLine("Данное число является палиндромом");
} 
else {
     Console.WriteLine("Данное число не является палиндромом");
}
