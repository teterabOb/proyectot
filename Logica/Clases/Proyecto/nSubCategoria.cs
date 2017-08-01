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
    public class nSubCategoria
    {
        public int Idsub { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Idcategoria { get; set; }
        Conexion conn = new Conexion();
        string sql;
        SqlCommand comandosql = new SqlCommand();


        //public void crearSubCategoria()
        //{
        //    this.sql = string.Format(@"INSERT INTO subcategoria (nombre,descripcion,idcategoria) values ('{0}','{1}','{2}')", this.nombre, this.descripcion, this.idcategoria);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void editarSubCategoria()
        //{
        //    this.sql = string.Format(@"UPDATE subcategoria SET nombre = '" + this.nombre + "', descripcion = '" + this.descripcion + "', idcategoria = '" + this.idcategoria + "' where idsubcategoria = '" + this.idsub + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarSubcategoria()
        //{
        //    this.sql = string.Format(@"DELETE FROM subcategoria where idsubcategoria = '" + this.idsub + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}
    }
}
