using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos.Clases;

namespace Logica.Clases
{
    public class nIngreso
    {
        public string fechaingreso { get; set; }
        public int idusuario { get; set; }
        Conexion con = new Conexion();
        SqlCommand query = new SqlCommand();

        public void insertarFecha2()
        {
            int uno = 1;
            DateTime fe = DateTime.Now;
            String sql = string.Format("INSERT INTO Ingreso (fechaingreso, idUsuario) values(@fecha, '{0}' )", uno);
            //SqlCommand query = new SqlCommand(sql, con);
            query.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = fe;
            //conn.Open();
            query.ExecuteNonQuery();
            //conn.Close();

        }
    }
}
