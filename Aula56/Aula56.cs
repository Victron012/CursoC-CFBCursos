using System;
using System.Collections.Generic;
class Aula56{
    static void Main(){
        LinkedList<string> transportes =  new LinkedList<string>();
        string rem, add;

        transportes.AddFirst("Carro");
        transportes.AddFirst("Avião");
        transportes.AddFirst("Navio");
        transportes.AddFirst("Moto");

        transportes.AddLast("Bicicleta");

        LinkedListNode<string>no;
        no=transportes.FindLast("Navio");
        System.Console.WriteLine("Qual transporte deseja adicionar? ");
        do{
            add = Console.ReadLine();    
            if(transportes.Find(add)!=null){
                System.Console.WriteLine("O elemento já existe! \nDigite novamente:");
            }   
        }while(transportes.Find(add)!=null);
        transportes.AddAfter(no,add);

        no=transportes.FindLast("Carro");
        System.Console.WriteLine("Qual transporte deseja adicionar? ");       
        do{
            add = Console.ReadLine();    
            if(transportes.Find(add)!=null){
                System.Console.WriteLine("O elemento já existe! \nDigite novamente:");
            }   
        }while(transportes.Find(add)!=null);
        transportes.AddBefore(no,add);

        //transportes.Clear();
        //transportes.RemoveFirst();
        //transportes.RemoveLast();
        
        System.Console.WriteLine("\nQual elemento deseja procurar?");
        if(transportes.Find(Console.ReadLine())==null){
            System.Console.WriteLine("Elemento não encontrado \n");
        }else{
            System.Console.WriteLine("Elemento encontrado");
        }
        System.Console.WriteLine("Qual elemento deseja remover?");
        foreach(string t in transportes){
            System.Console.WriteLine("Transportes: "+t);
        }
        do{
            rem = Console.ReadLine();
            if(transportes.Find(rem)==null){
                System.Console.WriteLine("Elemento não econtrado! \nDigite novamente:");
            }
        }
        while (transportes.Find(rem)==null);
            transportes.Remove(rem);
        foreach(string t in transportes){
            System.Console.WriteLine("Transportes: "+t);
        }
    }
}