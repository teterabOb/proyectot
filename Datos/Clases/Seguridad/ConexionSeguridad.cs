using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos.Clases
{
    class ConexionSeguridad
    {
        private SqlConnection con { get; set; }
        private string cadenaConexionSeguridad()
        {
            return (@"Data Source =.; Initial Catalog = Seguridad; Integrated security=true");
        }
        public SqlConnection getConexionSeguridad()
        {
            try
            {
                con = new SqlConnection(cadenaConexionSeguridad());
                this.con.Open();
                return this.con;

            }
            catch (Exception)
            {
                return null;

            }
        }
    }
}
