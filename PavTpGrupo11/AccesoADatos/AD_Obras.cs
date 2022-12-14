using PavTpGrupo11.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Obras
    {
        ConexionSQL cn = new ConexionSQL();
        public static DataTable ConsultarObrasDG()
        {
            return ConexionSQL.ConsultarObrasDG();
        }

        public int InsertarObra(Obra ob)
        {
            return cn.InsertarObra(ob);
        }
        public int ModificarObra(Obra ob)
        {
            return cn.InsertarObra(ob);
        }
        public static DataTable ObtenerObraxCod(int cod)
        {
            return ConexionSQL.ObtenerObraxCod(cod);
        }
        public static DataTable ObtenerObraxIdBarrio(int id)
        {
            return ConexionSQL.ObtenerObraxIdBarrio(id);
        }
        public static DataTable ObtenerEstadisticasObrasXbarrio()
        {
            return ConexionSQL.ObtenerEstadisticasObrasXbarrio();
        }
    }

 
}
