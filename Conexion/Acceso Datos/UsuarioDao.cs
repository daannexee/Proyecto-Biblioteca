using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Acceso_Datos
{
    internal class UsuarioDao : Conexcion_a_BaseDatos
    {
        public bool Login(string Numero_Identificacion, string Contraseña) 
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = conection;
                    command.CommandText = "SELECT COUNT(*) FROM usuarios WHERE Numero_Identificacion = @Numero_Identificacion AND Contraseña = @Contraseña";
                    command.Parameters.AddWithValue("@Numero_Identificacion", Numero_Identificacion);
                    command.Parameters.AddWithValue("@Contraseña", Contraseña);
                    command.CommandType = System.Data.CommandType.Text;                   

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
