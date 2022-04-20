using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public void info(){
        System.Console.WriteLine("Marca: "+ marca);
        System.Console.WriteLine("Modelo: "+ modelo);
        System.Console.WriteLine("Cor: "+ cor);
        System.Console.WriteLine("------------------------");
    }
}
class Aula45{
    static void Main(){
        System.Console.WriteLine("Quantos carros quer cadastrar?");
        int qtd = int.Parse(Console.ReadLine());
        Carro[] carros = new Carro[qtd];
        for(int i=0; i<qtd; i++){
            System.Console.WriteLine("Qual a marca do {0}º carro?", i+1);
            carros[i].marca=Console.ReadLine();
            System.Console.WriteLine("Qual o modelo do carro?");
            carros[i].modelo=Console.ReadLine();
            System.Console.WriteLine("Qual a cor do carro?");
            carros[i].cor=Console.ReadLine();
        }
        for(int i=0; i<qtd; i++){
            carros[i].info(); 
        }
          
    }
}