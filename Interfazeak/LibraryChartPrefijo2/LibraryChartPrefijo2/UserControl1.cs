using Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryChartPrefijo2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void GrafikoaAldatu(List<DatosUsuario> listaKontaktua)
        {
            var lista = DatosUsuario.ikusi();
            int total = lista.Count;

            if (chart2.Series.Count > 0)
            {
                var seriePrefijo = chart2.Series[0];
                seriePrefijo.Points.Clear();

                foreach (var p in lista.GroupBy(k => k.Prefijoa))
                {
                    double porcentaje = (p.Count() * 100.0) / total;
                    int idx = seriePrefijo.Points.AddXY(p.Key, p.Count());
                    seriePrefijo.Points[idx].Label = $"{porcentaje:F1}%";
                }
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}