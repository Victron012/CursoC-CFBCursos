using System;

class aula27{

    static void Main(){
        int n1, n2;
        System.Console.Write("Digite um número: ");
        n1 = int.Parse(Console.ReadLine());
        System.Console.Write("Digite um número: ");
        n2 = int.Parse(Console.ReadLine());
        soma(n1, n2);
    }

    static void soma(params int[]n){
        int res=0;

        if(n.Length<1){
            System.Console.WriteLine("Não existem valores a serem somados!");
        } else if(n.Length<2){
            System.Console.WriteLine("Valores insuficientes!");
        } else{
            for(int i=0; i<n.Length; i++){
                res+=n[i];
            }
            System.Console.WriteLine("A soma dos valores é: {0}", res);
        }
    }
}