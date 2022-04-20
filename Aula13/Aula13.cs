using System;

 class Aula13{

     static void Main(){

         int n1, n2, n3, media=0;  
         
         Console.Write("Digite a primeira nota do aluno: ");
         n1 = int.Parse(Console.ReadLine());
         Console.Write("Digite a segunda nota do aluno: ");
         n2 = int.Parse(Console.ReadLine());
         Console.Write("Digite a terceira nota do aluno: ");
         n3 = int.Parse(Console.ReadLine());
         media = (n1+n2+n3)/3;

         if(media>=60){
             Console.WriteLine("Aluno APROVADO!\nMédia: {0}", media);
         } else if(media<40){
             Console.WriteLine("Aluno REPROVADO!\nMédia: {0}",media);
         } else{
             Console.WriteLine("Aluno de RECUPERAÇÃO!\nMédia: {0}",media);
         }
     }
 }