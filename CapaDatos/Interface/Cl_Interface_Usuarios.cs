using CapaDatos.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interface
{
    public class Cl_Interface_Usuarios
    {
        private Cl_ManagementSQL obj_sql = new Cl_ManagementSQL();

        public DataTable GetUsuarios()
        {
            string sql = "SELECT * FROM listar_usuarios();";
            return obj_sql.ExecuteSQLQuery(sql);
        }
        public void InsertarUsuario(string nombreUsuario, string contrasena, bool esAdmin)
        {
            try
            {
                string sql =
            "SELECT crear_usuario(" +
            "'" + nombreUsuario + "', " +
            "'" + contrasena + "', " +
            esAdmin +
            ");";
                obj_sql.ExecuteSQLQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
