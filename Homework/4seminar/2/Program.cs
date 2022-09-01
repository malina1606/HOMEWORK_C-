/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. 
(для получения цифр числа операцию приведения числа к строке не использовать)*/

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int countDigits = 0;
int tmp1=A;
int tmp2=A;
int sum =0;
int index = 0;

while (tmp1 != 0) {
    countDigits++;
    tmp1 = tmp1 /10;
}
int [] array = new int [countDigits];
while (tmp2 != 0) {
    array[index] = tmp2 % 10;
    tmp2 /= 10;
    index++;
}

for(int i=0; i < countDigits; i++)
    if (A % array[i]==0) {
        sum+=array[i];
    }
Console.WriteLine("Сумма делителей равна " + sum);
