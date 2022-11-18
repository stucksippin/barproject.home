namespace KT14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()

        {

            "Кузнецов",

            "Иванов",

            "Петров",

            "Кустов"

        };

            textBox1.AutoCompleteCustomSource = source;

            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://rostov.bulgakov.app/lessons/1785", 
                UseShellExecute = true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("ФИО: ") + textBox2.Text + (" ") + textBox3.Text + (" ") + textBox4.Text + (" | ") + "Класс: " + textBox5.Text + (" | ") + "Дата рождения: " + dateTimePicker1.Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("ФИО: ") + textBox2.Text + (" ") + textBox3.Text + (" ") + textBox4.Text + (" | ") + "Класс: " + textBox5.Text + (" | ") + "Дата рождения: " + dateTimePicker1.Value.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("ФИО: ") + textBox2.Text + (" ") + textBox3.Text + (" ") + textBox4.Text + (" | ") + "Класс: " + textBox5.Text + (" | ") + "Дата рождения: " + dateTimePicker1.Value.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("ФИО: ") + textBox2.Text + (" ") + textBox3.Text + (" ") + textBox4.Text + (" | ") + "Класс: " + textBox5.Text + (" | ") + "Дата рождения: " + dateTimePicker1.Value.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("ФИО: ") + textBox2.Text + (" ") + textBox3.Text + (" ") + textBox4.Text + (" | ") + "Класс: " + textBox5.Text + (" | ") + "Дата рождения: " + dateTimePicker1.Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = String.Empty;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}