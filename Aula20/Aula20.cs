using System;

 class Aula20{

     static void Main(){

         int[] num= new int[10];
         
         int i=0;
         Console.Write("Quantos número irá inserir? ");
         int x = int.Parse(Console.ReadLine());
         while (i<x)
         {
            Console.Write("Digite um número: ");
            num[i] = int.Parse(Console.ReadLine());
             i++;
         }
        i=0;
         while (i<x)
         {
            Console.WriteLine("O {0}º número digitado foi: {1}", i+1, num[i]);
            i++;
         }
     }
 }