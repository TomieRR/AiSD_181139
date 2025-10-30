using System;
using System.Windows.Forms;

namespace Lab_04
{
    public partial class Form1 : Form
    {
        Lista lista = new Lista();
        Element pierwszy;

        public Form1()
        {
            InitializeComponent();

            pierwszy = new Element(0);
            lista.head = pierwszy;
            lista.tail = pierwszy;
            lista.LiczbaElementow = 1;
        }

        private void buttonDodajPo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLiczba.Text, out int liczba))
            {
                lista.DodajPo(lista.tail, liczba);
                PokazListe($"Dodano {liczba} po ostatnim elemencie.");
            }
            else
            {
                MessageBox.Show("Podaj poprawną liczbę!");
            }
        }

        private void buttonDodajPrzed_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLiczba.Text, out int liczba))
            {
                lista.DodajPrzed(lista.head, liczba);
                PokazListe($"Dodano {liczba} przed pierwszym elementem.");
            }
            else
            {
                MessageBox.Show("Podaj poprawną liczbę!");
            }
        }

        private void PokazListe(string komunikat = "")
        {
            Element temp = lista.head;
            string tekst = "";

            while (temp != null)
            {
                tekst += temp.value + " ";
                temp = temp.next;
            }

            labelWynik.Text = komunikat + "\nLista: " + tekst;
        }
    }
}
