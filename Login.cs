using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credi_Pisto
{
    class Login
    {

       public static DataTable Consulta()
        {
            
            SqlDataAdapter sqlDta = new SqlDataAdapter();
            SqlConnection sqlConexion = new SqlConnection();
            DataTable tablaConsulta = new DataTable("usuario");
            SqlCommand sqlCmd = new SqlCommand();
            DataSet ds = new DataSet();
            try
            {
                Conexion.Conex();
                sqlCmd.CommandTimeout = 0;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "sp_usuario";

                sqlCmd.Parameters.AddWithValue("@Opcion", 5);
                
                sqlDta.SelectCommand = sqlCmd;
                sqlDta.Fill(tablaConsulta);
                sqlConexion.Close();
                ;
            }
            catch (Exception)
            {


            }
            sqlDta.Dispose();
            sqlCmd.Dispose();

            return tablaConsulta;

        }

        
        
    }
}
