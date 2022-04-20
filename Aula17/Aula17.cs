using System;

 class Aula17{

     static void Main(){
         int nota=0, media;
         int i =0;
 
         Console.WriteLine("Quntas provas o aluno teve?");
         int x = int.Parse(Console.ReadLine());
         int[] n=new int[x];
         
         while(i<x){
            Console.Write("Digite a nota do aluno:");
            n[i] = int.Parse(Console.ReadLine());
            nota = nota + n[i];
         i++;
         }

        media = nota/x;

        Console.WriteLine("A média final do aluno é: {0}", media);
         


     }
 }