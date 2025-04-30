using HBergasa_ReservasHotel.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBergasa_ReservasHotel.modelo
{
    internal class Salones
    {
        private int idReserva;
        private string dniCliente, dniEmpleado;
        private DateTime fecha;
        private int numPersonas;
        private string caterin;
        private double precio;

        public Salones(string dniCliente, string dniEmpleado, DateTime fecha, int numPersonas, String caterin, double precio)
        {
            this.dniCliente = dniCliente;
            this.dniEmpleado = dniEmpleado;
            this.fecha = fecha;
            this.numPersonas = numPersonas;
            this.caterin = caterin;
            this.precio = precio;
        }

        public Salones(int idReserva, string dniCliente, DateTime fecha, int numPersonas, string caterin, double precio)
        {
            this.idReserva = idReserva;
            this.dniCliente = dniCliente;
            this.fecha = fecha;
            this.numPersonas = numPersonas;
            this.caterin = caterin;
            this.precio = precio;
        }

        

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string DniEmpleado { get => dniEmpleado; set => dniEmpleado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int NumPersonas { get => numPersonas; set => numPersonas = value; }
        public string Caterin { get => caterin; set => caterin = value; }
        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return "_____________________RESERVA_______________________"+Environment.NewLine
                    + Environment.NewLine+"DNI cliente: " + this.dniCliente
                    + Environment.NewLine+"\nFecha de entrada: " + this.fecha.ToString("dd/MM/yyyy")
                    + Environment.NewLine+"\nNúmero de personas: " + this.numPersonas
                    + Environment.NewLine+"\nTipo de caterin: " + this.caterin
                    + Environment.NewLine+"\nTotal factura: " + this.precio
                    + Environment.NewLine+"\n___________________________________________________\n";
        }
    }
}
