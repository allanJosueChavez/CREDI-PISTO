using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credi_Pisto
{
    class Conexion
    {
        SqlConnection cn;
        public static SqlConnection Conex()
        {
           
                SqlConnection cn = new SqlConnection("Data Source = ICONC220\\SQLEXPRESS;"
             + "Initial Catalog = CrediDB; Integrated Security = True");
                cn.Open();
               
                return cn;

          
       }
        public static void conectar()
        {
            try
            {
                Conex();
                MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion Fallida");
            }
         }

        
    }
}
