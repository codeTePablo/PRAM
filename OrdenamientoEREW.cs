using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OrdenamientoEREW{
    public class Program{

        static int[] L = {16, 22, 35, 40, 53, 66, 70, 85, 15, 18, 23, 55, 60, 69, 72, 78};
        static int a = 16;

    public void oddEvenMerge(int[] L, int n)
{
    if (n == 2)
    {
        if (L[0] > L[1])
        {
            change(L, 0, 1);
        }
    }
    else
    {
        int m = (int)n / 2;
        int odd = m;
        int[] even = new int[m];

        oddEvenSplit(L, odd, even, n);
        {
            // oddEvenMerge(odd, m);
            oddEvenMerge(even, m);
        }

        for (int i = 0; i < (int)n / 2; i++)
        {
            // L[2 * i] = odd[i];
            L[2 * i + 1] = even[i];
        }

        for (int i = 0; i < n - 1; i++)
        {

            if ((L[i]) > (L[i + 1]))
            {
                change(L, i, i + 1);
            }
        }
    }
}

        public int[] MergeSort(int[] L)
        {
            int Flag = 0;
            int temp = 0;
            while (Flag == 0)
            {
                Flag = 1;
                for (int i = 0; i < L.Length - 1; i += 2)
                {
                    if (L[i] > L[i + 1])
                    {
                        temp = L[i];
                        L[i] = L[i + 1];
                        L[i + 1] = temp;
                        Flag = 0;
                    }
                }
                for (int i = 1; i < L.Length - 1; i += 2)
                {
                    if (L[i] > L[i + 1])
                    {
                        temp = L[i];
                        L[i] = L[i + 1];
                        L[i + 1] = temp;
                        Flag = 0;
                    }
                }  
            }
            return L;
        }
        
        public void MergeSortPRAM(int[] L, int n){
            if(n >= 2){
                int m = (int)n/2;
                int[] B = {m};
                for(int i = 0; i < m; i++){
                    B[i] = L[2 * i];
                }

                // for(int i = 0; i < m; i++){
                //     Console.WriteLine(B[i]);
                // }

                int[] C = {m};
                for(int i = 0; i < m; i++){
                    B[i - m] = L[2 * (i -m) + 1];
                }
            }
        }

        public void change(int[] L, int a, int b)
        {
            int aux;
            aux = L[a];
            L[a] = L[b];
            L[b] = aux;
        }

        public void oddEvenSplit(int[] L, int odd, int[] even, int n){
            for(int i = 0; i < (int)n / 2; i++){
                // odd[i] = L[2 * i];
                Parallel.For(0, n, index => {
                    if(i % 2 == 0){
                        even[i] = L[2 * i + 1];
                    }
                });
            }
        }


        public void Main(string[] args){
            MergeSort(L);
            for(int i = 0; i < a; i++){
                Console.WriteLine(L[i]);
            }
        }
    }
}