using System;
using System.Collections.Generic;
class Aula59{
    static void Main(){
        //string[] v={"Carro", "Moto", "Navio", "Avião"}; caso queira iniciar a fila com dados pré existentes
        Queue<string> veiculos = new Queue<string>();   
        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        System.Console.WriteLine("Tamanho fila: "+ veiculos.Count);

        System.Console.WriteLine("Qual veiculo deseja procurar?");
        string n = Console.ReadLine();
        if(veiculos.Contains(n)){
            System.Console.WriteLine("{0} existe na fila\n", n);
        }else{
            System.Console.WriteLine("{0} não existe na fila\n", n);
        }

        foreach(string s in veiculos){
            System.Console.WriteLine("Veiculo: " + s);
        }

        System.Console.WriteLine("Deseja limpar a fila? ");
        if(Console.ReadLine().ToUpper()=="S"){
            veiculos.Clear();
            System.Console.WriteLine("Fila limpa com sucesso!\n");
            foreach(string s in veiculos){
                System.Console.WriteLine("Veiculo: " + s);
            }
        }else{
            System.Console.WriteLine("Nenhuma alteração foi feita");
        }

        System.Console.WriteLine("Deseja chamar o próximo veiculo da fila?");
        do{
            n = Console.ReadLine().ToUpper();
            if(n=="S"){
                try{
                    System.Console.WriteLine("Primeiro veiculo da fila: "+ veiculos.Dequeue());
                    System.Console.WriteLine("Deseja chamar o próximo veiculo da fila?");
                }catch(Exception){
                    n="i";
                }
                if(n=="i"){
                    System.Console.WriteLine("A fila está vazia");
                }
            }
        }while(n=="S");

        System.Console.WriteLine("Primeiro veiculo da fila: "+ veiculos.Peek());//somente mostra o primeiro item da fila
        System.Console.WriteLine("Tamanho fila: "+ veiculos.Count);
    }
}