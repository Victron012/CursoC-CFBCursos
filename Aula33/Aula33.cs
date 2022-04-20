using System;

class Jogador{

    private int energia;
    private string nome;

    public Jogador(){

    }
    public Jogador(string nome, int energia){
        this.nome=nome;
        this.energia=energia;
    }

    public string getNome(){
        return nome;
    }
    public void setNome(string nome){
        this.nome=nome;
    }

    public int getEnergia(){
        return energia;
    }
    public void setEnergia(int energia){

        while (energia<0||energia>100)
        {
             System.Console.WriteLine("Valor incorreto! Tente novamente...");
             System.Console.Write("Energia: ");
             energia = int.Parse(Console.ReadLine());
        }
        this.energia = energia;
    }
}
class Aula33{
    static void Main(){
        Jogador j1 = new Jogador("Marcos", 58);
        Jogador j2 = new Jogador();

        System.Console.WriteLine("Nome: "+ j1.getNome());
        System.Console.WriteLine("Energia: "+ j1.getEnergia());

        System.Console.WriteLine("Digite o nome do Jogador 2: ");
        j2.setNome(Console.ReadLine());
        System.Console.WriteLine("Qual a energia desse jogador? ");
        j2.setEnergia(int.Parse(Console.ReadLine()));

        System.Console.WriteLine("Nome: "+ j2.getNome());
        System.Console.WriteLine("Energia: "+ j2.getEnergia()); 
    }
}