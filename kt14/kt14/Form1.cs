namespace kt14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
            "1",
            "2",
            "3",
            "4"
            };
            tx4.AutoCompleteCustomSource = source;
            tx4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tx4.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        
     

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string a = tx1.Text;
            string b = tx2.Text;
            string c = tx3.Text;
            string d = tx4.Text;
            string de = tx5.Text;

            output.Text = a +" "+ b+" " +c + " " + d + " "+ de + " " ;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rostov.bulgakov.app/lessons");
        }








        public class AddList //класс для создания списка
        {
            string First_Name, Second_Name, Patronymic, Age, Class;
            public List<Person> Persons = new List<Person>();
        }
        public class Person //класс для данных
        {
            public string Patronymic;
            public string First_Name;
            public string Second_Name;
            public string Class;
            public string Age;
        }

        private void tx1_TextChanged(object sender, EventArgs e)
        {
            new Person().First_Name = Convert.ToString(tx1.Text);
        }

        private void tx2_TextChanged(object sender, EventArgs e)
        {
            new Person().Second_Name = Convert.ToString(tx2.Text);
        }

        private void tx3_TextChanged(object sender, EventArgs e)
        {
            new Person().Patronymic = Convert.ToString(tx3.Text);
        }

        private void tx4_TextChanged(object sender, EventArgs e)
        {
            new Person().Class = Convert.ToString(tx4.Text);
        }

        private void tx5_TextChanged(object sender, EventArgs e)
        {
            new Person().Age = Convert.ToString(tx3.Text);
        }
    }
}