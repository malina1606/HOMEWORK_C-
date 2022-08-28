int start = 100;
int stop = 1000;
int value = new Random().Next(start,stop);
Console.Write("Случайное число ", value);
Console.WriteLine(value);
int digit_first = value / 100;
int digit_second = (value % 100) / 10;
int digit_third = value % 10;

Console.Write("Вторая цифра ", digit_second);
Console.WriteLine(digit_second);