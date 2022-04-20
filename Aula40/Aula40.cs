using System;

sealed class Veiculo{ // uma classe sealed não pode ser herdada
    public void info(){
        System.Console.WriteLine("Uma classe sealed não pode ser usada com herança!");
    }
}

class Aula40{
    static void Main(){
        Veiculo veiculo=new Veiculo();
        veiculo.info();
    }
}