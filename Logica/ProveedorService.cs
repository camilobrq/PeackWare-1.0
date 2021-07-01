using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
namespace Logica
{
    public class ProveedorService
    {
        private readonly ConnectionManager conexion;
        private readonly ProveedorRepository repositorio;
        public ProveedorService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ProveedorRepository(conexion);
        }
        public string Guardar(Proveedor proveedor)
        {
            try {
                conexion.Open();
                repositorio.Guardar(proveedor);
                return $"El proveedor ha sido Registrado Correctamente";
            
            } catch(Exception e) {

                return "Error" + e.Message;
            }
            finally { conexion.Close(); }
        }
    }
    public class ConsultaRespuesta
    {
        public List<Proveedor> proveedors { get; set; }

        public string Mensaje { get; set; }

        public bool Error { get; set; }
        public ConsultaRespuesta(List<Proveedor> proveedor)
        {
            proveedors = proveedor;
            Error = false;
        }

        public ConsultaRespuesta(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }

}
