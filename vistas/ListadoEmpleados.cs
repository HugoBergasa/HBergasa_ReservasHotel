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
    public partial class ListadoEmpleados : Form
    {
        public ListadoEmpleados()
        {
            InitializeComponent();
            bbdd.ConsultaEmpleados.CargarComboTurno(comboTurno);
            comboTurno.SelectedIndex = 0;
        }

        private void ListadoEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabla.DataSource=bbdd.ConsultaEmpleados.CargarTablaEmpleados(comboTurno.Text);
        }
    }
}
