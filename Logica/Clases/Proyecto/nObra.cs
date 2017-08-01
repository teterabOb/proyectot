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
    public class nObra
    {
        public int Idobra { get; set; }
        public string Nombreobra { get; set; }
        public string Direccion { get; set; }
        public int Idcomuna { get; set; }


        //public void crearObra()
        //{
        //    this.sql = string.Format(@"INSERT INTO obra (nombreobra,direccion,idcomuna) VALUES ('{0}','{1}','{2}')", this.nombreobra, this.direccion, this.idcomuna);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void editarObra()
        //{
        //    this.sql = string.Format(@"UPDATE obra SET nombreobra = '" + this.nombreobra + "', direccion = '" + this.direccion + "', idcomuna = '" + this.idcomuna + "' where idobra = '" + this.idobra + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarObra()
        //{
        //    this.sql = string.Format(@"DELETE FROM obra where idobra = '" + this.idobra + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}
    }
}
