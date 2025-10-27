using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_04;

namespace Lab_04
{
    internal class Lista
    {
        public Element head;
        public Element tail;
        public int LiczbaElementow;

        public void DodajPo(Element e, int liczba)
        {
            if (e == null)
            {
                return;
            }
             Element aktualny = e;

            for(int i = 0; i < liczba; i++)
            {
                Element nowy = new Element(i + 1);

                nowy.next = aktualny.next;

                if(aktualny.next != null)
                {
                    aktualny.next.prev = nowy;
                }
                aktualny.next = nowy;
                nowy.prev = aktualny;

                if(nowy.next == null)
                {
                    tail = nowy;
                }
                LiczbaElementow++;

                aktualny = nowy;
            }

            }
        public void Dodajprzed(Element e, int liczba)
        {
            if (e == null)
            {
                return;
            }
            Element aktualny = e;


        }
        }

    }


