using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;
    }
    public void info(){
        System.Console.WriteLine("Marca: "+ marca);
        System.Console.WriteLine("Modelo: "+ modelo);
        System.Console.WriteLine("Cor: "+ cor);
    }
}
class Aula44{
    static void Main(){
        Carro c1;
        Carro c2=new Carro("Honda","Civic","Preto");
        c1.marca="VW";
        c1.modelo="Golf";
        c1.cor="branco";

        c1.info(); 
        c2.info();  
    }
}