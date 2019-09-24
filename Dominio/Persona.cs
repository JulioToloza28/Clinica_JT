using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string DNI;
        private DateTime Fecha_Nac;
        private string Direccion;
        private string Localidad;
        private string Provincia;
        private string Telefono;
        private string Email;
        private bool Sexo;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public DateTime Fecha_Nac1 { get => Fecha_Nac; set => Fecha_Nac = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Localidad1 { get => Localidad; set => Localidad = value; }
        public string Provincia1 { get => Provincia; set => Provincia = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email1 { get => Email; set => Email = value; }
        public bool Sexo1 { get => Sexo; set => Sexo = value; }
    }
}
