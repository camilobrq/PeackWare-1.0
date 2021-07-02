using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class ProductoService
    {
        private readonly ConnectionManager conexion;
        private readonly ProductoRepository repositorio;
        public ProductoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ProductoRepository(conexion);
        }
        public string Guardar(Producto producto)
        {
            try
            {
                conexion.Open();
                repositorio.Guardar(producto);
                return $"El proveedor ha sido Registrado Correctamente";

            }
            catch (Exception e)
            {

                return "Error" + e.Message;
            }
            finally { conexion.Close(); }
        }
        public ConsultaRespuesta3 Consultar()
        {
            try
            {
                conexion.Open();
                return new ConsultaRespuesta3(repositorio.ConsultarTodos());
            }
            catch (Exception e)
            {
                return new ConsultaRespuesta3("Error" + e.Message);
            }
            finally { conexion.Close(); }
        }
        public int ContarTodos()
        {
            try
            {
                conexion.Open();
                return repositorio.Totalizar();
            }
            catch
            {
                return 0;
            }
            finally { conexion.Close(); }



        }
    }
    public class ConsultaRespuesta3
    {
        public List<Producto> Productos { get; set; }

        public string Mensaje { get; set; }

        public bool Error { get; set; }
        public ConsultaRespuesta3(List<Producto> producto)
        {
            Productos = producto;
            Error = false;
        }

        public ConsultaRespuesta3(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
}
