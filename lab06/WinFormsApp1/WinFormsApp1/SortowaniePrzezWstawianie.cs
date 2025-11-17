using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SortowaniePrzezWstawianie
    {
        public static void Sortowanie(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int p = tab[i];
                int j = i - 1;
                while (j>=0 && tab[j] > p)
                {
                    tab[j + 1] = tab[j];
                    j = j - 1;
                }
                tab[j + 1] = p;
            }
        }
        
    }
}
