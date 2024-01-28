namespace Zarządzanie_Hurtownią
{
    public partial class Okno1 : Form
    {
        public Okno1()
        {
            InitializeComponent();
            this.Text = "Kraina Świeżych Smaków";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OknoLogowania oknoLogowania = new OknoLogowania(this);
            oknoLogowania.Show();
        }
    }
}