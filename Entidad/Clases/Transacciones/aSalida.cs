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

    }
}
