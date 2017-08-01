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
    public class nMarca
    {
        public int iIdmarca { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }


        //public void crearMarca()
        //{
        //    this.sql = string.Format(@"INSERT INTO marca (nombre,telefono,direccion) values ('{0}','{1}','{2}')", this.nombre, this.telefono, this.direccion);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();

        //}

        //public void editarMarca()
        //{
        //    this.sql = string.Format(@"UPDATE marca SET nombre = '" + this.nombre + "' ,telefono = '" + this.telefono + "',direccion = '" + this.direccion + "' where idmarca = '" + this.idmarca + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarMarca()
        //{
        //    this.sql = string.Format(@"DELETE FROM marca where idmarca = '" + this.idmarca + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public bool marcaExistente()
        //{
        //    bool resultado = false;
        //    this.sql = string.Format(@"SELECT * FROM marca WHERE idmarca ='{0}'", this.idmarca);
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
