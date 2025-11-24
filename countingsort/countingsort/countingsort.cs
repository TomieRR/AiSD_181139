using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countingsort
{
    class countingsort
    {
        public static int[] Countsort(int[] arr)
        {
            if (arr.Length == 0)
            {
                return new int[0];
            }

         
            int WartoscMax = arr[0];
            int WartoscMin = arr[0];
            foreach (int kolejny in arr)
            {
                if (kolejny > WartoscMax)
                {
                    WartoscMax = kolejny;
                }
                if (kolejny < WartoscMin)
                {
                    WartoscMin = kolejny;
                }
            }


            int[] iloscelementow = new int[WartoscMax - WartoscMin + 1];

            
            for (int i = 0; i < iloscelementow.Length; i++)
            {
                iloscelementow[i] = 0;
            }


            foreach (int kolejny in arr)
            {
                iloscelementow[kolejny - WartoscMin]++;
            }

            
            for (int i = 1; i < iloscelementow.Length; i++)
            {
                iloscelementow[i] += iloscelementow[i - 1];
            }

            int n = arr.Length;
            int[] wynik = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                int kolejny = arr[i];
                wynik[iloscelementow[kolejny - WartoscMin] - 1] = kolejny;
                iloscelementow[kolejny - WartoscMin]--;
            }

            return wynik;
        }
    }
}
