int start = 1;
int stop = 65536;
int value = new Random().Next(start,stop+1);
Console.Write("Случайное число ", value);
Console.WriteLine(value);

if (value < 100) {
    Console.Write("Третьей цифры нет");
} 
else {
    int digit_first = value / 10000;
    int digit_second = (value % 10000) / 1000;
    int digit_third = (value % 1000) /100;

    Console.Write("Третья цифра ", digit_third);
    Console.WriteLine(digit_third);
}

