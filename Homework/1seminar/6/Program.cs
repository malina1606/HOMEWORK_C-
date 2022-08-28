double A=0;
string s;
Console.Write("Введите число A ");
s = Console.ReadLine();
A=Int32.Parse(s);

double  temp;
temp = A%2;

if (temp!=0)
   Console.WriteLine("A не делится на цело");
else 

   Console.WriteLine("A делится на цело");

