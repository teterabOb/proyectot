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
    public class nRegion
    {
        public int Idregion { get; set; }
        public string Nombre { get; set; }



        //public int crearRegion()
        //{
        //    int res = 0;

        //    this.sql = string.Format(@"INSERT INTO region (idregion,nombreregion) VALUES ('{0}','{1}')", this.idregion, this.nombre);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();

        //    res = this.comandosql.ExecuteNonQuery();
        //    if (res > 0)
        //    {
        //        this.mensaje = "Region creada con exito";
        //    }
        //    else
        //    {
        //        this.mensaje = "Problemas al ingresar region";
        //    }

        //    this.conn.Close();
        //    return res;
        //}

        //public void editarRegion()
        //{
        //    this.sql = string.Format(@"UPDATE region SET nombreregion = '" + this.nombre + "' where idregion = '" + this.idregion + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarRegion()
        //{
        //    this.sql = string.Format(@"DELETE FROM region where idregion = '" + this.idregion + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}
    }
}
