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
    public class FacturaCompraRepository
    {
        private readonly SqlConnection _connection;
        public FacturaCompraRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public int Guardar(FacturaCompra facturaCompra)
        {
            using (var command = _connection.CreateCommand())
            {
          


        command.CommandText = @"Insert Into Proveedor (id_factura,id_persona,fecha,subtotal,total,)
                values (@IdFactura,@IdPersona,@Fecha, @Subtotal, @Total)";
                command.Parameters.Add("@IdFactura", SqlDbType.VarChar).Value = facturaCompra.IdFactura;
                command.Parameters.Add("@IdPersona", SqlDbType.VarChar).Value = facturaCompra.IdPersona;
                command.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = facturaCompra.Fecha;
                command.Parameters.Add("@Subtotal", SqlDbType.VarChar).Value = facturaCompra.Subtotal;
                command.Parameters.Add("@Total", SqlDbType.VarChar).Value = facturaCompra.Total;
                
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
       
    }
}
