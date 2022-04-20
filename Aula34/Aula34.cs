using System;

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
        string ligado;
        if(this.ligado==true){
            ligado="Sim";
        } else{
            ligado = "Não";
        }
        return ligado;
    }

    public void setRodas(int rodas){
        this.rodas=rodas;
    }
    public int getRodas(){
        return rodas;
    }
}

class Carro:Veiculo{ //classe derivada 
    private string nome;
    private string cor;
    public Carro(){
        desligar();
        setRodas(4);
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
class Aula34{

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

    }
}