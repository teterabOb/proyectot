using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos.Clases
{
    public class Conexion 
    {
        //public class cConexion
        private SqlConnection con { get; set; }
        private string cadenaConexion()
        {
            return (@"Data Source =DESKTOP-AA9RM3O; Initial Catalog = PROYECTOT; Integrated security=true");
        }
        public SqlConnection getConexion()
        {
            try
            {
                con = new SqlConnection(cadenaConexion());
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
