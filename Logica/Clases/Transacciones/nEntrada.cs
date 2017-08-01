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
    public class nEntrada
    {
        public int identrada { get; set; }
        public DateTime fechaentrada { get; set; }
        public string comentario { get; set; }
        public string idruta { get; set; }

        //public void registrarEntrada()
        //{
        //    this.sql = string.Format(@"INSERT INTO REGISTROENTRADA (fechaentrada,idruta,comentario) values ('{0}','{1}','{2}')", this.fechaentrada, this.idruta, this.comentario);
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    this.conn.Open();
        //    this.comandosql.ExecuteNonQuery();
        //    this.conn.Close();

        //}
    }
}
