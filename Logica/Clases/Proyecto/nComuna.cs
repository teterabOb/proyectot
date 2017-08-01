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
    public class nComuna
    {
        public int Idcomuna { get; set; }
        public string Nombre { get; set; }
        public int Idciudad { get; set; }
        Conexion con = new Conexion();
        SqlCommand cmd = new SqlCommand();



        //public void crearComuna()
        //{
        //    this.sql = string.Format(@"INSERT INTO comuna (nombre,idciudad) VALUES ('{0}','{1}')", this.nombre, this.Idciudad);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void editarComuna()
        //{
        //    this.sql = string.Format(@"UPDATE comuna SET nombrecomuna = '" + this.nombre + "', idciudad = '" + this.idciudad + "' where idcomuna = '" + this.idcomuna + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarComuna()
        //{
        //    this.sql = string.Format(@"DELETE FROM comuna where idcomuna = '" + this.idcomuna + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

    }
}
