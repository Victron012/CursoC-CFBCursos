using System;
using System.Collections.Generic;
class Aula58{
    static void Main(){
        List<string>carros = new List<string>();
        List<string>carros2 = new List<string>();
        int n=0;
        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        foreach(string s in carros){
            n++;
        }

        string[] carros3 = new string[n+2];

        carros2.AddRange(carros); // adiciona todos os itens de "carros" em "Carros2"

        carros2.Clear();

        foreach(string s in carros){
            System.Console.WriteLine("Carros: "+s);
        }

        System.Console.WriteLine("Qual carro deseja procurar?");
        if(carros2.Contains(Console.ReadLine())==true){
            System.Console.WriteLine("O carro está na lista");
        }else{
            System.Console.WriteLine("O carro não está na lista");
        }

        carros.CopyTo(carros3, 2);
        foreach(string s in carros3){
            System.Console.WriteLine("Carros 3: "+s);
        }
        
        System.Console.WriteLine("Digite o carro que deseja inserir");
        carros.Insert(2, Console.ReadLine()); // inserir um item em uma posição expessifica
        System.Console.WriteLine("Qual carro deseja ver a posição?");
        string nome; 
        do{
            nome = Console.ReadLine();
            if(carros.IndexOf(nome)<0){
                System.Console.WriteLine("O carro não está na lista! \nDigite novamente: ");
            }
        } while(carros.IndexOf(nome)<0);
        carros.Add(nome);
        int pos = carros.IndexOf(nome);// mostra a posicao na lista
        int pos2= carros.LastIndexOf(nome);// mostra a ultima posicao na lista
        System.Console.WriteLine("O Carro {0} está na posição {1}", nome, pos);
        System.Console.WriteLine("O último {0} está na posição {1}\n", nome, pos2);

        foreach(string s in carros){
            System.Console.WriteLine("Carro: "+ s);
        }
        System.Console.WriteLine("Qual carro deseja remover?");
        do{
            nome = Console.ReadLine();
            if(carros.Contains(nome)!=true){
                System.Console.WriteLine("Carro não encontrado! \nDigite novamente:");
            }
        }while (carros.Contains(nome)!=true);
        carros.Remove(nome);
        carros.RemoveAt(0);// remove o elemento da posicao informada
        Console.Clear();
        System.Console.WriteLine("Carro removido com sucesso! ");
        
        foreach(string s in carros){
            System.Console.WriteLine("Carro: "+ s);
        }
    	
        System.Console.WriteLine("------------------");
        System.Console.WriteLine("O que você deseja fazer? \nInverter a ordem da lista - A \nOrganizar a lista - B");
        switch (Console.ReadLine().ToUpper()){
            case "A": carros.Reverse(); break;
            case "B":
                carros.Sort(); break; 
            default:
                Console.WriteLine("A opção inserida não é válida! Nenhuma mudança foi realizada");
                break;
        }        
        System.Console.WriteLine("");           
        foreach(string s in carros){
            System.Console.WriteLine("Carro: "+ s);
        }

        System.Console.WriteLine("A lista agora tem {0} veiculos", carros.Count);
        System.Console.WriteLine("A capacidade da lista é: "+ carros.Capacity);

        System.Console.WriteLine("Você deseja alterar a capacidade da lista?");
        do{
            nome=Console.ReadLine().ToUpper();
            if(nome=="S"){
                System.Console.WriteLine("Digite a nova capacidade da lista: ");
                int c = int.Parse(Console.ReadLine());
                if(c-1 < carros.Count){
                    System.Console.WriteLine("Capacidade abaixo do número de itens já existentes");
                    nome = "N";
                }else{ 
                    carros.Capacity = c;
                    System.Console.WriteLine("A nova capacidade da lista é: "+ carros.Capacity);
                }
            }else if(nome=="N"){
                System.Console.WriteLine("Programa encerrado");
            }
        }while(nome!="S"||nome!="N");
    }
}