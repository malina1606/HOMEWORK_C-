/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

int x,y,z;
double D;
int[] a = new int [3]; 
Console.WriteLine("Введите координаты точки А через пробел: ");
string strA = Console.ReadLine();
string [] coordA = strA.Split(' ');
int[] intsA = Array.ConvertAll(coordA, strA => int.Parse(strA));// преобразование массива одного типа(string) в массив другого типа (int)

Console.WriteLine("Введите координаты точки B через пробел: ");
string strB = Console.ReadLine();
string [] coordB = strB.Split(' ');
int[] intsB = Array.ConvertAll(coordB, strB => int.Parse(strB));


x = (intsB[0]-intsA[0])*(intsB[0]-intsA[0]);
y = (intsB[1]-intsA[1])*(intsB[1]-intsA[1]);
z = (intsB[2]-intsA[2])*(intsB[2]-intsA[2]);
D = Math.Sqrt(x+y+z);
Console.Write("D= ");
Console.WriteLine(D);
