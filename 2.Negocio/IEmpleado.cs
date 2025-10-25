using _4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Negocio
{
    public interface IEmpleado
    {
        IEnumerable<MDEmpelado> ObtenerTodosEmpleados();
    }
}
