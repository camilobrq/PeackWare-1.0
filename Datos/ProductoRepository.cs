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
    public class ProductoRepository
    {
        private readonly SqlConnection _connection;
        public ProductoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public int Guardar(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {

        

                command.CommandText = @"Insert Into Producto (CodigoProducto,NombreProducto,PrecioUnidad,Cantidad,Descuento,Descripcion,porcentajeIva)
                values (@CodigoProducto,@NombreProducto,@PrecioUnidad, @Cantidad, @Descuento,@Descripcion,@porcentajeIva)";
                command.Parameters.Add("@CodigoProducto", SqlDbType.VarChar).Value = producto.CodigoProducto;
                command.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = producto.NombreProducto;
                command.Parameters.Add("@PrecioUnidad", SqlDbType.VarChar).Value = producto.PrecioUnidad;
                command.Parameters.Add("@Cantidad", SqlDbType.VarChar).Value = 0;
                command.Parameters.Add("@Descuento", SqlDbType.VarChar).Value = producto.Descuento;
                command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = producto.Descripcion;
                command.Parameters.Add("@porcentajeIva", SqlDbType.VarChar).Value = 1.19;

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public List<Producto> ConsultarTodos()
        {
            SqlDataReader dataReader;
            List<Producto> Productos = new List<Producto>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select CodigoProducto,NombreProducto,descripcion from producto ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToPerson(dataReader);
                        Productos.Add(producto);
                    }
                    dataReader.Close();
                }
            }
            return Productos;
        }
        private Producto DataReaderMapToPerson(SqlDataReader dataReader)
        {
      
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto();
            producto.CodigoProducto = (string)dataReader["CodigoProducto"];
            producto.NombreProducto = (string)dataReader["NombreProducto"];
           
            producto.Descripcion = (string)dataReader["descripcion"];
          
          
            return producto;
        }
        public int Totalizar()
        {

            return ConsultarTodos().Count();
        }
    }
}
