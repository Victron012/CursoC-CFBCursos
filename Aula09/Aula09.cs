using System;

class Aula09{

    static void Main(){

        //bitwise para DIREITA:  >> divide o valor pela metade
        //bitwise para ESSQUEDA: << dobra o valor

        int num=10;
        num=num<<1;
        Console.WriteLine(num);

        num=10;
        num=num>>1;
        Console.WriteLine(num);

    }
}