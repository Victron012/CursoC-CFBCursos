using System;

 class Aula18{

     static void Main(){
         int l=0;
         int c=0;
         int[,] n=new int[3,5];  /* 3 linhas e 5 colunas*/
         /*
         10 20 30 40 50
         60 70 80 90 15
         25 35 45 55 65
         */

         n[0,0]=10;
         n[0,1]=20;
         n[0,2]=30;
         n[0,3]=40;
         n[0,4]=50;

         n[1,0]=60;
         n[1,1]=70;
         n[1,2]=80;
         n[1,3]=90;
         n[1,4]=15;
         
         n[2,0]=25;
         n[2,1]=35;
         n[2,2]=45;
         n[2,3]=55;
         n[2,4]=65;
        
        for(int i=1;i<16;i++){
            if(c==5){
                l++;
                c=0;
            }
            Console.WriteLine("Número {1}: {0}", n[l,c], i);
            c++;
        }

     }
 }