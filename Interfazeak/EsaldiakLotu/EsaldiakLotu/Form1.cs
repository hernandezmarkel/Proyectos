namespace EsaldiakLotu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String esaldia;
        private void Esaldi1Click(object sender, EventArgs e)
        {
            esaldia = tbEsaldiak.Text + " ";
            Esaldi1.Enabled = false;

            Esaldi2.Enabled = true;
        }

        private void Esaldi2Click(object sender, EventArgs e)
        {
            esaldia = esaldia + " " + tbEsaldiak.Text;
            Esaldi2.Enabled = false;

            Esaldi3.Enabled = true;
        }

        private void Esaldi3Click(object sender, EventArgs e)
        {
            esaldia = esaldia + " " + tbEsaldiak.Text;
            Esaldi3.Enabled = false;

            Esaldi4.Enabled = true;
        }

        private void Esaldi4Click(object sender, EventArgs e)
        {
            esaldia = esaldia + " " + tbEsaldiak.Text;
            Esaldi4.Enabled = false;

            Esaldi5.Enabled = true;
        }

        private void Esaldi5Click(object sender, EventArgs e)
        {
            esaldia = esaldia + " " + tbEsaldiak.Text;
            Esaldi5.Enabled = false;

            Lotu.Enabled = true;
        }

        private void Lotubtn(object sender, EventArgs e)
        {
            MessageBox.Show(esaldia);
        }

        private void GarbituClick(object sender, EventArgs e)
        {
            esaldia = "";

            Esaldi1.Enabled = true;

            Esaldi2.Enabled = false;
            Esaldi3.Enabled = false;
            Esaldi4.Enabled = false;
            Esaldi5.Enabled = false;
            Lotu.Enabled = false;

        }
    }
}
