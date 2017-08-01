using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Clases;
using System.Data;

namespace Logica.Clases
{
    public class nUsuario
    {
        public string user { get; set; }
        public string contrasena { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }
        public int idtipo { get; set; }
        public int id { get; set; }
        DatosSeguridad datos = new DatosSeguridad();   



        public int GetValidaUsuario(string usuario, string contrasena)
        {
            int res = 0;
            string[] parametros = {"@usuario","@pass"};

            DataTable dt = datos.getDatosTablaSeguridad("get_valida_usuario",
                                    parametros,
                                    usuario,contrasena);

            if(dt.Rows.Count > 0)
                res  = Convert.ToInt32(dt.Rows[0]["IDTIPOUSUARIO"].ToString());

            return res;
        }
        public int setEliminaUsuario(string usuario, string contrasena)
        {
            int res = 0;
            string[] parametros = { "@usuario", "@contrasena" };

            DataTable dt = datos.getDatosTablaSeguridad("get_valida_usuario",
                                    parametros,
                                    usuario, contrasena);

            if (dt.Rows.Count > 0)
                res = Convert.ToInt32(dt.Rows[0]["IDTIPOUSUARIO"].ToString());

            return res;
        }
        public int setEditaUsuario(string usuario, string contrasena)
        {
            int res = 0;
            string[] parametros = { "@usuario", "@contrasena" };

            DataTable dt = datos.getDatosTablaSeguridad("get_valida_usuario",
                                    parametros,
                                    usuario, contrasena);

            if (dt.Rows.Count > 0)
                res = Convert.ToInt32(dt.Rows[0]["IDTIPOUSUARIO"].ToString());

            return res;
        }
        public int setNuevoUsuario(string usuario, string contrasena)
        {
            int res = 0;
            string[] parametros = { "@usuario", "@contrasena" };

            DataTable dt = datos.getDatosTablaSeguridad("get_valida_usuario",
                                    parametros,
                                    usuario, contrasena);

            if (dt.Rows.Count > 0)
                res = Convert.ToInt32(dt.Rows[0]["IDTIPOUSUARIO"].ToString());

            return res;
        }
    }
}
