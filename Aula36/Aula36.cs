using System;
using System.Globalization;

class Veiculo{// classe base
    public int velAtual;
    private int velMax;
    protected bool ligado;//permite acesso pelas classes derivadas

    public void setVelMax(int velMax){
        this.velMax=velMax;
    }
    public int getVelMax(){
        return velMax;
    }

    public void setLigado(bool ligado){
        this.ligado=ligado;
    }
    public string getLigado(){
        return(ligado?"Sim":"Não");
    }

    public Veiculo(){
        velAtual=0;
        velMax=100;
        ligado = false;
    }
}

class Carro:Veiculo{//derivada de veiculo
    public string nome;
    public Carro():base(){
        ligado = false;//protected porém é uma classe derivada
    }
}
class Aula36{
    static void Main(){
        Carro carro = new Carro();
        System.Console.WriteLine("Digite o nome do carro:");
        carro.nome = Console.ReadLine();
        System.Console.WriteLine("Digite sua velocidade máxima:");
        carro.setVelMax(int.Parse(Console.ReadLine()));
        Console.Clear();
        System.Console.WriteLine("Carro: "+carro.nome);
        System.Console.WriteLine("Ligado: "+ carro.getLigado());
        System.Console.WriteLine("Velocidade atual: "+ carro.velAtual);
        System.Console.WriteLine("Velocidade máxima: "+ carro.getVelMax());

        System.Console.WriteLine("\nDeseja ligar o carro?");
        if(Console.ReadLine().ToUpper()=="S"){
            carro.setLigado(true);
            Console.Clear();
            System.Console.WriteLine("Carro: "+carro.nome);
            System.Console.WriteLine("Ligado: "+ carro.getLigado());
            System.Console.WriteLine("Velocidade atual: "+ carro.velAtual);
            System.Console.WriteLine("Velocidade máxima: "+ carro.getVelMax());
        }else{
            Environment.Exit(0);
        }
        System.Console.WriteLine("Quer acelerar? ");
        while( Console.ReadLine().ToUpper()=="S")
        {
            int a=carro.getVelMax()/10;
         if(carro.getVelMax()<carro.velAtual+a){
             System.Console.WriteLine("Velocidade máxima já atingida");
             break;
         }else{
            carro.velAtual+=a;
            System.Console.WriteLine("Carro: "+ carro.nome);
            System.Console.WriteLine("Ligado: "+ carro.getLigado());
            System.Console.WriteLine("Velocidade atual: "+ carro.velAtual);
            System.Console.WriteLine("Velocidade máxima: "+ carro.getVelMax());
            System.Console.WriteLine("\nQuer acelerar? ");
         }
        }

         System.Console.WriteLine("Você deseja freiar o carro?");  
         while(Console.ReadLine().ToUpper()=="S")
        {
            int a=carro.getVelMax()/10;
         if(carro.velAtual-a<0){
             System.Console.WriteLine("O carro já está parado!");
             carro.setLigado(false);
             System.Console.WriteLine("Carro desligado!");
             Environment.Exit(0);
         }else{
            carro.velAtual-=a;
            System.Console.WriteLine("Carro: "+ carro.nome);
            System.Console.WriteLine("Ligado: "+ carro.getLigado());
            System.Console.WriteLine("Velocidade atual: "+ carro.velAtual);
            System.Console.WriteLine("Velocidade máxima: "+ carro.getVelMax());
            System.Console.WriteLine("\nQuer freiar? ");
         }
        }
        System.Console.WriteLine("Você bateu o carro!");
        
    }
}