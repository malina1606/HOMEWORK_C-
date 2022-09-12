/*Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. 
(Каждый эл-т массива должен быть сгенерирован случайно)*/

int start = 1;
int stop = 100000;
Console.WriteLine("Введите N ");
int N = Convert.ToInt32(Console.ReadLine());
//int value = new Random().Next(start,stop);
int value=22;
int tmp1=value;
int tmp2=value;
int count =0;
int index = 0;
int sum =0;
int proizv = 1;
Console.WriteLine("Случайное число " +  value);


while (tmp1 != 0) {
    count++;
    tmp1 = tmp1 /10;
}
Console.WriteLine("Количество разрядов "+ count);
int [] digits = new int [count];
while (tmp2 != 0) {
    digits[index] = tmp2 % 10;
    tmp2 /= 10;
    index++;
}

for(int i=0; i < count; i++)
Console.WriteLine(" "+ digits[i]);

//int j=0;
for(int j=0; j < count; j++){
    sum += digits[j];
    proizv *= digits[j];
}
Console.WriteLine("Сумма " + sum);
Console.WriteLine("Произведение " +proizv);

int [] arr = new int [N];
for (int i=0; i<N; i++)
if ((proizv % sum ==0) && (sum !=0)) {
    arr[i] = value;
}
for(int i=0; i < count; i++)
Console.WriteLine(" "+ arr[i]);