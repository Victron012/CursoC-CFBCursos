using System;

 class Aula21{

     static void Main(){
          string senha="123";
          string senhaDigitada;
            do{
                Console.Clear();
                Console.WriteLine("Digite sua senha: ");
                senhaDigitada = Console.ReadLine();
            }while (senha!= senhaDigitada);
         
         Console.Clear();
         Console.WriteLine("Senha correta!");
     }
 }