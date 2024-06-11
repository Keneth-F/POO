using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Persona
    {
        //esta compuesta por:

        // 1. PROPIEDADES o ATRIBUTOS:
        private string cedula;
        private string nombre;
        private double edad;
        public Persona()
        {

        }

        public Persona(string cedula, string nombre, double edad)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.edad = edad;
        }
        /// <summary>
        /// get nombre
        /// </summary>
        /// <returns>string</returns>
        public string GetNombre() => nombre;
        /// <summary>
        /// get cedula
        /// </summary>
        /// <returns>string</returns>
        public string GetCedula() => cedula;
        /// <summary>
        /// get edad
        /// </summary>
        /// <returns>double</returns>
        public double GetEdad() => edad;
        /// <summary>
        /// asigna valor a Cedula
        /// </summary>
        /// <param name="cedula"></param>
        public void SetCedula(string cedula) => this.cedula = cedula;
        /// <summary>
        /// asigna valor a Cedula
        /// </summary>
        /// <param name="nombre"></param>
        public void SetNombre(string nombre) => this.nombre = nombre;
        /// <summary>
        /// asigna valor a edad
        /// </summary>
        /// <param name="edad"></param>
        public void SetEdad(double edad) => this.edad = edad;
    }
}
