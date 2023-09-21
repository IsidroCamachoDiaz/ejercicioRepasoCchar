using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Modelo
{
    /// <summary>
    /// El tipo empleado donde se guardan sus datos 
    /// </summary>
    public class Empleado
    {
       //Atributos
        string nombre;
        string apellidos;
        string dni;
        Fecha fechaNacimiento;
        string titulacionMasAlta;
        int numSeguridadSocial;
        int numCuenta;
        int numeroEmpleado;
        //Constructores
        public Empleado(string nombre, string apellidos, string dni, Fecha fechaNacimiento, string titulacionMasAlta, int numSeguridadSocial, int numCuenta,int numeroEmpleado)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.titulacionMasAlta = titulacionMasAlta;
            this.numSeguridadSocial = numSeguridadSocial;
            this.numCuenta = numCuenta;
            this.numeroEmpleado = numeroEmpleado;
        }
        //Geters y Seters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni;}
        public Fecha FechaNacimiento { get => fechaNacimiento; }
        public string TitulacionMasAlta { get => titulacionMasAlta; set => titulacionMasAlta = value; }
        private int NumSeguridadSocial { get => numSeguridadSocial; }
        private int NumCuenta { get => numCuenta;}
        public int NumeroEmpleado { get => numeroEmpleado; }
        //Propiedades
        //Los valores para pasar al archivo
        public string TextoArchivo { get
            {
                return Nombre+";"+Apellidos+";"+Dni+";"+FechaNacimiento.fechaTexto+";"+TitulacionMasAlta;
            } 
        }


    }
}
