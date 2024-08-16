using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Manager
{
    public class ArticulosVentasManager
    {
        public void AgregarArticuloVenta(ArticulosVentas nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("INSERT INTO ArticulosVentas (IdArticulo, IdVenta) VALUES (@IdArticulo, @IdVenta)");
                datos.SetearParametro("@IdArticulo", nuevo.IdArticulo);
                datos.SetearParametro("@IdVenta", nuevo.IdVenta);
                datos.ejecutarAccion();
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
