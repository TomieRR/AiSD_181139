namespace countingsort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> liczby = new List<int>();

        private void button2_Click(object sender, EventArgs e)
        {
            int liczba = Generowanie.LosujLiczbe();

            liczby.Add(liczba);
            label1.Text = string.Join(" , ", liczby);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            int[] posortowaneLiczby = countingsort.Countsort(liczby.ToArray());

           
            label2.Text = string.Join(" , ", posortowaneLiczby);
        }
    }
}