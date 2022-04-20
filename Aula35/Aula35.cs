using System;
using System.Globalization;

class Veiculo{ //classe base

    private int rodas;
    public int velMax;
    private bool ligado;
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }

    public string getLigado(){
       return(ligado?"Sim":"Não");//condicional ternário
        /*string ligado;
        if(this.ligado==true){
            ligado="Sim";
        } else{
            ligado = "Não";
        }
        return ligado;*/
    }

    public Veiculo(int rodas){
        this.rodas=rodas;
    }
    public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas=0;
        } else if(rodas>40){
            this.rodas=40;
        }else{
            this.rodas=rodas; 
        }   
    }
}

class Carro:Veiculo{ //classe derivada 
    private string nome;
    private string cor;
    public Carro():base(4){
        desligar();
        velMax = 120;
    }

    public void setNome(string nome){
        this.nome = nome;
    }
    public string getNome(){
        return nome;
    }

    public void setCor(string cor){
        this.cor = cor;
    }
    public string getCor(){
        return cor;
    }
}

class CarroCombate:Carro{
    public int municao;
    public CarroCombate():base(){
        municao=5;
    }
}
class Aula35{

    static void Main(){
        Carro c1 = new Carro();

        System.Console.WriteLine("Qual é o seu carro?");
        c1.setNome(Console.ReadLine());
        System.Console.WriteLine("Qual a cor do seu carro?");
        c1.setCor(Console.ReadLine());

        System.Console.WriteLine("Nome: "+ c1.getNome());
        System.Console.WriteLine("Cor: "+ c1.getCor());
        System.Console.WriteLine("Rodas: "+ c1.getRodas());
        System.Console.WriteLine("Velocidade Max.: "+ c1.velMax);
        System.Console.WriteLine("Ligado: "+ c1.getLigado());

        System.Console.WriteLine("Deseja montar um carro de combate? ");
        if(Console.ReadLine().ToUpper()!="S"){
            System.Console.WriteLine("Programa encerrado!");
            Environment.Exit(0);
        }else{
            Console.Clear();
        }

        Random rand = new Random(); 
        CarroCombate c2 = new CarroCombate();
        System.Console.WriteLine("Escolha a quantidade de rodas do veiculo:");
        c2.setRodas(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Você quer atirar? ");
        while(Console.ReadLine().ToUpper()=="S"){
            if(c2.municao==0){
                System.Console.WriteLine("Você está sem balas! Deseja Recarregar?");
                if(Console.ReadLine().ToUpper()=="S"){
                    c2.municao=5;
                    System.Console.WriteLine("+ 5 Balas!\n");
                }else{
                    System.Console.WriteLine("Programa encerrado!");
                    Environment.Exit(0);
                }
            }
            System.Console.WriteLine("Você deu um tiro");
            int i = rand.Next(10);
            System.Console.WriteLine("Número: "+i);
            if(i==5){
                System.Console.WriteLine("Parabéns!! Você matou o inimigo");
                Environment.Exit(0);
            }
            c2.municao--;
            System.Console.WriteLine("Você tem {0} balas, deseja dar outro tiro?", c2.municao);
        }
        System.Console.WriteLine("Programa encerrado!");

    }
}