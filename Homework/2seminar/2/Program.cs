int start = 1;
int stop = 65536;
//int stop = 9999;
int digit_first = 0;
int digit_second = 0;
int digit_third = 0;
int value = new Random().Next(start,stop+1);
Console.Write("Случайное число ", value);
Console.WriteLine(value);

if (value < 100) {
    Console.Write("Третьей цифры нет");
} 

if (value >= 100 && value <= 999) {
    digit_third = value % 10;
}

if (value >= 1000 && value <= 9999) {
    value /= 10;
    digit_third = value % 10;
}

if (value >= 10000) {
     digit_first = value / 10000;
     digit_second = (value % 10000) / 1000;
     digit_third = (value % 1000) /100;

    
}

Console.Write("Третья цифра ", digit_third);
Console.WriteLine(digit_third);