using System;

public class Jogador{
    public int eneria=100;
    public bool vivo=true;

}
class Aula28{

    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        System.Console.WriteLine("Qual a energia do jogador 1?");
        j1.eneria = int.Parse(Console.ReadLine);
        System.Console.WriteLine("Energia do jogador 1: {0}", j1.eneria);
    }
}