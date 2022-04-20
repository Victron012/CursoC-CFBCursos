using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    
    public Jogador(){
        energia=100;
        vivo=true;
        nome="Jogador";
    }
    public Jogador(string n){
        energia=100;
        vivo=true;
        nome=n;
    }

    public Jogador(string n, int e){
        energia=e;
        vivo=true;
        nome=n;
    }
    
    public Jogador(string n, int e, bool v){
        energia=e;
        vivo=v;
        nome=n;
    }

    public void info(){
        System.Console.WriteLine("Nome jogador: {0}", nome);
        System.Console.WriteLine("Energia jogador: {0}", energia);
        System.Console.WriteLine("Estado jogador: {0}", vivo);
        System.Console.WriteLine();
        System.Console.WriteLine("---------------------------");
        System.Console.WriteLine();
    }

}
class Aula30{

    static void Main(){

        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Theo");
        Jogador j3 = new Jogador("Bruno", 100);
        Jogador j4 = new Jogador("Arthur", 30, true);
        Jogador j5 = new Jogador("Bart", 0, false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
        j5.info();    
    }
}