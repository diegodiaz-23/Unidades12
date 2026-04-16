using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace RegistroLibrosGUI3
{
    public static class ConexionBD
    {
        private static string cadena = "Server=127.0.0.1;Database=unidades12;Uid=root;Pwd=diego10;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
