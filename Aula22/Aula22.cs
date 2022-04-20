using System;

    class aula22{

        static void Main(){
            
            int[] num = new int[3]{11,22,33};
        
        /*  for(int i=0;i<num.Length;i++){
                System.Console.WriteLine(num[i]);
            }*/
        
            foreach(int n in num){
                System.Console.WriteLine(n);
            }
        
        
        
        }
    }