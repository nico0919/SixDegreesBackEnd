using _3.AccesoDatos;
using _4.Entidades;

namespace _2.Negocio
{
    public class Empleado : IEmpleado
    {
        private readonly IEmpleadoBD _empleadoBD;

        public Empleado(IEmpleadoBD empleadoBD)
        {
            _empleadoBD = empleadoBD;
        }

        public IEnumerable<MDEmpelado> ObtenerTodosEmpleados() => _empleadoBD.ObtenerTodosEmpleados();

    }
}
