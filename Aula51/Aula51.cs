using System;
class Aula51{
    static void Main(string[] args){
        int res=0;
        if(args.Length>0){
            System.Console.WriteLine("Foram passados {0} argumentos", args.Length);
            for(int i=0; i<args.Length; i++){
                System.Console.WriteLine("{0}º argumento: {1}", i+1, args[i]);
                res+=int.Parse(args[i]);
            }
            System.Console.WriteLine("Valor total: "+res);
        }else{
            System.Console.WriteLine("Não foram passados argumentos");
        }
    }
}