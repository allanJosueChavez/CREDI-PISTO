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
            try
            {

                Conexion.Conex();

                SqlCommand comando = new SqlCommand("select usuario, pass from usuario where usuario = '" + textBox1.Text + "'And pass = '" + textBox2.Text + "' ", Conexion.Conex());

                //ejecuta una instruccion de sql devolviendo el numero de las filas afectadas
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);

                //Llenando el dataAdapter
                da.Fill(ds, "usuario");
                //utilizado para representar una fila de la tabla q necesitas en este caso usuario
                DataRow DR; 
                DR = ds.Tables["usuario"].Rows[0];

                //evaluando que la pass y usuario sean correctos
                if ((textBox1.Text == DR["usuario"].ToString()) || (textBox2.Text == DR["pass"].ToString()))
                {
                    //instanciando el formulario principal
                    Form2 Form2 = new Form2();
                    Form2.Show();//abriendo el formulario principal
                   this.Hide();//esto sirve para ocultar el formulario de login
                }

            }
            catch
            {
                //en caso que la pass sea erronea mostrara un mensaje
                //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en ste caso OK, icono a mostrar en este caso uno de error
                MessageBox.Show("¡Error! Su contraseña y/o usuario son invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}