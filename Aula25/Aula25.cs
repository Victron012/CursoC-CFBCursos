 using System;

 public class Aula25{

     static void Main(){
         System.Console.Write("Digite um número: ");
         int num = int.Parse(Console.ReadLine());
         dobrar(ref num);
         Console.WriteLine(num);
         
     }

     static void dobrar(ref int valor){
         valor*=2;
     }

     static void dobrar2(int valor){
         valor*=2;
     }
 }