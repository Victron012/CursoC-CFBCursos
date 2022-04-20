using System;

class Aula06{

    static void Main(){
        
        double valCompra=5.5;
        double valVenda=0;
        double lucro=0.1;
        string produto="Pastel";

        valVenda = valCompra+(valCompra*lucro);

        Console.WriteLine("Produto: {0,15}", produto);
        Console.WriteLine("Valor de compra: {0:c}", valCompra);
        Console.WriteLine("Lucro: {0,15:p}", lucro);
        Console.WriteLine("Valor de venda: {0:c}", valVenda);
    }
}