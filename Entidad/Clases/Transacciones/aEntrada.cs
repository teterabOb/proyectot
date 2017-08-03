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


    }
}
