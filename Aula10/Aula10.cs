using System;

class Aula10{

    enum diasSemana{s,Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};
    static void Main(){

        Console.WriteLine("Digite o dia da Semana:");
        int dia = int.Parse(Console.ReadLine());
        while(dia==0|dia>8){
            Console.WriteLine("Dia da semana Inválido!!\n Digite novamente: ");
            dia = int.Parse(Console.ReadLine());
        }
         diasSemana ds = (diasSemana)dia;

         Console.WriteLine(ds);

    }
}   