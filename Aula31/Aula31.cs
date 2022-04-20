using System;

static public class Jogador{
    static public int energia;
    static public bool vivo;
    static public string nome;
    
    static public void iniciar(string n){
        energia=100;
        vivo=true;
        nome=n;
    }
    static public void info(){
        System.Console.WriteLine("Nome jogador: {0}", nome);
        System.Console.WriteLine("Energia jogador: {0}", energia);
        System.Console.WriteLine("Estado jogador: {0}", vivo);
        System.Console.WriteLine();
        System.Console.WriteLine("---------------------------");
        System.Console.WriteLine();
    }

}

class Inimigo{
    static public bool alerta;
    public string nome;

    public Inimigo(string n){
        alerta=false;
        nome=n;
    }

    public void info(){
        System.Console.WriteLine(nome);
        System.Console.WriteLine(alerta);
        System.Console.WriteLine("----------------");
    }
}
class Aula31{

    static void Main(){

        Jogador.iniciar("Bruno");
        Jogador.info(); 

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta=true;

        i1.info();
        i2.info();
        i3.info();  
    }
}