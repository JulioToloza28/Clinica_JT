using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string DNI;
        private string Fecha_Nac;
        private string Direccion;
        public Localidad Localidad { get; set; }
        public Provincia Provincia { get; set; }
        private string Telefono;
        private string Email;
        private bool Sexo;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string Apellido1
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public string DNI1
        {
            get { return DNI; }
            set { DNI = value; }
        }
        public string Fecha_Nac1
        {
            get { return Fecha_Nac; }
            set { Fecha_Nac = value; }
        }
        public string Direccion1
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public string Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public string Email1
        {
            get { return Email; }
            set { Email = value; }
        }
        public bool Sexo1
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
    }
}
