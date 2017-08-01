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
    public class nModelo
    {
        public int Idmodelo {get;set;}
        public string Nombre { get; set; }
        public int Idmarca { get; set; }


        //public void crearModelo()
        //{
        //    this.sql = string.Format(@"INSERT INTO modelo (nombre,idmarca) values ('{0}','{1}')", this.nombre, this.idmarca);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();

        //}

        //public void editarModelo()
        //{
        //    this.sql = string.Format(@"UPDATE modelo SET nombre = '" + this.nombre + "' , idmarca = '" + this.idmarca + "' where idmodelo = '" + this.idmodelo + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarModelo()
        //{
        //    this.sql = string.Format(@"DELETE FROM modelo where idmodelo = '" + this.idmodelo + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}
    }
}
