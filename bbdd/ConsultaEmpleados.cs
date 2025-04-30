using HBergasa_ReservasHotel.modelo;
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
    internal class ConsultaEmpleados
    {
        public static bool RegistrarEmpleado(Empleado e)
        {
            string consulta = @"INSERT INTO empleados 
        (dniEmpleado, nombre, apellidos, telefono, email, 
        fechaContrato, turno, salarioBase, usuario, contraseña) 
        VALUES 
        (?dni, ?nombre, ?apellidos, ?telefono, ?email, 
        ?fecha, ?turno, ?salario, ?user, ?pass)";

            MySqlConnection conn = new MySqlConnection(Conexion.url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);

                // Parámetros en el mismo orden que en el VALUES
                command.Parameters.AddWithValue("?dni", e.Dni);
                command.Parameters.AddWithValue("?nombre", e.Nombre);
                command.Parameters.AddWithValue("?apellidos", e.Apellidos);
                command.Parameters.AddWithValue("?telefono", e.Telefono);
                command.Parameters.AddWithValue("?email", e.Email);
                command.Parameters.AddWithValue("?fecha", e.FechaContrato);
                command.Parameters.AddWithValue("?turno", e.Turno);
                command.Parameters.AddWithValue("?salario", e.Salario);
                command.Parameters.AddWithValue("?user", e.Usuario);
                command.Parameters.AddWithValue("?pass", e.Contrasena);

                command.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

            return false;
        }

        public static void CargarComboTurno(ComboBox combo)
        {
            string consulta = "SELECT DISTINCT turno FROM empleados";

            MySqlConnection conn = new MySqlConnection(Conexion.url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);
                MySqlDataReader resultados = command.ExecuteReader();

                while (resultados.Read())
                {
                    combo.Items.Add(resultados.GetString("turno"));
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

        public static bool dniDuplicado(string dni)
        {
            bool existe = false;
            MySqlConnection conn = new MySqlConnection(Conexion.url);
            conn.Open();

            try
            {
                string consulta = "SELECT COUNT(*) FROM empleados WHERE dniEmpleado = ?dni";

                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?dni", dni);

                MySqlDataReader resultados = command.ExecuteReader();

                if (resultados.Read())
                {
                    int count = resultados.GetInt32(0);
                    existe = (count > 0);
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

            return existe;
        }

        public static DataTable CargarTablaEmpleados(string turno)
        {
            DataTable dt = new DataTable();

            string consulta = @"SELECT dniEmpleado, nombre, apellidos, telefono, 
                      email, fechaContrato, turno 
                      FROM empleados 
                      WHERE turno = ?turno";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Conexion.url))
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(consulta, conn);

                    command.Parameters.AddWithValue("?turno", turno);

                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;

                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"No hay empleados en el turno: {turno}");
                    }

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}",
                              "Error de base de datos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return null;
            }
        }
    }
}