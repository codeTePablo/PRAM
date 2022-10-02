using System;

namespace OrdenamientoEREW{
    public class Program{

        static int[] L = {16, 22, 35, 40, 53, 66, 70, 85, 15, 18, 23, 55, 60, 69, 72, 78};
        static int a = 16;
        
        public void MergeSortPRAM(int[] L, int n){
            if(n >= 2){
                int m = (int)n/2;
                int[] B = {m};
                for(int i = 0; i < m; i++){
                    B[i] = L[2 * i];
                }

                for(int i = 0; i < m; i++){
                    Console.WriteLine(B[i]);
                }
            }
        }
        public void Main(string[] args){
            for(int i = 0; i < a; i++){
                Console.WriteLine(L[i]);
            }
            MergeSortPRAM(L, a);
        }
    }
}