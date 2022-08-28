int A = 0;
int B = 0;
string sa;
string sb;
int max =0;
Console.Write("Введите число A ");
sa = Console.ReadLine();
A=Int32.Parse(sa);
Console.Write("Введите число B ");
sb = Console.ReadLine();
B=Int32.Parse(sb);

if (A > B)
    max = A;
    else
    max = B;

Console.Write("A= ");
Console.Write(A);
Console.Write("  ");
Console.Write("B= ");
Console.Write(B);
Console.Write("  ");
Console.Write("max = ");
Console.WriteLine(max);

