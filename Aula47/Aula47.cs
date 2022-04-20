using System;
class Calc{
    public int soma(params int[]n){
        int r=0;
        for(int i=0; i<n.Length;i++){
           r+=n[i];
        }
        return r;
    }
    public double soma(params double[]n){
        double r=0;
        for(int i=0; i<n.Length;i++){
           r+=n[i];
        }
        return r;
    }
}
class Aula47{
    static void Main(){
        Calc calc=new Calc();
        System.Console.WriteLine(calc.soma(10.5,2,3,4,5,6,7,3,2,5));
    }
}