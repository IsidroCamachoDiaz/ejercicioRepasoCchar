﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Modelo
{
    public interface interfazEscritura
    {
        /*
         Recibe un texto que es la ruta y un boleano si desea sobreescribir o no y 
        devuelve el StreamWriter para usar
         */
        StreamWriter abrirFichero(string ruta,bool sobreEscribir);
        //Recibe el StreamWriter y el texto para escribirlo en el documento
        void escribir(StreamWriter sw,string texto);
        //Recibe el streamWriter para cerrarlo
        void cerrar(StreamWriter sw);
    }
}
