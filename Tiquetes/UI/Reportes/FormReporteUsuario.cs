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
    public partial class FormReporteUsuario : Form
    {
        public Control control { get; set; }
        

        public FormReporteUsuario(Control control)
        {
            this.control = control;
            InitializeComponent();
        }

        private void FormReporteUsuario_Load(object sender, EventArgs e)
        {
            this.spReporteAldiaTableAdapter.Fill(this.dataSetReporteDiario.SpReporteAldia, DateTime.Now);


            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            control.AbrirFormMenuReportes();
            this.Visible = false;
        }
    }
}
