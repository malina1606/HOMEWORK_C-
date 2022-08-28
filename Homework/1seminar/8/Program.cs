double N=0;
int i=0;
string s;
Console.Write("Введите N= ");
s = Console.ReadLine();
N=Int32.Parse(s);
//Console.WriteLine (N); 

for (i=1; i<=N; i++) {
    if (i%2==0)
        Console.WriteLine (i); 
   
}