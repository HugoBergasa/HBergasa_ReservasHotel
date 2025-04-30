using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_ReservasHotel.bbdd
{
    internal class ConsultasSalones
    {
        public static DataTable mostrarReservas(DateTime fecha)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("idReserva");
            dt.Columns.Add("DNI de cliente");
            dt.Columns.Add("Fecha de reserva");
            dt.Columns.Add("Personas");
            dt.Columns.Add("Caterin");
            dt.Columns.Add("Precio total");

            DataRow dr;

            string consulta = "SELECT idReserva, dniCliente, fecha, numPersonas, caterin, precio "
                    + "FROM reserva_salon WHERE fecha =?fec";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Conexion.url))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?fec", fecha);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dr = dt.NewRow();
                                dr["idReserva"] = reader.GetInt32(0);
                                dr["DNI de cliente"] = reader.GetString(1);
                                dr["Fecha de reserva"] = reader.GetDateTime(2);
                                dr["Personas"] = reader.GetInt32(3);
                                dr["Caterin"] = reader.GetString(4);
                                dr["Precio total"] = reader.GetDouble(5);

                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public static DataTable MostrarReservasActuales()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("idReserva");
            dt.Columns.Add("DNI de cliente");
            dt.Columns.Add("Fecha de reserva");
            dt.Columns.Add("Personas");
            dt.Columns.Add("Caterin");
            dt.Columns.Add("Precio total");

            DataRow dr;

            string consulta = "SELECT idReserva, dniCliente, fecha, numPersonas, caterin, precio "
                    + "FROM reserva_salon WHERE fecha >=?fec";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Conexion.url))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?fec", DateTime.Today);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                dr = dt.NewRow();
                                dr["idReserva"] = reader.GetInt32(0);
                                dr["DNI de cliente"] = reader.GetString(1);
                                dr["Fecha de reserva"] = reader.GetDateTime(2);
                                dr["Personas"] = reader.GetInt32(3);
                                dr["Caterin"] = reader.GetString(4);
                                dr["Precio total"] = reader.GetDouble(5);

                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public static DataTable MostrarReservasHistorico()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("idReserva");
            dt.Columns.Add("DNI de cliente");
            dt.Columns.Add("Fecha de reserva");
            dt.Columns.Add("Personas");
            dt.Columns.Add("Caterin");
            dt.Columns.Add("Precio total");

            DataRow dr;

            string consulta = "SELECT idReserva, dniCliente, fecha, numPersonas, caterin, precio "
                    + "FROM reserva_salon WHERE fecha <?fec";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Conexion.url))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?fec", DateTime.Today);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dr = dt.NewRow();
                                dr["idReserva"] = reader.GetInt32(0);
                                dr["DNI de cliente"] = reader.GetString(1);
                                dr["Fecha de reserva"] = reader.GetDateTime(2);
                                dr["Personas"] = reader.GetInt32(3);
                                dr["Caterin"] = reader.GetString(4);
                                dr["Precio total"] = reader.GetDouble(5);

                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        public static void cargarComboCaterin(ComboBox combo)
        {
            string consulta = "SELECT DISTINCT caterin FROM reserva_salon";

            MySqlConnection conn = new MySqlConnection(Conexion.url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);
                MySqlDataReader resultados = command.ExecuteReader();

                while (resultados.Read())
                {
                    combo.Items.Add(resultados.GetString("caterin"));
                }

                resultados.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static bool reservarSalon(modelo.Salones s)
        {
            string consulta = @"INSERT INTO reserva_salon 
                      (dniCliente, fecha, numPersonas, caterin, precio, dniEmpleado) 
                      VALUES 
                      (?dniCliente, ?fecha, ?numPersonas, ?caterin, ?precio, ?dniEmpleado)";

            MySqlConnection conn = new MySqlConnection(Conexion.url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);

                command.Parameters.AddWithValue("?dniCliente", s.DniCliente);
                command.Parameters.AddWithValue("?fecha", s.Fecha);
                command.Parameters.AddWithValue("?numPersonas", s.NumPersonas);
                command.Parameters.AddWithValue("?caterin", s.Caterin);
                command.Parameters.AddWithValue("?precio", s.Precio);
                command.Parameters.AddWithValue("?dniEmpleado", s.DniEmpleado);

                command.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error reservando salón: {ex.Message}",
                              "Error en base de datos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
