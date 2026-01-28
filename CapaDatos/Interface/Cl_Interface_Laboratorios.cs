using CapaDatos.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interface
{
    public class Cl_Interface_Laboratorios
    {
        private Cl_ManagementSQL obj_sql = new Cl_ManagementSQL();

        public DataTable GetLaboratorios()
        {
            string sql = "SELECT * FROM listar_laboratorios();";
            return obj_sql.ExecuteSQLQuery(sql);
        }
    }
}
