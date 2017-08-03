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
    public class nObra
    {
        public int Idobra { get; set; }
        public string Nombreobra { get; set; }
        public string Direccion { get; set; }
        public int Idcomuna { get; set; }

    }
}
