using System;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;

        private Conexion()
        {
            this.baseDatos = "ClubDeportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";

           
            this.clave = Environment.GetEnvironmentVariable("DB_PASSWORD");
        }

        public MySqlConnection CrearConcexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                         ";port=" + this.puerto +
                                         ";username=" + this.usuario +
                                         ";password=" + this.clave +
                                         ";Database=" + this.baseDatos;
            }
            
            catch (Exception ex)
            {
                cadena = null;

                
                Console.WriteLine("Error al crear la conexión a la base de datos: " + ex.Message);
       
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}


