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
    public class nMaterial
    {
        public int Idmaterial { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdSubcategoria { get; set; }


    }
}
