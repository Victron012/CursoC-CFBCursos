using System;
public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}
public interface Combate{
    void disparar();
}
class Carro:Veiculo, Combate{
    private bool ligado;
    private int municao;
    public Carro(){
        setMunicao(100);
    }
    public void setMunicao(int i){
        this.municao=i;
    }
    public void ligar(){
        this.ligado=true;
    }
    public void desligar(){
        this.ligado=false;
    }
    public void info(){
        System.Console.WriteLine("Usando método da interface");
    }
    public void disparar(){
        setMunicao(-1);
    }
}
class Aula43{
    static void Main(){
        Carro c1=new Carro();
    }
}