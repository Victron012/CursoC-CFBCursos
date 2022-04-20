using System;

class Base{
    public Base(){
        System.Console.WriteLine("Construtor da classe Base");
    }
}
class Derivada1:Base{
    public Derivada1(){
        System.Console.WriteLine("Construtor da classe Derivada 1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        System.Console.WriteLine("Construtor da classe Derivada 2");
    }
}
class Aula37{

    static void Main(){
        Derivada2 dev = new Derivada2();
    }
}