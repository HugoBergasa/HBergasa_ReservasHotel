using HBergasa_ReservasHotel.modelo;
using HBergasa_ReservasHotel.utilidades;
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
    internal class ConsultasHabitaciones
    {

        public static DataTable mostrarReservas(DateTime fecha)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("idReserva");
            dt.Columns.Add("DNI de cliente");
            dt.Columns.Add("Entrada");
            dt.Columns.Add("Salida");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Noches");
            dt.Columns.Add("Precio total");

            DataRow dr;

            string consulta = "SELECT idReserva, dniCliente, fechaEntrada, fechaSalida, tipoHabitacion, noches, precioTotal "
                    + "FROM reserva_habitacion WHERE fechaEntrada =?ent";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Conexion.url))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?ent", fecha);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dr = dt.NewRow();
                                dr["idReserva"] = reader.GetInt32(0);
                                dr["DNI de cliente"] = reader.GetString(1);
                                dr["Entrada"] = reader.GetDateTime(2).ToString("dd/MM/yyyy"); 
                                dr["Salida"] = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                                dr["Tipo"] = reader.GetString(4);
                                dr["Noches"] = reader.GetInt32(5);
                                dr["Precio total"] = reader.GetDouble(6);

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
            dt.Columns.Add("Entrada");
            dt.Columns.Add("Salida");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Noches");
            dt.Columns.Add("Precio total");

            DataRow dr;

            string consulta = "SELECT idReserva, dniCliente, fechaEntrada, fechaSalida, tipoHabitacion, noches, precioTotal "
                    + "FROM reserva_habitacion WHERE fechaEntrada >=?ent";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Conexion.url))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?ent", DateTime.Today);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dr = dt.NewRow();
                                dr["idReserva"] = reader.GetInt32(0);
                                dr["DNI de cliente"] = reader.GetString(1);
                                dr["Entrada"] = reader.GetDateTime(2);
                                dr["Salida"] = reader.GetDateTime(3);
                                dr["Tipo"] = reader.GetString(4);
                                dr["Noches"] = reader.GetInt32(5);
                                dr["Precio total"] = reader.GetDouble(6);

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


        public static DataTable MostrarHistoricoReservas()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("idReserva");
            dt.Columns.Add("DNI de cliente");
            dt.Columns.Add("Entrada");
            dt.Columns.Add("Salida");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Noches");
            dt.Columns.Add("Precio total");

            DataRow dr;

            string consulta = "SELECT idReserva, dniCliente, fechaEntrada, fechaSalida, tipoHabitacion, noches, precioTotal "
                    + "FROM reserva_habitacion WHERE fechaEntrada <?ent";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Conexion.url))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?ent", DateTime.Today);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dr = dt.NewRow();
                                dr["idReserva"] = reader.GetInt32(0);
                                dr["DNI de cliente"] = reader.GetString(1);
                                dr["Entrada"] = reader.GetDateTime(2);
                                dr["Salida"] = reader.GetDateTime(3);
                                dr["Tipo"] = reader.GetString(4);
                                dr["Noches"] = reader.GetInt32(5);
                                dr["Precio total"] = reader.GetDouble(6);

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
        public static void cargarComboTipo(ComboBox combo)
        {
            string consulta = "SELECT DISTINCT tipohabitacion FROM reserva_habitacion";

            MySqlConnection conn = new MySqlConnection(Conexion.url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);
                MySqlDataReader resultados = command.ExecuteReader();

                while (resultados.Read())
                {
                    combo.Items.Add(resultados.GetString("tipohabitacion"));
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

        public static bool reservarHabitacion(Habitaciones h)
        {
            string consulta = "INSERT INTO reserva_habitacion (dniCliente, fechaentrada, fechasalida, tipohabitacion, noches, preciototal, dniEmpleado) "
                    + "VALUES (?dniCliente,?fechaentrada,?fechasalida,?tipohabitacion,?noches,?preciototal,?dniEmpleado)";

            MySqlConnection conn = new MySqlConnection(Conexion.url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);

                command.Parameters.AddWithValue("?dniCliente", h.DniCliente);
                command.Parameters.AddWithValue("?fechaentrada", h.FechaEntrada);
                command.Parameters.AddWithValue("?fechasalida", h.FechaSalida);
                command.Parameters.AddWithValue("?tipohabitacion", h.Tipo);
                command.Parameters.AddWithValue("?noches", h.Noches);
                command.Parameters.AddWithValue("?preciototal", h.PrecioTotal);
                command.Parameters.AddWithValue("?dniEmpleado", h.DniEmpleado);

                command.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error reservando habitación: {ex.Message}",
                              "Error en base de datos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                return false;
            }
        }
    }
}



