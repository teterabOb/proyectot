using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Clases;

namespace Logica.Clases
{
    public class nCargo : Conexion
    {
        public int Idcargo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //public int crearCargo()
        //{
        //    int res = 0;

        //    this.sql = string.Format(@"INSERT INTO cargo (nombre,descripcion) VALUES ('{0}','{1}')", this.nombre, this.descripcion);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();

        //    res = this.comandosql.ExecuteNonQuery();
        //    if (res > 0)
        //    {
        //        this.mensaje = "Cargo creado con exito";
        //    }
        //    else
        //    {
        //        this.mensaje = "Problemas al crear usuario";
        //    }

        //    this.conn.Close();
        //    return res;
        //}

        //public void editarCargo()
        //{
        //    this.sql = string.Format(@"UPDATE cargo SET nombre = '" + this.nombre + "', descripcion = '" + this.descripcion + "' where idcargo = '" + this.idcargo + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}


        //public void eliminarCargo()
        //{
        //    this.sql = string.Format(@"DELETE FROM cargo where idcargo= '" + this.idcargo + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}
    }
}
