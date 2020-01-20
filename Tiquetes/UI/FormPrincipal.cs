using BLL.Historial;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Impresora;
using UI.Reportes;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        String data;
        public Control control { get; set; }

        public FormPrincipal(Control control)
        {
            this.control = control;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("1");
        }


        public void agregarNumeroPantalla(string numeros) {


            data += numeros;

            txtPantalla.Text = data;



        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("9");
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            agregarNumeroPantalla("0");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            data = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                Resultado resultado = control.buscarUsuario(txtPantalla.Text);

                if (resultado.Codigo == 99)
                {
                    MessageBox.Show("Usuario no encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else {
                    //Lo encontre y por eso cierro la ventana
                    this.Visible = false;
                }

            }
            else
            {
                    MessageBox.Show("Debes ingresar una cedula", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            control.AbrirFormUsuarioAgregar();
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //Verificar txt en blanco
            if (txtPantalla.Text != "")
            {
                //Verificar si existe el registro 
                Persona persona = control.buscarUsuarioAlInsertarHistorial(txtPantalla.Text);

                if (persona.Codigo == 1)
                {
                    //No se pueden imprimir tiquestes hasta que no se configure la impresora
                    if (control.NombreInstitucion == "" || control.NombreImpresora == "")
                    {
                        MessageBox.Show("Debes configurar la impresora y el nombre de la institución", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {

                        //Insetar registro en la tabla Historial
                        string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string hora = DateTime.Now.ToString("HH:mm:ss");

                        Historial historial = new Historial
                        {
                            Fecha = fecha,
                            Identificacion = txtPantalla.Text,
                            Hora = hora
                        };

                        Resultado result = HistorialBLL.InsertarHistorial(historial);

                        if (result.Codigo == 1)
                        {
                            //Si se inserta el registro correctamente sale la ficha
                            MessageBox.Show("Tome su ficha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //crear e imprmir tiquete
                            control.CrearTickete(persona, historial);
                        }
                        else
                        {
                            MessageBox.Show("Problemas al insertar intente de nuevo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                MessageBox.Show("Ingrese un registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            txtPantalla.Text = "";
            data = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            control.AbrirFormMenuReportes();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          

        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            control.AbrirFormConfig();

            this.Visible = false;
        }

        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                 if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }




    }
}
