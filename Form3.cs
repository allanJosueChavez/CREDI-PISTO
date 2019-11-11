using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credi_Pisto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'crediDBDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.crediDBDataSet.usuario);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Close();
        }



        public void GetRecords() {

            SqlCommand comando = new SqlCommand("select * from usuario " , Conexion.Conex());
            
            comando.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds, "usuario");

            

           // dataGridView1.AutoGenerateColumns = True;
            //dataGridView1.DataSource = ds.Tables("Cuentas");

            DataRow DR;
            DR = ds.Tables["usuario"].Rows[0];

            
           
       
       
 }

  

        private DateTime fechaDeIngreso()
        {
            DateTime ingreso;
            ingreso = System.DateTime.Today;
            return ingreso;
        }
         
        


    

        private void button4_Click(object sender, EventArgs e)
        {
            
            }
    }
}
