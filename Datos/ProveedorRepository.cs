using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

  
        public List<Proveedor> BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            List<Proveedor> Proveedores = new List<Proveedor>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select* from Proveedor where Identificacion==Identificacion";

                command.Parameters.AddWithValue(":Identificacion", identificacion);
                dataReader = command.ExecuteReader();
              ;
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Proveedor proveedor = DataReaderMapToPerson(dataReader);
                        Proveedores.Add(proveedor);
                    }
                    dataReader.Close();
                }
             
                return Proveedores;
            }
        }
      
        public List<Proveedor> ConsultarTodos()
        {
            SqlDataReader dataReader;
            List<Proveedor> Proveedores = new List<Proveedor>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Proveedor ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Proveedor proveedor = DataReaderMapToPerson(dataReader);
                        Proveedores.Add(proveedor);
                    }
                    dataReader.Close();
                }
            }
            return Proveedores;
        }
        private Proveedor DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Proveedor proveedor = new Proveedor();
            proveedor.Identificacion = (string)dataReader["Identificacion"];
            proveedor.Nombre = (string)dataReader["Nombre"];
            proveedor.Sexo = (string)dataReader["Sexo"];
            proveedor.Edad = (string)dataReader["Edad"];
            proveedor.Telefono = (string)dataReader["Telefono"];
            proveedor.Direccion = (string)dataReader["Direccion"];
            proveedor.NombreEmpresa= (string)dataReader["NombreEmpresa"];
            proveedor.Pais = (string)dataReader["Pais"];
            return proveedor;
        }
        public int Totalizar()
        {

            return ConsultarTodos().Count();
        }
        public int TotalizarMasculino()
        {

            return ConsultarTodos().Where(p => p.Sexo.Equals("M")).Count();
        }
        public int TotalizarFemenino()
        {
            return ConsultarTodos().Where(p => p.Sexo.Equals("F")).Count();
        }
     
    }
}
