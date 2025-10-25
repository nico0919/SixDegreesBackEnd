using _4.Entidades;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace _3.AccesoDatos
{
        public class EmpleadoBD : IEmpleadoBD
        {
            private readonly IConfiguration _configuration;
            private readonly string _connectionString;

            public EmpleadoBD(IConfiguration configuration)
            {
                _configuration = configuration;
                _connectionString = _configuration.GetConnectionString("DefaultConnection")!;
            }

            private IDbConnection Conexion => new SqlConnection(_connectionString);

            public IEnumerable<MDEmpelado> ObtenerTodosEmpleados()
            {
                using var db = Conexion;
                return db.Query<MDEmpelado>("SELECT * FROM Empleados");
            }

        }
}
