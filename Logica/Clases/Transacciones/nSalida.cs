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
    public class nSalida
    {
        public int idsalida { get; set; }
        public DateTime fechasalida { get; set; }
        public string idruta { get; set; }
        public string comentario { get; set; }

        //public void registrarSalida()
        //{
        //    this.sql = string.Format(@"INSERT INTO REGISTROSALIDA (fechasalida,idruta,comentario) values ('{0}','{1}','{2}')", this.fechasalida, this.idruta, this.comentario);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();

        //}

    }
}
