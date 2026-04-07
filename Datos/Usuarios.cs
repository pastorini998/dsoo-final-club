using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClubDeportivo.Datos
{
    internal class Usuarios
    {
       
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; 
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_NombreUsu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("p_PassUsu", MySqlDbType.VarChar).Value = P_Usu;
                
                sqlCon.Open();
                resultado = comando.ExecuteReader(); 
                tabla.Load(resultado); 
                return tabla;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la base de datos.", ex);
            }

           
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
        }
    }
}
