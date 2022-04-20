using System;
abstract class Veiculo{ //Classe Base /Não é possível criar uma instância de classe abstrata                       
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado=false;
        velAtual=0;
    }
    public void setLigado(bool ligado){
        this.ligado=ligado;
    }
    public void showVelAtual(){
            System.Console.WriteLine("Velocidade atual: "+velAtual);
        }

    abstract public void aceleracao(int acel);
}
    class Carro:Veiculo{
        public Carro(){
            velMax=120;
        }
        override public void aceleracao(int acel){
            velAtual+=10*acel;
        }
    }

class Aula39{
    static void Main(){   
        Carro carro = new Carro();
        System.Console.WriteLine("Qual a aceleração do carro?");
        carro.aceleracao(int.Parse(Console.ReadLine()));
        carro.showVelAtual();
    }
}