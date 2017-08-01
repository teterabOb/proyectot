using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Clases
{
    public class DatosSeguridad
    {
        Conexion con = new Conexion();
        ConexionSeguridad cons = new ConexionSeguridad();

        public DataTable getDatosTablaSeguridad(string nomprocedimiento, string[] nomparametros, params Object[] valparams)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = this.cons.getConexionSeguridad();
            cmd.CommandText = nomprocedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            int i = 0;
            if (nomprocedimiento.Length != 0 && nomparametros.Length == valparams.Length)
                foreach (string parametro in nomparametros)
                    cmd.Parameters.AddWithValue(parametro, valparams[i++]);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception)
            {

            }

            return dt;
        }
        public int EjecutarSPSeguridad(string nomprocedimiento, string[] nomparametros, params Object[] valparams)
        {            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.cons.getConexionSeguridad();
            cmd.CommandText = nomprocedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            int i = 0;
            if (nomprocedimiento.Length != 0 && nomparametros.Length == valparams.Length)
                foreach (string parametro in nomparametros)
                    cmd.Parameters.AddWithValue(parametro, valparams[i++]);

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {


            }
            return 0;

        }
    }
}
