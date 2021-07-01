using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Datos
{
    public class ProveedorRepository
    {
        private readonly SqlConnection _connection;
        public ProveedorRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(Proveedor proveedor)
        {
            using (var command = _connection.CreateCommand())
            {
                /* public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
                public string NombreEmpresa { get; set; }
        public string  Pais { get; set; }*/

                command.CommandText = @"Insert Into Proveedor (Identificacion,Nombre,Sexo,Edad,Telefono,Direccion,NombreEmpresa,Pais)
                values (@Identificacion,@Nombre,@Sexo, @Edad, @Telefono,@Direccion,@NombreEmpresa,@Pais)";
                command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = proveedor.Identificacion;
                command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = proveedor.Nombre;
                command.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = proveedor.Sexo;
                command.Parameters.Add("@Edad", SqlDbType.VarChar).Value = proveedor.Edad;
                command.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = proveedor.Telefono;
                command.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = proveedor.Direccion;
                command.Parameters.Add("@NombreEmpresa", SqlDbType.VarChar).Value = proveedor.NombreEmpresa;
                command.Parameters.Add("@Pais", SqlDbType.VarChar).Value = proveedor.Pais;

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
    }
}
