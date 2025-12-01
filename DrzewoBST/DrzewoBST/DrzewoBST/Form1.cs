using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DrzewoBST;
using DrzewoBTS;

namespace DrzewoBST
{
    public partial class Form1 : Form
    {
        private Dodawanie drzewo;
        private List<int> numbers;  // Lista przechowuj¹ca wygenerowane liczby

        public Form1()
        {
            InitializeComponent();
            drzewo = new Dodawanie();  // Inicjalizacja drzewa
            numbers = new List<int>();  // Inicjalizacja listy, która przechowuje liczby
        }

        // Dodawanie liczby do listy (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            int number = Generate.GenerateNumber();  // Generowanie liczby z klasy Generate
            numbers.Add(number);  // Dodawanie liczby do listy
            label1.Text = string.Join(", ", numbers);  // Wyœwietlanie wygenerowanych liczb w label1
        }

        // Przycisk 2 - Wyœwietlanie posortowanej listy liczb w label2
        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sortedNumbers = new List<int>(numbers);  // Tworzenie kopii listy
            sortedNumbers.Sort();  // Sortowanie kopii listy
            label2.Text = "Posortowane liczby: " + string.Join(", ", sortedNumbers);  // Wyœwietlanie posortowanej listy
        }

        // Usuwanie liczby z drzewa (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int valueToRemove))  // Sprawdzanie, czy wartoœæ w TextBox jest liczb¹
            {
                drzewo.Remove(valueToRemove);  // Usuwanie liczby z drzewa
                label1.Text = string.Join(", ", drzewo.GetNumbers());  // Wyœwietlanie zaktualizowanej listy w label1
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
