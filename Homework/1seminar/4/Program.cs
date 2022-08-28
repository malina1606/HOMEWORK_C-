double A=0;
double B=0;
double C=0;
string sa;
string sb;
string sc;
double max=0;
Console.Write("Введите число A ");
sa = Console.ReadLine();
A=Int32.Parse(sa);
Console.Write("Введите число B ");
sb = Console.ReadLine();
B=Int32.Parse(sb);
Console.Write("Введите число C ");
sc = Console.ReadLine();
C=Int32.Parse(sc);



if (A > B && A > C)
    max = A;
    if (B > A && B > C)
    max=B;
        if (C > A && C > B)
        max = C;


Console.Write("A= ");
Console.Write(A);
Console.Write("  ");
Console.Write("B= ");
Console.Write(B);
Console.Write("  ");
Console.Write("C= ");
Console.Write(C);
Console.Write("  max = ");
Console.WriteLine(max);
