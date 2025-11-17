using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SortowaniePrzezWybieranie
    {
        public static void Sortowanie(int[] Tab)
        {
            for (int i = 0; i <Tab.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < Tab.Length; j++)
                {
                    if (Tab[j] < Tab[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = Tab[minIndex];
                Tab[minIndex] = Tab[i];
                Tab[i] = temp;
            }
        }
    }
}
