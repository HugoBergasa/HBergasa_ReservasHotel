using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_ReservasHotel.vistas
{
    public partial class ReservaHabitaciones : Form
    {
        public ReservaHabitaciones()
        {
            InitializeComponent();
            CrearFichero();
            
        }

        private void botonComprobar_Click(object sender, EventArgs e)
        {
           
        }
    

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
           
        }

        private void botonComprobar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void botonRegistrar_Click_1(object sender, EventArgs e)
        {
            Registro();
            
        }

        private void botonComprobar_Click_2(object sender, EventArgs e)
        {
            try
            {
                string dni = campoDni.Text.ToUpper();
                modelo.Cliente micliente = bbdd.ConsultasClientes.buscarPersonas(dni);

                if (!utilidades.Utilidades.ValidarDNI(campoDni.Text))
                {
                    return;
                }

                if (micliente != null)
                {
                    campoDni.Enabled = false;
                    campoDni.BackColor = Color.Green;
                    CampoNombre.Text = micliente.Nombre;
                    campoApellidos.Text = micliente.Apellidos;
                    campoTelefono.Text = micliente.Telefono.ToString();
                    campoEmail.Text = micliente.Email;
                    campoDireccion.Text = micliente.Direccion;
                    campoCp.Text = micliente.Cp.ToString();
                    campoLocalidad.Text = micliente.Localidad;
                    calendarioEntrada.Enabled = true;
                    calendarioSalida.Enabled = true;
                    comboHabitacion.Enabled = true;
                    botonReserva.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes registrados con ese DNI");
                    CampoNombre.Enabled = true;
                    campoApellidos.Enabled = true;
                    campoTelefono.Enabled = true;
                    campoEmail.Enabled = true;
                    campoDireccion.Enabled = true;
                    campoCp.Enabled = true;
                    campoLocalidad.Enabled = true;
                    botonRegistrar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario");
                campoDni.Text = "";
                CampoNombre.Text = "";
                campoApellidos.Text = "";
                campoTelefono.Text = "";
                campoEmail.Text = "";
                campoDireccion.Text = "";
                campoCp.Text = "";
                campoLocalidad.Text = "";
            }
        }

        private void botonReserva_Click(object sender, EventArgs e)
        {
            Reserva();
        }

        private void botonFactura_Click(object sender, EventArgs e)
        {
            AbrirFactura();
        }
    }
}
