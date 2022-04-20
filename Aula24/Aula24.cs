using System;

    public class Aula24{

        static void Main(){
            System.Console.WriteLine("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número: ");
            int y = int.Parse(Console.ReadLine());
            int res = soma(x, y);
            System.Console.WriteLine("O resultado da soma é: "+ res);
        }

        static int soma(int n1, int n2){
            int res = n1+n2;
            return res;
        }
    }