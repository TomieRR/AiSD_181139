namespace AiSD_test
{
    public partial class Form1 : Form
    {
        Random r = new Random((int)DateTime.Now.Ticks);
        int licznik = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.btn.Text = "Skacz";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_MouseHover(object sender, EventArgs e)
        {

            if (this.btn.Text == "Start")
                return;
            if (this.licznik > 2)
            {
                MessageBox.Show("Koniec programu");
                this.btn.Text = "Start";
                licznik = 0;
                this.lbl.Text = licznik.ToString();
                return;
            }
                
            
            int x = r.Next(0, this.Size.Width - this.btn.Size.Width);
            int y = r.Next(0, this.Size.Height - this.btn.Size.Height);

            btn.Location = new Point(x,y);
            licznik++;
            lbl.Text = licznik.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

      
    }
}