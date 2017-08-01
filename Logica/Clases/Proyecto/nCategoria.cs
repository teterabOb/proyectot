using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Clases;
using System.Data.Sql;
using System.Data;

namespace Logica.Clases
{
    public class nCategoria
    {
        public int iIdcategoria { get; set; }
        public string Nombrecategoria { get; set; }
        public string Descripcion { get; set; }



        //public void crearCategoria()
        //{
        //    this.sql = string.Format(@"INSERT INTO categoria (nombrecategoria, descripcion) values ('{0}','{1}')", this.nombrecategoria, this.descripcion);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();

        //}

        //public void editarCategoria()
        //{
        //    this.sql = string.Format(@"UPDATE categoria SET nombrecategoria = '" + this.nombrecategoria + "', descripcion = '" + this.descripcion + "' where idcategoria = '" + this.idcategoria + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarCategoria()
        //{
        //    this.sql = string.Format(@"DELETE FROM categoria where idcategoria = '" + this.idcategoria + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

    }
}
