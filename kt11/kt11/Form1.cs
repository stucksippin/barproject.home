namespace kt11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();
            newfrm.Show();
            this.Hide();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}