using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class Element
    {
        public int wartosc;
        public Element next;
        public Element prev;

        public Element(int wartosc)
        {
            this.wartosc = wartosc;
            this.next = null;
            this.prev = null;
        }
    }
}
