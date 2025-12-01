using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrzewoBST
{
    public static class Generate
    {
        private static Random rand = new Random();
        public static int GenerateNumber()
        {
            return rand.Next(0, 16);
        }
    }
}
