using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_ReservasHotel.utilidades
{
    internal class Utilidades
    {

        // Método para comprobar si algún campo está vacío
        public static bool CampoVacio(TextBox campo)
        {
            return string.IsNullOrWhiteSpace(campo.Text);
        }

        // Método para lanzar un mensaje en caso de campo vacío
        public static void LanzarAlertaVacio(TextBox campo)
        {
            MessageBox.Show("El campo " + campo.Tag + " es obligatorio");
        }

        // Método para combos vacíos
        public static bool ComboVacio(ComboBox combo)
        {
            return combo.SelectedIndex == 0 || combo.SelectedItem == null;
        }

        // Alerta para combos vacíos
        public static void LanzarAlertaCombo(ComboBox combo)
        {
            MessageBox.Show($"Debe seleccionar una opción válida en " + combo.Tag);
        }


        // Validación de fechas
        public static bool ValidarFechas(DateTimePicker fechaEntrada, DateTimePicker fechaSalida)
        {
            DateTime fechaActual = DateTime.Today;

            if (fechaEntrada.Value < fechaActual)
            {
                MessageBox.Show("Debe elegir una fecha válida en " + fechaEntrada.Tag);
                return false;
            }

            if (fechaSalida.Value <= fechaEntrada.Value)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de entrada");
                return false;
            }

            return true;
        }

        // Conversión de fechas (simplificada para C#)
        public static DateTime? ConvertirFechaSql(DateTime? fecha)
        {
            return fecha?.Date;
        }

        // Formateo de fecha
        public static string formatea(DateTime? fecha)
        {
            return fecha?.ToString("dd/MM/yyyy") ?? "Sin fecha";
        }

        // Validación de DNI
        public static bool ValidarDNI(string dni)
        {
            dni = dni.Trim().ToUpper();

            if (dni.Length != 9)
            {
                MessageBox.Show("El DNI debe de tener 9 caracteres.");
                return false;
            }

            if (!int.TryParse(dni.Substring(0, 8), out int numero))
            {
                MessageBox.Show("Los primeros 8 caracteres deben ser números.");
                return false;
            }

            char letraIngresada = dni[8];
            string letrasValidas = "TRWAGMYFPDXBNJZSQVHLCKE";

            char letraCorrecta = letrasValidas[numero % 23];

            if (letraIngresada != letraCorrecta)
            {
                MessageBox.Show("La letra del DNI no es correcta." + Environment.NewLine + "Letra correcta: " + letraCorrecta);
                return false;
            }

            return true;
        }

        // Validación de teléfono
        public static bool ValidarTelefono(string telefono)
        {
            string expresion = @"^(\+34|0034)?[6-9]\d{8}$";
            if (!Regex.IsMatch(telefono, expresion))
            {
                MessageBox.Show("El número de teléfono no tiene un formato válido");
                return false;
            }
            return true;
        }

        // Validación de email
        public static bool ValidarEmail(string email)
        {
            string expresion = @"^[\w.-]+@[\w.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, expresion))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido");
                return false;
            }
            return true;
        }

        // Validación de código postal
        public static bool ValidarCp(string cp)
        {
            string expresion = @"^\d{5}$";
            if (!Regex.IsMatch(cp, expresion))
            {
                MessageBox.Show("El código postal no tiene un formato válido");
                return false;
            }
            return true;
        }
    }
}

