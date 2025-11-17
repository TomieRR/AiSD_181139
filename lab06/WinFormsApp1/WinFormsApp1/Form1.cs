namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> liczby = new List<int>();


        private void buttongeneruj_Click(object sender, EventArgs e)
        {
            int liczba = Generowanie.LosujLiczbe();

            liczby.Add(liczba);
            label1.Text = string.Join(" , ",liczby);            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSofrowanieWs_Click(object sender, EventArgs e)
        {
            if (liczby.Count == 0)
                return;

            int[] tab = liczby.ToArray();

            SortowaniePrzezWstawianie.Sortowanie(tab);
            label2.Text = string.Join(" , ", tab);
        }

        private void buttonSortowanieWyb_Click(object sender, EventArgs e)
        {
            if (liczby.Count == 0)
                return;

            int[] tab = liczby.ToArray();

            SortowaniePrzezWstawianie.Sortowanie(tab);
            label2.Text = string.Join(" , ", tab);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}