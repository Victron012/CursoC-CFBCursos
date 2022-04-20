using System;

public class Jogador{
    public int eneria;
    public bool vivo;
    public string nome;
    public Jogador(string n){
        eneria=100;
        vivo=true;
        nome=n;
    }
    
    ~Jogador(){
        System.Console.WriteLine("Jogador {0} foi destruido!", nome);
    }

}
class Aula29{

    static void Main(){

        string nome;
        System.Console.Write("Digite o nome do Jogador 1: ");
        nome = Console.ReadLine();
        Jogador j1 = new Jogador(nome);
        Jogador j2 = new Jogador("Theo");
        System.Console.WriteLine("O nome do jogado 1 é: {0}", j1.nome);
        System.Console.WriteLine("O nome do jogado 2 é: {0}", j2.nome);

        
        
    }
}