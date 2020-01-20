using BLL.Configuracion;
using BLL.Personas;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Impresora;
using UI.Reportes;

namespace UI
{
    public class Control
    {
        FormPrincipal principal;
        FormUsuario usuario;
        FormReportes formMenuReportes;
        FormReportesRangoFechas reportesRangoFechas;
        FormReporteUsuario formReporteUsuario;
        FormImpresora formImpresora;
        FormConfig formConfig;
        ListaPersonas listaPersonas;
        Tickets ticket;


        public string NombreImpresora { get; set; }
        public string NombreInstitucion { get; set; }

        public Control() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            usuario = new FormUsuario(this);
            formMenuReportes = new FormReportes(this);
            reportesRangoFechas = new FormReportesRangoFechas(this);
            formReporteUsuario = new FormReporteUsuario(this);
            listaPersonas = new ListaPersonas(this);
            formImpresora = new FormImpresora(this);
            formConfig = new FormConfig(this);
            ticket = new Tickets();


            // Llamada al metodo para obtener el nombre de la impresora
            NombresImpresora();

            Application.Run(principal = new FormPrincipal(this));

        }


        //Control de Ventanas

        public void AbrirFormUsuarioAgregar() {
            usuario.Show();
            usuario.ocultarBotonesAlAgregar();
            usuario.LimpiarTextos();
        }

        public void AbrirFormUsuario()
        {
            usuario.Show();
        }

        public void AbrirFormPrincipal()
        {
            principal.Show();
        }

        public void AbrirFormMenuReportes() {
            formMenuReportes.Show();

        }

        public void AbrirFormReporteDiario() {
            formReporteUsuario.Visible = true;
        }

        public void AbrirFormReporteFechas() {
            reportesRangoFechas.Visible = true;
        }

        public void AbrirFormListaUsuarios() {
            listaPersonas.Show();
        }

        public void AbrirFormImpresora()
        {
            formImpresora.Show();
        }


        public void AbrirFormConfig()
        {
            formConfig.Show();
        }

        public void CerrarFormReportesPrincipal() {
            formMenuReportes.Visible = false;
        }


        public Persona buscarUsuarioAlInsertarHistorial(string cedula)
        {
            Persona persona = PersonasBLL.BuscarUnaPersona(cedula);


            if (persona != null)
            {
                persona.Codigo = 1;
                persona.Mensaje = "Buscado correctamente";
                return persona;
            }
            else
            {
                Persona p = new Persona();

                p.Codigo = 99;
                p.Mensaje = "No encontrado";

                return p;
            }

        }

    




            public Resultado buscarUsuario(string cedula) {

            Persona persona = PersonasBLL.BuscarUnaPersona(cedula);


            if (persona != null)
            {
                AbrirFormUsuario();
                usuario.CargarDatosUsuarioBuscado(persona);
                usuario.ocultarBotonesAlModificar();

                return new Resultado
                {
                    Codigo = 1,
                    Mensaje = "Buscado correctamente"
                };

            }
            else {
                return new Resultado
                {
                    Codigo = 99,
                    Mensaje = "No encontrado"
                };

            }
        }



        public Resultado ModificarUsuario(Persona persona)
        {

            Resultado resultado = PersonasBLL.ActualizarPersonas(persona);

            return resultado;
        }

        public void CargarGridUsuarios() {

            listaPersonas.CargarGrid();
        }


        public void CrearTickete(Persona persona, Historial historial) {



                //ticket.AbreCajon();
                ticket.dibujarAsteriscos();

                ticket.TextoCentro(NombreInstitucion);
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoCentro("Registro comedor estudiantil");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("Fecha: " + historial.Fecha);
                ticket.TextoIzquierda("Hora: " + historial.Hora);
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");


                ticket.TextoCentro(persona.Nombre);
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");

                ticket.dibujarAsteriscos();

                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");

            //ticket.CortarTicket();

            ticket.ImprimirTicket(NombreImpresora); // NOMBRE DE LA IMPRESORA      



        }


        public void NombresImpresora() {
            //traer el nombre de la institucion y impresora que esta en la BD

            Configuracion c = ConfiguracionBLL.BuscarConfiguracion();

            if (c != null)
            {
                NombreImpresora = c.NombreImpresora;
                NombreInstitucion = c.NombreInstitucion;
            }
            else {
                NombreImpresora = "";
                NombreInstitucion = "";
            }


        }



        public void ObtenerNombreImprespra(string nombre) {

            //Este metodo obtiene el nombre de la impresora del FormImpresora y despues lo coloca en el FormConfig
            //Seteo el nombre de la impresora
            formConfig.NombreImpresora = nombre;

            //Este metodo toma la variable y la coloca en el txt
            formConfig.cargarNombreImpresora(); 

        }




    }
}
