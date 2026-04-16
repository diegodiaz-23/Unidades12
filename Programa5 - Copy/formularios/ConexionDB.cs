using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pjModular.formularios
{
    public static class ConexionDB
    {
        private static string cadena = "Server=127.0.0.1;Database=unidades12;Uid=root;Pwd=diego10;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
