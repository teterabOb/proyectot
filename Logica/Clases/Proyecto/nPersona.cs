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
    public class nPersona
    {
        public string Rut { get; set; }
        public string Primernombre { get; set; }
        public string Apellidopaterno { get; set; }
        public string Apellidomaterno { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Idcomuna { get; set; }
        public int Idcargo { get; set; }


        //public void crearPersonal()
        //{
        //    this.sql = string.Format(@"INSERT INTO personal (rut,primernombre,apellidopaterno,apellidomaterno,telefono,direccion, idcomuna, idcargo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", this.rut, this.primernombre, this.apellidopaterno, this.apellidomaterno
        //                                                                                                        , this.telefono, this.direccion, this.idcomuna, this.idcargo);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();

        //}

        //public void editarPersonal()
        //{
        //    this.sql = string.Format(@"UPDATE personal SET primernombre = '" + this.primernombre + "', idsubcategoria = '" + this.apellidopaterno + "', idmaterial = '" + this.apellidomaterno + "', telefono  = '" + this.telefono + "', direccion = '" + this.direccion + "', idmcomuna = '" + this.idcomuna + "', idcargo = '" + this.idcargo + "' where rut = '" + this.rut + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}

        //public void eliminarPersonal()
        //{
        //    this.sql = string.Format(@"DELETE FROM personal where rut = '" + this.rut + "'");
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();
        //}
    }
}
