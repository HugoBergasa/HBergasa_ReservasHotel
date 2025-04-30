using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBergasa_ReservasHotel.modelo
{
    internal class Empleado : DatosPersona
    {
        private DateTime fechaContrato;
        private string turno;
        private double salario;
        private string usuario, contrasena;

        public Empleado(
        string dni,
        string nombre,
        string apellidos,
        int telefono,
        string email,

        DateTime fechaContrato,
        string turno,
        double salario,
        string usuario,
        string contrasena)

        : base(dni, nombre, apellidos, telefono, email)  
        {
            this.FechaContrato = fechaContrato;
            this.Turno = turno;
            this.Salario = salario;
            this.Usuario = usuario;
            this.Contrasena = contrasena;
        }

        public DateTime FechaContrato { get => fechaContrato; set => fechaContrato = value; }
        public string Turno { get => turno; set => turno = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}

