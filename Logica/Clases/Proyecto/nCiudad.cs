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
    public class nCiudad
    {
        public int Idciudad { get; set; }
        public string Nombre { get; set; }
        public int Idregion { get; set; }



        //public void crearCiudad()
        //{
        //    this.sql = string.Format(@"INSERT INTO ciudad (idciudad,nombre,idregion) VALUES ('{0}','{1}','{2}')", this.idciudad, this.nombre, this.idregion);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();

        //}

        //public void editarCiudad()
        //{
        //    this.sql = string.Format(@"UPDATE ciudad SET nombre = '" + this.nombre + "', idregion = '" + this.idregion + "' where idciudad = '" + this.Idciudad + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarCiudad()
        //{
        //    this.sql = string.Format(@"DELETE FROM ciudad where idciudad = '" + this.idciudad + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}
    }
}
