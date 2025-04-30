using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBergasa_ReservasHotel.modelo
{
    internal class Habitaciones
    {
        private int idReserva;
        private string dniCliente, dniEmpleado;
        private DateTime fechaEntrada, fechaSalida;
        private string tipo;
        private int noches;
        private double precioTotal;

        public Habitaciones(string dniCliente, string dniEmpleado, DateTime fechaEntrada, DateTime fechaSalida, string tipo, int noches, double precioTotal)
        {
            this.dniCliente = dniCliente;
            this.dniEmpleado = dniEmpleado;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.tipo = tipo;
            this.noches = noches;
            this.precioTotal = precioTotal;
        }

        public Habitaciones(int idReserva, string dniCliente, DateTime fechaEntrada, DateTime fechaSalida, string tipo, int noches, double precioTotal)
        {
            this.idReserva = idReserva;
            this.dniCliente = dniCliente;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.tipo = tipo;
            this.noches = noches;
            this.precioTotal = precioTotal;
        }

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string DniEmpleado { get => dniEmpleado; set => dniEmpleado = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Noches { get => noches; set => noches = value; }
        public double PrecioTotal { get => precioTotal; set => precioTotal = value; }

        public override string ToString()
        {
            return "________________RESERVA_________________"+Environment.NewLine 
                + Environment.NewLine+"\nDNI cliente: " + this.dniCliente
                + Environment.NewLine + "\nFecha de entrada: " + this.fechaEntrada
                + Environment.NewLine + "\nFecha de salida: " + this.fechaSalida
                + Environment.NewLine + "\nNoches reservadas: " + this.noches
                + Environment.NewLine + "\nTipo de habitación: " + this.tipo
                + Environment.NewLine + "\nTotal factura: " + this.precioTotal
                + Environment.NewLine + "\n__________________________________________\n";
        }
    }
}