using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Acceso_Datos
{
    public abstract class Conexcion_a_BaseDatos
    {
        private readonly string conection;

        public Conexcion_a_BaseDatos() {
            conection = "server=localhost;user=root;database=biblioteca;password=root";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(conection);
        }
    }
}
