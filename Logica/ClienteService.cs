using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
namespace Logica
{
   public class ClienteService
    {

        private readonly ConnectionManager conexion;
        private readonly ClienteRepository repositorio;
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);
        }
        public string Guardar(Cliente cliente)
        {
            try
            {
                conexion.Open();
                repositorio.Guardar(cliente);
                return $"El proveedor ha sido Registrado Correctamente";

            }
            catch (Exception e)
            {

                return "Error" + e.Message;
            }
            finally { conexion.Close(); }
        }
        public ConsultaRespuesta2 Consultar()
        {
            try
            {
                conexion.Open();
                return new ConsultaRespuesta2(repositorio.ConsultarTodos());
            }
            catch (Exception e)
            {
                return new ConsultaRespuesta2("Error" + e.Message);
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
        public int ContarMasculinos()
        {
            try
            {
                conexion.Open();
                return repositorio.TotalizarMasculino();
            }
            catch
            {
                return 0;
            }
            finally { conexion.Close(); }



        }
        public int ContarFemeninos()
        {
            try
            {
                conexion.Open();
                return repositorio.TotalizarFemenino();
            }
            catch
            {
                return 0;
            }
            finally { conexion.Close(); }



        }


    }
    }
   
   

    public class ConsultaRespuesta2
    {
        public List<Cliente> clientes { get; set; }

        public string Mensaje { get; set; }

        public bool Error { get; set; }
        public ConsultaRespuesta2(List<Cliente> cliente)
        {
            clientes = cliente;
            Error = false;
        }

        public ConsultaRespuesta2(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }

