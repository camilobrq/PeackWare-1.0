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
    public class ClienteRepository
    {
        private readonly SqlConnection _connection;
        public ClienteRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Cliente Cliente)
        {
            using (var command = _connection.CreateCommand())
            { 
                command.CommandText = @"Insert Into Cliente (identificacion,nombre,sexo,edad,telefono,direccion)
                values (@Identificacion,@Nombre,@Sexo, @Edad, @Telefono,@Direccion)";
                command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = Cliente.Identificacion;
                command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Cliente.Nombre;
                command.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = Cliente.Sexo;
                command.Parameters.Add("@Edad", SqlDbType.VarChar).Value = Cliente.Edad;
                command.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Cliente.Telefono;
                command.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Cliente.Direccion;
                command.ExecuteNonQuery();

                
            }
        }

        public List<Cliente> ConsultarTodos()
        {
            SqlDataReader dataReader;
            List<Cliente> Clientes = new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Cliente ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToPerson(dataReader);
                        Clientes.Add(cliente);
                    }
                    dataReader.Close();
                }
            }
            return Clientes;
        }
        private Cliente DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Cliente cliente = new Cliente();
            cliente.Identificacion = (string)dataReader["Identificacion"];
            cliente.Nombre = (string)dataReader["Nombre"];
            cliente.Sexo = (string)dataReader["Sexo"];
            cliente.Edad = (string)dataReader["Edad"];
            cliente.Telefono = (string)dataReader["Telefono"];
            cliente.Direccion = (string)dataReader["Direccion"];
            return cliente;
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
