using System;
using System.Collections.Generic;
class Aula57{
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
        
        System.Console.WriteLine("Qual carro deseja ver a posição?");
        string nome; 
        do{
            nome = Console.ReadLine();
            if(carros.IndexOf(nome)<0){
                System.Console.WriteLine("O carro não está na lista! \nDigite novamente: ");
            }
        } while(carros.IndexOf(nome)<0);
        int pos = carros.IndexOf(nome);
        System.Console.WriteLine("O Carro {0} está na posição {1}", nome, pos);
    }
}