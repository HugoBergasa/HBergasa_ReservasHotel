using HBergasa_ReservasHotel.modelo;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_ReservasHotel.bbdd
{
    internal class Conexion
    {
        public static readonly string url = "Server=145.14.151.1; " +
        "Database=u812167471_reservas; " +
        "User=u812167471_reservas; " +
        "port=3306; " +
        "password=2025-Reservas; " +
        "Convert Zero Datetime=True";

        public static bool acceder(string user, string pass)
        {
            string consulta = "SELECT usuario, contraseña FROM empleados WHERE usuario=?user AND contraseña=?pass ";

            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);

                command.Parameters.AddWithValue("?user", user);
                command.Parameters.AddWithValue("?pass", pass);

                MySqlDataReader resultados = command.ExecuteReader();

                if (resultados.Read())
                {
                    return true;
                }
                resultados.Close();
                conn.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);

            }
            return false;

        }

        public static DatosPersona rescatarDniYNombreCompleto(string usuario)
        {
            string consulta = "SELECT dniEmpleado, nombre, apellidos FROM empleados WHERE usuario=?usuario";

            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?usuario", usuario);

                MySqlDataReader resultados = command.ExecuteReader();

                if (resultados.Read())
                {
                    DatosPersona datos = new DatosPersona(
                        resultados.GetString("dniEmpleado"),
                        resultados.GetString("nombre"),
                        resultados.GetString("apellidos")
                    );

                    resultados.Close();
                    conn.Close();
                    return datos;
                }

                resultados.Close();
                conn.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al rescatar los datos personales");

            }

            return null;
        }
    }
}
