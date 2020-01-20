using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Reportes
{
    public partial class FormReportesRangoFechas : Form
    {
        public Control control { get; set; }

        public FormReportesRangoFechas(Control control)
        {
            this.control = control;

            InitializeComponent();
        }

        private void FormReportesRangoFechas_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteRangoFecha.SpReporteAlPorFecha' Puede moverla o quitarla según sea necesario.
            this.SpReporteAlPorFechaTableAdapter.Fill(this.DataSetReporteRangoFecha.SpReporteAlPorFecha,DpDesde.Value,DpHasta.Value);

            this.reportViewer1.RefreshReport();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            control.AbrirFormMenuReportes();
            this.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteRangoFecha.SpReporteAlPorFecha' Puede moverla o quitarla según sea necesario.
            this.SpReporteAlPorFechaTableAdapter.Fill(this.DataSetReporteRangoFecha.SpReporteAlPorFecha, DpDesde.Value, DpHasta.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
