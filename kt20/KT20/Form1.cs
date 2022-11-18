using System.Threading;
namespace KT20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int mins = 100; 
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Timer ts = new System.Threading.Timer(Callback, null, 3000000, 1000);
        }
        public static void Callback(object? obj)
		{
            while (mins > 0)
            {
                mins = mins - 5;
                MessageBox.Show($"До конца занятия осталось {mins} минут");
            }
            MessageBox.Show("Занятие закончилось!");
		}
    }
}