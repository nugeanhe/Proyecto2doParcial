using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interface;


namespace CapaLogicaNegocio.Modelos
{
    public class Cl_Usuario
    {
        public int CuentaId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public bool EsAdmin { get; set; }

        public Cl_Usuario()
        {
            CuentaId = -1;
            NombreUsuario = string.Empty;
            Contrasena = string.Empty;
            EsAdmin = false;

        }
        public Cl_Usuario(int cuentaId, string nombreUsuario, string contrasena)
        {
            CuentaId = cuentaId;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            EsAdmin = false;
        }
        public Cl_Usuario(int cuentaId, string nombreUsuario, string contrasena, bool esAdmin)
        {
            CuentaId = cuentaId;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            EsAdmin = esAdmin;
        }
        public Cl_Usuario(int cuentaId, string nombreUsuario, bool esAdmin)
        {
            CuentaId = cuentaId;
            NombreUsuario = nombreUsuario;
            Contrasena = string.Empty;
            EsAdmin = esAdmin;
        }
        public override string ToString()
        {
            return $"ID: {CuentaId}, Usuario: {NombreUsuario}, Admin: {EsAdmin}";
        }
    }
}
