using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Clases;
using System.Data.SqlClient;
using System.Data;



namespace Logica.Clases
{
    public class nCamion
    {
        
        public int Idcamion { get; set; }
        public string Patente { get; set; }
        public int Idmodelo { get; set; }

        public int setNuevoCamion(nCamion camion)
        {
            DatosSistema datos = new DatosSistema();
            string[] parametros = {"@id_camion",
                                  "@patente",
                                  "@idmodelo"};
            return datos.Ejecutar("nombre_sp",
                parametros, "I",
                camion.Idcamion,
                camion.Patente,
                camion.Idmodelo);

        }
        public int setEliminarCamion(nCamion camion)
        {
            DatosSistema datos = new DatosSistema();
            string[] parametros = {"@id_camion",
                                  "@patente",
                                  "@idmodelo"};
            return datos.Ejecutar("nombre_sp",
                parametros, "I",
                camion.Idcamion,
                camion.Patente,
                camion.Idmodelo);

        }
        public int setEditarCamion(nCamion camion)
        {
            DatosSistema datos = new DatosSistema();
            string[] parametros = {"@id_camion",
                                  "@patente",
                                  "@idmodelo"};
            return datos.Ejecutar("nombre_sp",
                parametros, "I",
                camion.Idcamion,
                camion.Patente,
                camion.Idmodelo);

        }
    }
}
