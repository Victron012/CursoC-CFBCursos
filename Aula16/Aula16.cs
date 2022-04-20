using System;

 class Aula16{

     static void Main(){

         int tempo=0;
         
         inicio:

        Console.Clear();
         Console.WriteLine("Viagem: Belo Horizonte --> Vitória/Es");
         Console.WriteLine("Escolha um meio de tranporte: [a]Avião |[c]Carro|[o]Ônibus");
         char transporte = char.Parse(Console.ReadLine());
         switch(transporte){
             case 'a': tempo=50;
                break;
             case 'c': tempo=480; 
                break;
             case 'o': tempo=600;
                break;   
            default: tempo=-1;
                break;
         }

         if(tempo<0){   
            Console.WriteLine("Transporte indisponível");
         } else{
             Console.WriteLine("O tempo da viagem é de {0} minutos", tempo);
         }
        
        Console.WriteLine("Escolher outro transporte? [S][N]");
        transporte = char.Parse(Console.ReadLine());
         if(transporte=='S'||transporte=='s'){
            goto inicio;
         } else {
             Console.Write("Programa finalizado!");
         }
     }
 }