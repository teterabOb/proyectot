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
    public class nMaterial
    {
        public int Idmaterial { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdSubcategoria { get; set; }




        //public void crearMaterial()
        //{
        //    this.sql = string.Format(@"INSERT INTO material (nombre,descripcion,idsubcategoria) VALUES ('{0}','{1}','{2}')", this.nombre, this.descripcion, this.idsubcategoria);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();

        //}

        //public void editarMaterial()
        //{
        //    this.sql = string.Format(@"UPDATE material SET nombre = '" + this.nombre + "', descripcion = '" + this.descripcion + "', idsubcategoria = '" + this.idsubcategoria + "' where idmaterial = '" + this.idmaterial + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarMaterial()
        //{
        //    this.sql = string.Format(@"DELETE FROM material where idmaterial = '" + this.idmaterial + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public bool materialExistente()
        //{
        //    bool resultado = false;
        //    this.sql = string.Format(@"SELECT * FROM material WHERE idmaterial ='{0}'", this.idmaterial);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    SqlDataReader Reg = null;
        //    Reg = this.comandosql.ExecuteReader();
        //    if (Reg.Read() == true)
        //    {
        //        resultado = true;
        //    }
        //    this.conn.Close();
        //    return resultado;

        //}
    }
}
