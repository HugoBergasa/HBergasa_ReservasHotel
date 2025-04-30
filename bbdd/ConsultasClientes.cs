using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_ReservasHotel.bbdd
{
    internal class ConsultasClientes
    {
        public static modelo.Cliente buscarPersonas(string dni)
        {
            modelo.Cliente c = null;
            MySqlConnection conn = new MySqlConnection(Conexion.url);
            conn.Open();

            try
            {
                string consulta = @"SELECT dniCliente, nombre, apellidos, telefono, 
                          email, direccion, cp, localidad 
                          FROM clientes 
                          WHERE dniCliente = ?dniCliente";

                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?dniCliente", dni);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    c = new modelo.Cliente(
                        reader.GetString("direccion"),
                        reader.GetString("localidad"),
                        reader.GetString("dniCliente"),
                        reader.GetInt32("cp"),
                        reader.GetString("nombre"),
                        reader.GetString("apellidos"),
                        reader.GetInt32("telefono"),
                        reader.GetString("email")
                    );
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return c;
        }

        public static bool registrarPersona(modelo.Cliente c)
        {
            string consulta = @"INSERT INTO clientes 
                      (dniCliente, nombre, apellidos, telefono, 
                       email, direccion, cp, localidad) 
                      VALUES 
                      (?dni, ?nombre, ?apellidos, ?telefono, 
                       ?email, ?direccion, ?cp, ?localidad)";

            MySqlConnection conn = new MySqlConnection(Conexion.url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);

                command.Parameters.AddWithValue("?dni", c.Dni);
                command.Parameters.AddWithValue("?nombre", c.Nombre);
                command.Parameters.AddWithValue("?apellidos", c.Apellidos);
                command.Parameters.AddWithValue("?telefono", c.Telefono);
                command.Parameters.AddWithValue("?email", c.Email);
                command.Parameters.AddWithValue("?direccion", c.Direccion);
                command.Parameters.AddWithValue("?cp", c.Cp);
                command.Parameters.AddWithValue("?localidad", c.Localidad);

                command.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error registrando cliente: {ex.Message}",
                                "Error en base de datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
