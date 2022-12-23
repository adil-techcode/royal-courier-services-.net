namespace rcs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}