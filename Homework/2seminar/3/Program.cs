double A=0;
string s;
Console.Write("Введите число соответствующее дню недели от 1 до 7: ");
s = Console.ReadLine();
A=Int32.Parse(s);
if (A > 7 || A < 1) {
    Console.WriteLine("Неверные данные");

}

if (A >= 1 && A <= 7) {
    if (A == 6 || A == 7){
      Console.WriteLine("УРА!!! ВЫХОДНЫЕ");  

    }
    else {
        Console.WriteLine("Улыбаемся и пашем!");
    }

}