using System;
using System.Collections.Generic;
using System.Globalization;
class Aula55{
    static void Main(){
        Dictionary <int, string> veiculos = new Dictionary <int, string>();
        
        veiculos.Add(10, "Carro");
        veiculos.Add(5,"Aviao");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");

        System.Console.WriteLine("Tamanho do Dictionary: "+ veiculos.Count);
        /*veiculos.Clear();// limpa o dictionary
        System.Console.WriteLine("Limpando...");
        System.Console.WriteLine("Tamanho do Dictionary: "+ veiculos.Count);*/
        System.Console.WriteLine("Qual chave deseja procurar?");
        int chave=int.Parse(Console.ReadLine());
        if(veiculos.ContainsKey(chave)){
            System.Console.WriteLine("A chave {0} está na coleção e tem o valor {1}. \n", chave, veiculos[chave]);
        }else{
            System.Console.WriteLine("A chave {0} não está na coleção. \n", chave);
        }

        System.Console.WriteLine("Qual valor deseja procurar?");
        string valor=Console.ReadLine();
        if(veiculos.ContainsValue(valor)){
            System.Console.WriteLine("O valor {0} está na coleção. \n", valor);
        }else{
            System.Console.WriteLine("O valor {0} não está na coleção. \n", valor);
        }

        System.Console.WriteLine("Qual valor deseja remover?");
        foreach(KeyValuePair<int,string> s in veiculos){
            System.Console.WriteLine("{0} - {1}", s.Key, s.Value);
        }
        int rem=int.Parse(Console.ReadLine());
        if(veiculos.ContainsKey(rem)){
            System.Console.WriteLine("Valor {0} removido. \n", veiculos[rem]);
            veiculos.Remove(rem);
        }else{
            System.Console.WriteLine("A chave {0} não está na coleção. \n", rem );
        }

        veiculos[15] = "Bicicleta";
        valor = "Bicicleta";
        if(veiculos.ContainsValue(valor)){
            System.Console.WriteLine("O valor {0} está na coleção. \n", valor);
        }else{
            System.Console.WriteLine("O valor {0} não está na coleção. \n", valor);
        }

        System.Console.WriteLine("Qual veiculo deseja alterar?");
        foreach(KeyValuePair<int,string> s in veiculos){
            System.Console.WriteLine("{0} - {1}", s.Key, s.Value);
        }

        do{
            chave = int.Parse(Console.ReadLine());
            if(veiculos.ContainsKey(chave)==false){
                System.Console.WriteLine("Chave não encontrada! \nDigite novamente!");
            }
        }while(veiculos.ContainsKey(chave)==false);
        
        System.Console.WriteLine("Digite o novo valor da chave {0}", chave);
        veiculos[chave] = valor =  Console.ReadLine();
        if(veiculos.ContainsValue(valor)){
            System.Console.WriteLine("O valor {0} agora está na chave {1}. \n", valor, chave);
        }else{
            System.Console.WriteLine("O valor {0} não está na coleção. \n", valor);
        }

        Dictionary<int, string>.ValueCollection valores=veiculos.Values;
        foreach(string v in valores){
            System.Console.WriteLine(v);
        }
    }
}