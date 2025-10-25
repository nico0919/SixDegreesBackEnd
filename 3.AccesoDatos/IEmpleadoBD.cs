using _4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AccesoDatos
{
    public interface IEmpleadoBD
    {
        IEnumerable<MDEmpelado> ObtenerTodosEmpleados();
    }
}
