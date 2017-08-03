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
    }
}
