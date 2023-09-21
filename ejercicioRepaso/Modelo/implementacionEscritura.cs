using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Modelo
{
    public class implementacionEscritura : interfazEscritura
    {
        StreamWriter interfazEscritura.abrirFichero(string ruta, bool sobreEscribir)
        {
            //Se pone al null
            StreamWriter sw=null;
            try
            {
                //Se le pone los valores
                sw = new StreamWriter(ruta,sobreEscribir);
                //Cabecera
                sw.WriteLine("Nombre;Apellidos;DNI;Fecha de Nacimiento;Titulacion Mas Alta");
                //Excepciones
            }catch(Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            return sw;
        }

        void interfazEscritura.cerrar(StreamWriter sw)
        {
            //Lo cierra
            sw.Close();
        }

        void interfazEscritura.escribir(StreamWriter sw, string texto)
        {
            //Ecribe el texto
            sw.WriteLine(texto);
        }
    }
}
