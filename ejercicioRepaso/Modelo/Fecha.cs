using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Modelo
{
    //El tipo fecha contiene los enteros de la fecha
    public class Fecha
    {
        //Atributos
        int dia;
        int mes;
        int anyo;
        public static int[] diasMaximosMes = { 0,31,29,31,30,31,30,31,31,30,31,30,31};
        //Constructores
        public Fecha(int dia, int mes, int anyo)
        {
            this.dia = dia;
            this.mes = mes;
            this.anyo = anyo;
        }
        //Geters y Seters
        public int Dia { get => dia;}
        public int Mes { get => mes; }
        public int Anyo { get => anyo; }
        //Propiedades
        //Devuelve un string con la fecha bien
        public string fechaTexto
        {
            get
            {
                return dia+"-"+mes+"-"+anyo;
            }
        }
    }
}
