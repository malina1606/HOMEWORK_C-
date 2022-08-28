int start = 1;
int stop = 1000000;
int value = new Random().Next(start,stop+1);
Console.Write("Случайное число ", value);
Console.WriteLine(value); 
//int value = 1288;
//int value = 161;
if ((value % 7 == 0) && (value % 23 == 0)) {
    Console.Write("Данное число кратно 7 и 23");

} else {
    Console.Write("Данное число не кратно 7 и 23");
}