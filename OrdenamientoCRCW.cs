using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoCRCW{
    public class Program{
        public static int[] L = {95, 10, 6, 15};
        public static int[] win;
        public static int i;
        public static int j;
    public void sortCRCW(int[] L, int n)
        {
            i = 0;
            j = 0;
            win = new int[n];
            // for(int i = 1; i <= n; i++)
            {
                Parallel.For(0, n, i => {
                    win[i] = 0;
                });
            }

            for(int i = 1; i <= n && i < j; i++)
            {
                Parallel.For(0, n, i => {
                    // for(int j = 1; j <= n; j++)
                    {
                        if(L[i] > L[j])
                        {
                            win[i] = win[i] + 1;
                        }else{
                            win[j] = win[j] + 1;
                        }
                    }
                });
            }

            // for(int i = 1; i <= n; i++)
            {
                Parallel.For(0, n, i => {
                    L[1 + win[i]] = L[i];
                });
            }

            imp(L, n);
        }

        public void imp (int[] L, int n)
        {
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine(L[n]);
            }
        }
        public void Main(string[] args){
            int n = 0;
            sortCRCW(L, n);
            // imp(L, n);
        }
    }
}