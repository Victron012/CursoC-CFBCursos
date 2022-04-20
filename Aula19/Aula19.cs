using System;

 class Aula19{

     static void Main(){
        
        Console.Write("Quantos números deseja inseir?");
        int x = int.Parse(Console.ReadLine());
        int[] num=new int[x--];
        
         for(int i=0;i<num.Length;i++){
                Console.Write("Escolha o {0}º número: ", i+1);
                num[i] = int.Parse(Console.ReadLine()); 
         }
         
          for(int i=0;i<num.Length;i++){
                Console.WriteLine("O {0}º número é: {1}", i+1, num[i]);  

         }
     }
 }