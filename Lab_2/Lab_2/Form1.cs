namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SC(int[] T,int l, int p)
        {
            if (l < p)
            {
                int œ = (l+p) / 2;
                SC(T, l, œ);
                SC(T, œ+l, p);
                SCAL(T, l, œ ,p);
            }
        }

        private void SCAL(int[] t, int l, int œ, int p)
        {
            int i = 0;
            int j = 0;
            int k = l;
            int dlugosclewej = œ - l + 1;
            int dlugoscprawej = p - œ;
            int[] lewa = new int[dlugosclewej];
            int[] prawa = new int[dlugoscprawej];


            while (i < dlugosclewej && j < dlugoscprawej)
            {
                if (lewa[i] <= prawa[j])
                {
                    t[k] = lewa[i];
                    i = i + 1;
                }
                else
                {
                    t[k] = prawa[j];
                    j = j + 1;
                }
            
            }
            k = k + 1;

            while (i < l)
            {
                t[k] = lewa[i];
                i = i + 1;
                k = k + 1;
            }

            while (i < p)
            {
                t[k] = prawa[j];
                j = j + 1;
                k = k + 1;
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            int[] T = new int[] { 38, 27, 43, 3, 9, 82, 10 };

            SC(T, 0, T.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] T = new int[] { 38, 27, 43, 3, 9, 82, 10 };

            SC(T, 0, T.Length - 1);
        }
    }
}