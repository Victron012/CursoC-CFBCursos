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
    public int fat(int n){
        int res;
        if(n<1){
            res=1;
        }else{
            res=n*fat(n-1);
        }
        return res;
    }
}
class Aula48{
    static void Main(){
        Calc calc=new Calc();
        System.Console.WriteLine(calc.fat(5));
    }
}