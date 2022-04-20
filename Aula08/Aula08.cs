using System;

class Aula08{

    static void Main(){
        int n1, n2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        soma = n1+n2;

        Console.WriteLine("{0}, a soma do valor digitado é: {1}", nome, soma);

    }


}