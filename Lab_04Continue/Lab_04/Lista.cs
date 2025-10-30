using System;

namespace Lab_04
{
    internal class Lista
    {
        public Element head;
        public Element tail;
        public int LiczbaElementow;

        public void DodajPo(Element e, int wartosc)
        {
            if (e == null)
                return;

            Element nowy = new Element(wartosc);

            nowy.next = e.next;
            nowy.prev = e;

            if (e.next != null)
            {
                e.next.prev = nowy;
            }
            else
            {
                tail = nowy;
            }

            e.next = nowy;
            LiczbaElementow++;
        }

        public void DodajPrzed(Element e, int wartosc)
        {
            if (e == null)
                return;

            Element nowy = new Element(wartosc);

            nowy.next = e;
            nowy.prev = e.prev;

            if (e.prev != null)
            {
                e.prev.next = nowy;
            }
            else
            {
                head = nowy;
            }

            e.prev = nowy;

            LiczbaElementow++;
        }
    }
}
