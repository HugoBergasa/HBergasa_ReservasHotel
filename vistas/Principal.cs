using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_ReservasHotel.vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            labelBienvenida.Text = ("Bienvenid@ a su aplicación de reservas, " + Login.nombreRescatado + Login.apellidosRescatado);

        }

        private void botonReservaHabitaciones_Click(object sender, EventArgs e)
        {
            ReservaHabitaciones rh = new ReservaHabitaciones();
            rh.Show();
            
        }

        private void botonReservaSalones_Click(object sender, EventArgs e)
        {
            ReservaSalones rs = new ReservaSalones();
            rs.Show();
        }

        private void botonAltaEmpleados_Click(object sender, EventArgs e)
        {
            AltaEmpleados ae = new AltaEmpleados();
            ae.Show();
        }

        private void botonListaHabitaciones_Click(object sender, EventArgs e)
        {
            ListadoReservaHabitaciones lh = new ListadoReservaHabitaciones();
            lh.Show();
        }

        private void botonListaSalones_Click(object sender, EventArgs e)
        {
            ListadoReservasSalones ls = new ListadoReservasSalones();
            ls.Show();
        }

        private void botonListaEmpleados_Click(object sender, EventArgs e)
        {
            ListadoEmpleados le = new ListadoEmpleados();
            le.Show();
        }
    }
}
