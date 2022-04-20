using System;
class Carro{
    private int[] velMax=new int[5]{80,120,160,240,300};
    
    public int this[int i]{
        get{
            return velMax[i];
        }
        set{
            if(value<0){
                velMax[i]=0;
            }else if(value>300){
                velMax[i]=300;
            }else{
                velMax[i]=value;
            }
        }
    }

}
class Aula42{
    static void Main(){
        Carro carro=new Carro();
        
        System.Console.WriteLine("Quantos carros temos?");
        carro[4]=10;
        System.Console.WriteLine("Velocidade máxima: "+carro[4]);
    }
}