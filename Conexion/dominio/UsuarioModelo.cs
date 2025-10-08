using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos;

namespace dominio
{
    public class UsuarioModelo : Conexcion_a_BaseDatos
    {
        private readonly UsuarioModelo usuarioDao = new UsuarioModelo();
        public bool LoginUsuario(string Numero_Identificacion, string Contraseña)
        {
            return usuarioDao.LoginUsuario(Numero_Identificacion, Contraseña);
        }
    }
}
