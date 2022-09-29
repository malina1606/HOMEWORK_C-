Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int[N, N];
    for (int i = 0; i < N; i++){
        for (int j = 0; j < N; j++){
            arr[i, j] = 0;
        }    
    }

for (int ik = 0; ik < N; ik++){     
    for (int jk = 0; jk < N; jk++){
        int i = ik + 1;     
        int j = jk + 1;     
        int switcher =  (j - i + N) / N;
        int Ic = Math.Abs(i - N / 2  - 1) + (i - 1)/(N /2) * ((N-1) % 2);
        int Jc = Math.Abs(j - N / 2  - 1) + (j - 1)/(N /2) * ((N-1) % 2);
        int Ring = N / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
        int Xs = i - Ring + (j - Ring) - 1;    
        int Coef =  4 * Ring * (N - Ring);
        arr[ik,jk] =  Coef + switcher * Xs + Math.Abs(switcher - 1) * (4 * (N - 2 * Ring) - 2 - Xs);  
    }   
}     
for (int k = 0; k < N; k++){
    for (int l = 0; l < N; l++){
        Console.Write(" " + arr[k, l]);
    }
    Console.WriteLine();
}