using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Credi_Pisto
{
    public partial class Form1 : Form
    {

        // public String enableUser ;
        public static string enableUser { get; set; }

        private SqlConnection cn;

        

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
       

        }

      
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

      

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conex();
           
            SqlDataAdapter sqlDta = new SqlDataAdapter();
            SqlCommand sqlCmd = new SqlCommand();
            DataSet ds = new DataSet();
            DataRow DR;
            DR = ds.Tables["usuario"].Rows[0];
            
            sqlCmd.CommandTimeout = 0;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "sp_usuario";

            sqlCmd.Parameters.AddWithValue("@Opcion", '5');
            sqlCmd.Parameters.AddWithValue("@usuario", textBox1.Text);
             sqlCmd.Parameters.AddWithValue("@pass", textBox2.Text);
            sqlDta.SelectCommand = sqlCmd;

            Login.Consulta();



            if ((textBox1.Text == DR["usuario"].ToString()) || (textBox2.Text == DR["pass"].ToString()))
            {

                Form2 Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }


        }

        private void Form1_Load_3(object sender, EventArgs e)
        {

        }

        /*

               Dim sqlCmd As New SqlCommand
                Dim sqlConexion As New SqlConnection
                Dim datConsulta As New DataTable("Consulta")


                    try
                    {

                        Conexion.Conex();

                        SqlCommand comando = new SqlCommand("select usuario, pass from usuario where usuario = '" + textBox1.Text + "'And pass = '" + textBox2.Text + "' ", Conexion.Conex());


                        comando.ExecuteNonQuery();
                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(comando);


                        da.Fill(ds, "usuario");
                        DataRow DR; 
                        DR = ds.Tables["usuario"].Rows[0];


                        if ((textBox1.Text == DR["usuario"].ToString()) || (textBox2.Text == DR["pass"].ToString()))
                        {

                            Form2 Form2 = new Form2();
                            Form2.Show();
                           this.Hide();
                        }

                    }
                    catch
                    {

                        MessageBox.Show("¡Error! Su contraseña y/o usuario son invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                     enableUser = textBox1.Text;
                          }
                     */




    }



}