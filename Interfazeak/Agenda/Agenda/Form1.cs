using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using LibraryChartPrefijo2;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            izenaTaula.Visible = true;
            Grafikoa.Visible = true;
            erakutsidatuak();
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            DatosUsuario usuario = new DatosUsuario
            {
                Izena = Izenatb.Text,
                Abizena = Abizenatb.Text,
                Telefonoa = Teleftb.Text,
                Generoa = Generocb.Text,
                Prefijoa = Prefijotb.Text
            };

           
            usuario.GehituErregistroa();
            ActualizarChartGenero();
            userControl11.GrafikoaAldatu(DatosUsuario.ikusi());
        }

        private void Bilatu(object sender, EventArgs e)
        {
            {
                string telefono = Teleftb.Text.Trim();
                if (string.IsNullOrEmpty(telefono))
                    return;

                var usuarios = DatosUsuario.bilatu(telefono);

                // Limpiar solo las filas de datos (fila 1 en adelante)
                for (int fila = izenaTaula.RowCount - 1; fila >= 1; fila--)
                {
                    for (int col = 0; col < izenaTaula.ColumnCount; col++)
                    {
                        var control = izenaTaula.GetControlFromPosition(col, fila);
                        if (control != null)
                            izenaTaula.Controls.Remove(control);
                    }
                }

                // Agregar filas de usuarios encontrados
                int filaActual = izenaTaula.RowCount; // fila siguiente
                foreach (var u in usuarios)
                {
                    // Incrementar RowCount si es necesario
                    if (filaActual >= izenaTaula.RowCount)
                        izenaTaula.RowCount = filaActual + 1;

                    izenaTaula.Controls.Add(new Label { Text = u.Izena, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 0, filaActual);
                    izenaTaula.Controls.Add(new Label { Text = u.Abizena, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 1, filaActual);
                    izenaTaula.Controls.Add(new Label { Text = u.Telefonoa, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 2, filaActual);
                    izenaTaula.Controls.Add(new Label { Text = u.Generoa, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 3, filaActual);
                    izenaTaula.Controls.Add(new Label { Text = u.Prefijoa, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 4, filaActual);

                    filaActual++;
                }
            }
        }


        private void Datuakikusi(object sender, EventArgs e)
        {
            var usuarios = DatosUsuario.ikusi();

            izenaTaula.Controls.Clear();
            izenaTaula.ColumnCount = 5;
            izenaTaula.RowCount = usuarios.Count + 1;

            
            string[] titulos = { "Izena", "Abizena", "Telefonoa", "Generoa", "Prefijoa" };
            for (int i = 0; i < 5; i++)
                izenaTaula.Controls.Add(new Label { Text = titulos[i], Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, i, 0);

            
            for (int fila = 0; fila < usuarios.Count; fila++)
            {
                var u = usuarios[fila];
                izenaTaula.Controls.Add(new Label { Text = u.Izena, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 0, fila + 1);
                izenaTaula.Controls.Add(new Label { Text = u.Abizena, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 1, fila + 1);
                izenaTaula.Controls.Add(new Label { Text = u.Telefonoa, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 2, fila + 1);
                izenaTaula.Controls.Add(new Label { Text = u.Generoa, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 3, fila + 1);
                izenaTaula.Controls.Add(new Label { Text = u.Prefijoa, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 4, fila + 1);
            }
        }


        private void ActualizarChartGenero()
        {
            var usuarios = DatosUsuario.ikusi();

            // Contar cuántos hay de cada género
            var conteoGenero = usuarios
                .GroupBy(u => u.Generoa)
                .Select(g => new { Genero = g.Key, Cantidad = g.Count() })
                .ToList();

            // Limpiar series existentes
            Grafikoa.Series.Clear();

            // Crear nueva serie tipo Pie (Donut)
            var serie = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Generos",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            };

            Grafikoa.Series.Add(serie);

            // Llenar la serie con los datos
            foreach (var item in conteoGenero)
            {
                serie.Points.AddXY(item.Genero, item.Cantidad);
            }

            // Opcional: mostrar etiquetas con cantidad
            serie.Label = "#VALY (#PERCENT{P0})";
        }


        


        private void erakutsidatuak()
        {
            
        }
    }
}
