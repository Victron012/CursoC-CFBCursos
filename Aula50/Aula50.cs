using System;

delegate int Op(int n1, int n2);
class Mat{
    public static int soma(int n1, int n2){
        return n1+n2;
    }
    public static int mult(int n1, int n2){
        return n1*n2;
    }
}
class Aula50{
    static void Main(){
        
        int res;

        Op d1 = new Op(Mat.soma);
        System.Console.WriteLine("Digite os números para somar: ");
        res = d1(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Soma: "+res);

        d1 = new Op(Mat.mult);
        System.Console.WriteLine("Digite os números para multiplicar: ");
        res = d1(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Multiplicação: "+res);
    }
}