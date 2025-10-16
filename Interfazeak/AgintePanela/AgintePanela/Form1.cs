using AginteKoadroa_PG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AgintePanela
{
    public partial class aginteK : Form
    {
    
       
        public aginteK()
        {
            InitializeComponent();
        }

        private void lTituloa_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void aginteK_Load(object sender, EventArgs e)
        {
            using (var db = new SalmentaDbContext())
            {
                var bezeroaData = db.Bezeroa
                .Include("Saltzailea")
                .GroupBy(b => b.Saltzailea.Izena)
                .ToDictionary(g => g.Key, g => g.Count());
                if (bezeroaData != null)
                {
                    if (bezeroaData.Count > 0)
                    {
                        chart1.DataSource = bezeroaData;
                        chart1.Series[0].YValueMembers = "Value";
                        chart1.Series[0].XValueMember = "Key";
                        chart1.DataBind();
                    }
                }
                var salmentaData = db.Salmenta
                 .Include("Bezeroa")
                  .GroupBy(b => b.Bezeroa.Izena)
                  .ToDictionary(g => g.Key, g => g.Sum(b => b.Zenbatekoa));
                if (salmentaData != null)
                {
                    if (salmentaData.Count > 0)
                    {

                        grafikoa1.Titles[0].Text = "SALMENTA GEHIENGO BEZEROAK";
                        grafikoa1.DataSource = salmentaData;
                        grafikoa1.Series[0].YValueMembers = "Value";
                        grafikoa1.Series[0].XValueMember = "Key";
                        grafikoa1.DataBind();
                    }
                }
            }
        }

        private void grafikoa1_Click(object sender, EventArgs e)
        {

        }
    }
}
