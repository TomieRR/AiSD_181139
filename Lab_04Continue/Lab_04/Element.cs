using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class Element
    {
        public int value;
        public Element next;
        public Element prev;

        public Element(int value)
        {
            this.value = value;
            this.next = null;
            this.prev = null;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}