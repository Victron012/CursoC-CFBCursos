using System;
class Aula52{
    static void Main(){
       int n1, n2, res;
       res=n1=n2=0;

       n1=10;
       n2=0;
       try{
        res=n1/n2;
        System.Console.WriteLine(res);
       }
       catch(Exception e){
           System.Console.WriteLine("ERRO: "+e.Message);
       } 
    }
}