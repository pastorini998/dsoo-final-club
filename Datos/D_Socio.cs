using MySql.Data.MySqlClient;
using ClubDeportivo.Datos;
using System;
using System.Data; // Necesario para CommandType

namespace ClubDeportivo.Datos
{
    public class D_Socio
    {
        // El método ahora recibe los parámetros necesarios para el procedimiento
        public string InscribirSocioConSP(string nombre, string apellido, string tdoc, string doc)
        {
            string respuesta = "";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure; // 💡 Indicamos que es un procedimiento

                // Parámetros de ENTRADA (IN)
                comando.Parameters.Add("@Nom", MySqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("@Ape", MySqlDbType.VarChar).Value = apellido;
                comando.Parameters.Add("@Tip", MySqlDbType.VarChar).Value = tdoc;
                comando.Parameters.Add("@Doc", MySqlDbType.VarChar).Value = doc;

                // Parámetro de SALIDA (OUT)
                MySqlParameter pRta = new MySqlParameter("@rta", MySqlDbType.Int32);
                pRta.Direction = ParameterDirection.Output; // 💡 Indicamos que es de salida
                comando.Parameters.Add(pRta);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                // Leer el valor de retorno del procedimiento
                int nuevoSocioID = Convert.ToInt32(pRta.Value);

                if (nuevoSocioID > 0)
                {
                    respuesta = "OK|" + nuevoSocioID; // Retornamos OK y el ID
                }
                else
                {
                    // Asumimos que rta = -1 significa que ya existe
                    respuesta = "ERROR|El DNI/Documento ya se encuentra registrado.";
                }
            }
            catch (Exception ex)
            {
                respuesta = "ERROR|" + ex.Message;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open) sqlCon.Close();
            }
            return respuesta;
        }
    }
}