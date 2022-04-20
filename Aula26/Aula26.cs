 using System;

 public class Aula26{

     static void Main(){
         int x, y, res, resto;
         System.Console.Write("Digite um número: ");
         x = int.Parse(Console.ReadLine());
         System.Console.Write("Digite o número para divisão: ");
         y = int.Parse(Console.ReadLine());
         res = divide(x,y, out resto);
         Console.WriteLine("{0}/{1} = {2} e resto= {3}",x, y ,res, resto);
     }

     static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo/divisor;
        resto=dividendo%divisor;
         return quociente;
     }
 }