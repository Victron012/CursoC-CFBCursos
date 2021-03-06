using System;

    public class Aula23{

        static void Main(){
            int[] vetor1=new int[5];
            int[] vetor2=new int[5];
            int[] vetor3=new int[5];
            int[,] matriz= new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

            Random random=new Random();
            for(int i=0;i<vetor1.Length;i++){
                vetor1[i]=random.Next(50);
            }

            System.Console.WriteLine("Elementos do vetor1: ");
            foreach(int n in vetor1){
                System.Console.WriteLine(n);
            }

            //public static int BinarySearch(array,valor);
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("BinarySearch");
            System.Console.Write("Qual valor deseja procurar?");
            int procurado = int.Parse(Console.ReadLine());
            int pos=Array.BinarySearch(vetor1,procurado);
            if(pos<0){
                System.Console.WriteLine("Valor não encontrado!");    
            } else{
                System.Console.WriteLine("Valor {0} está na posição: {1}", procurado,pos);
                }
            System.Console.WriteLine("-----------------------");
     
            //public static void Copy(Ar_origem,Ar_destino,qtde_elementos)
            System.Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach(int n in vetor2){
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("-----------------------");

            //public static void CopyTo(Ar_destino,a_partir_desta_pos)
            System.Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3,0);
            foreach(int n in vetor3){
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("-----------------------");
        
            //public long GetLongLenght(dimensão);
            System.Console.WriteLine("GetLongLenght");
            long qtdeElementosVetor=vetor1.GetLongLength(0);
            System.Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
            System.Console.WriteLine("-----------------------");

            //public int GetLowerBound(dimensão);
            System.Console.WriteLine("GetLowerBound");
            int MenorIndiceVetor=vetor1.GetLowerBound(0);
            int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
            System.Console.WriteLine("Menor índice do vetor1: {0}", MenorIndiceVetor);
            System.Console.WriteLine("-----------------------");

            //public int GetUpperBound(dimensão);
            System.Console.WriteLine("GetUpperBound");
            int MaiorIndiceVetor=vetor1.GetUpperBound(0);
            int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
            System.Console.WriteLine("Maior índice do vetor1: {0}", MaiorIndiceVetor);
            System.Console.WriteLine("-----------------------");

            //public object GetValue(long indice);
            System.Console.WriteLine("GetValue");
            int valor0=Convert.ToInt32(vetor1.GetValue(3));
            int valor1=Convert.ToInt32(matriz.GetValue(1,3));
            System.Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
            System.Console.WriteLine("-----------------------");

            //public static int IndexOf(array, valor);
            System.Console.WriteLine("IndexOf");
            int indice1=Array.IndexOf(vetor1,3);
            System.Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
            System.Console.WriteLine("-----------------------");

            //public static int LastInexOf(array, valor);
            System.Console.WriteLine("lastIndexOf");
            int indice2=Array.LastIndexOf(vetor1,3);
            System.Console.WriteLine("Indice do último valor 33: {0}", indice2);
            System.Console.WriteLine("-----------------------");

            //public static void Reverse(aray);
            Array.Reverse(vetor1);
            foreach(int n in vetor1){
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("-----------------------");

            //public void SetValue(object valor, long pos);
            vetor2.SetValue(99,0);
            for(int i=0;i<vetor2.Length;i++){
                vetor2.SetValue(0,i);
            }
            System.Console.WriteLine("Vetor 2");
            foreach(int n in vetor2){
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("-----------------------");

            //public statics void Sort(array)'
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Array.Reverse(vetor3);
            System.Console.WriteLine("Vetor 1");
            foreach(int n in vetor1){
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("-----------------------");
            foreach(int n in vetor2){
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("-----------------------");
            foreach(int n in vetor3){
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("-----------------------");
        }
    }