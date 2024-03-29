﻿using System;
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
        public ConsultaRespuesta ConsultarPorId(string id)
        {
          
            
            try
            {

                conexion.Open();
                return new ConsultaRespuesta (repositorio.BuscarPorIdentificacion(id));
               
               
            }
            catch (Exception e)
            {


                return new ConsultaRespuesta( $"Error de la Aplicacion: {e.Message}");
                
            }
            finally { conexion.Close(); }
        }
        public ConsultaRespuesta Consultar()
        {
            try
            {
                conexion.Open();
                return new ConsultaRespuesta(repositorio.ConsultarTodos());
            }
            catch (Exception e)
            {
                return new ConsultaRespuesta("Error" + e.Message);
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
    public class ConsultaIdRespuesta
    {
        public Proveedor proveedor { get; set; }

        public string Mensaje { get; set; }

        public bool Error { get; set; }
        

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
