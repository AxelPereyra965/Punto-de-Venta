using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Manager
{
    public class VentaManager
    {
        public List<Venta> listar()
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT Id, FechaVenta, Total FROM Ventas");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Venta aux = new Venta();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.FechaVenta = (DateTime)datos.Lector["FechaVenta"];
                    aux.Total = (int)datos.Lector["Total"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConeccion();
            }
        }

        public void Agregar(Venta nuevaVenta)
        {
            AccesoDatos datos = new AccesoDatos();
            try 
            {
                // Corregir la consulta SQL
                datos.SetearConsulta("INSERT INTO Ventas(FechaVenta, Total) VALUES (@FechaVenta, @Total)");
                datos.SetearParametro("@FechaVenta", nuevaVenta.FechaVenta);
                datos.SetearParametro("@Total", nuevaVenta.Total);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw ex;
            }
            finally
            {
                // Asegúrate de cerrar la conexión en el bloque finally
                datos.CerrarConeccion();
            }
        }

        public int ObtenerUltimoID()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT ISNULL(MAX(Id), 0) AS UltimoId FROM VENTAS");
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    return (int)datos.Lector["UltimoId"];
                }
                else
                {
                    return 0; // Si no hay registros, retorna 0
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConeccion();
            }
        }
    }
}
