using ejercicioRepaso.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Controladores
{
    public interface interfazRegistro
    {
        //Recibe la lista de empleados y crea el nuevo empleado en la lista
        void RegistroEmpleado(List <Empleado> empleados);
        //Recibe la lista de empleados y modifica sus datos
        void ModificarEmpleado(List<Empleado> empleados);
        //Recibe la lista de empleados y mete los datos en un archivo
        void ExportarEmpleado(List<Empleado> empleados);
    }
}
