using System;
using System.Globalization;
class Area{
    public static float Quad(float b, float h){
        if(b==0||h==0){
            throw new Exception("Base ou altura não podem ser zero!");  
        }
        return b*h;
    }
}
class Aula53{
    static void Main(){
       int n1, n2, res;
       float b, h, area=0;
       res=n1=n2=0;

       n1=10;
       n2=2;
       try{
        res=n1/n2;
        System.Console.WriteLine(res);
        throw new Exception("Erro forçado com o Throw");
       }
       catch(Exception e){
           System.Console.WriteLine("ERRO: "+e.Message);
           System.Console.WriteLine("Tipo: "+e.GetType());
       }finally{
           System.Console.WriteLine("Fim do Processo!");
       }
       System.Console.WriteLine("Você deseja calcular a area?");
       if(Console.ReadLine().ToUpper()=="S"){
           Console.Clear();
       }else{
           System.Console.WriteLine("Programa encerrado!");
           Environment.Exit(0);
       }
        try{
       System.Console.WriteLine("Digite a base do quadrado: ");
        b = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Digire a altura do quadrado: ");
        h = float.Parse(Console.ReadLine());
        area = Area.Quad(b,h);
        System.Console.WriteLine("Area do quadrado: "+area);
        }catch(Exception){
            throw new Exception("Os valores não podem estar vazios");
        }
    }
}