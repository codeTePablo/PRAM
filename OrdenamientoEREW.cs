using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OrdenamientoEREW{
    public class Program{

        static int[] L = {16, 22, 35, 40, 53, 66, 70, 85, 15, 18, 23, 55, 60, 69, 72, 78};
        static int a = 16;
        static int n = 1;

        // static int odd = 16;
    public void MergeSortPRAM(int[] L, int n)
    {
        if(n >= 2)
        {
            Parallel.Invoke(
                () => MergeSortPRAM(L, n/2),
                () => MergeSortPRAM(L, n/2 + 1)
            );
            oddEvenMergePRAM(L, n);
        }
    }
    public void oddEvenMergePRAM(int[] L, int n)
    {
        if (n == 2)
        {
            if (L[1] > L[2])
            {
                interchange(L, 0, 1);
            }
        }else
        {            
            int m = (int)n / 2;
            int odd = m;
            int[] even = new int[m];
            oddEvenSplit(L, odd, even, n);

            Parallel.Invoke(
                () => oddEvenMergePRAM(L, odd),
                () => oddEvenMergePRAM(even, m)
            );

            Parallel.For(0, n/2, i =>
            {
                L[2 * i + 1] = even[i];
            });

            Parallel.For(0, n/2, i =>
            {
                if ((L[i]) > (L[i + 1]))
                {
                    interchange(L, i, i + 1);
                }
            });
        }
    }
        
        public void interchange(int[] L, int a, int b)
        {
            int aux;
            aux = L[a];
            L[a] = L[b];
            L[b] = aux;
        }

        public void oddEvenSplit(int[] L, int odd, int[] even, int n)
        {
            Parallel.For(0, n/2, i => {
                if(i % 2 == 0){
                    even[i] = L[2 * i + 1];
                }
            });
        }

        public void Main(string[] args){
            MergeSortPRAM(L, n);
            Console.WriteLine("Ordenamiento EREW");
            for(int i = 0; i < L.Length; i++)
            {
                Console.WriteLine(L[i]);
            }
        }
    }
}