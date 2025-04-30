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
    public partial class ListadoReservaHabitaciones : Form
    {
        public ListadoReservaHabitaciones()
        {
            InitializeComponent();
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = calendario.Value.Date; 
            DataTable resultado = bbdd.ConsultasHabitaciones.mostrarReservas(fechaSeleccionada);
            tabla.DataSource = resultado;
        }

        private void botonActuales_Click(object sender, EventArgs e)
        {
            DataTable resultado = bbdd.ConsultasHabitaciones.MostrarReservasActuales();
            tabla.DataSource = resultado;
        }

        private void botonHistorico_Click(object sender, EventArgs e)
        {

            DataTable resultado = bbdd.ConsultasHabitaciones.MostrarHistoricoReservas();
            tabla.DataSource = resultado;
        }
    }
}
