using System;
class Galinha{
    static int totalOvos;
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha=nomeGalinha;
        numOvo=0;
    }
    public Ovo botar(){
        numOvo++;
        totalOvos++;
        return new Ovo(nomeGalinha, numOvo, totalOvos);      
    }
}
class Ovo{
    public Ovo(string nomeGalinha, int numOvo, int totalOvos){
        System.Console.WriteLine("{0} botou um Ovo!", nomeGalinha);
        if(numOvo>1){
            System.Console.WriteLine("Ela agora tem {0} ovos!", numOvo);
        }else{
            System.Console.WriteLine("Ela agora tem {0} ovo!", numOvo);
        }
        if(totalOvos>1){
            System.Console.WriteLine("Temos ao todo: {0} ovos", totalOvos);
        }else{
            System.Console.WriteLine("Temos ao todo: {0} ovo", totalOvos);
        }
        System.Console.WriteLine("--------------------------");
    }
}
class Aula46{
    static void Main(){
        System.Console.WriteLine("Qual o nome da sua galinha?");
        Galinha g1=new Galinha(Console.ReadLine());
        System.Console.WriteLine("Qual o nome da sua galinha?");
        Galinha g2=new Galinha(Console.ReadLine());
        System.Console.WriteLine("Qual o nome da sua galinha?");
        Galinha g3=new Galinha(Console.ReadLine());

        g1.botar();

        g2.botar();
        g2.botar();

        g3.botar();
        g3.botar();
        g3.botar();
    }
}