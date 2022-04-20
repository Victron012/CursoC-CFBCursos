using System;

class Base{
    public Base(){
        System.Console.WriteLine("Construtor da classe Base");
    }

    virtual public void info(){
        System.Console.WriteLine("Base");
    }
}
class Derivada1:Base{
    public Derivada1(){
        System.Console.WriteLine("Construtor da classe Derivada 1");
    }
    override public void info(){
        System.Console.WriteLine("Derivada 1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        System.Console.WriteLine("Construtor da classe Derivada 2");
    }
    override public void info(){
        System.Console.WriteLine("Derivada 2");
    }
}
class Aula38{

    static void Main(){
        Base Ref;
        Derivada1 d1 = new Derivada1();
        Derivada2 d2 = new Derivada2();
        Ref=d2;
        Ref.info();
    }
}