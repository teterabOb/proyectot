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
    public class nSubCategoria
    {
        public int Idsub { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Idcategoria { get; set; }
            }
}
