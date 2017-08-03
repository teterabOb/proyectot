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
    public class nRuta
    {
        public string Idruta { get; set; }
        public string Nombreruta { get; set; }
        public string Fechacreacion { get; set; }
        public int Idpersonal { get; set; }
        public int Idcamion { get; set; }
        public int Idestado { get; set; }
        public int Idobra { get; set; }
        public int Idsubcategoria { get; set; }
        public string Descripcion { get; set; }
        public byte[] ImagenCodigo { get; set; }       

    }
}
