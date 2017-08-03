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

    }
}
