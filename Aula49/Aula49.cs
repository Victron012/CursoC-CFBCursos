using System;
class Mat{
    public static double pi=3.14;

    public static int dobro(int n){ // membros static não precisam declarar objetos
        return n*2; 
    }
}
class Aula49{
    static void Main(){
        double vpi = Mat.pi;
        System.Console.WriteLine(Mat.dobro(14));
        System.Console.WriteLine("pi= "+vpi);
    }
}