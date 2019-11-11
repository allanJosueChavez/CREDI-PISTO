namespace Credi_Pisto
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProspecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProspecto,
            this.nombre,
            this.dpi,
            this.nit,
            this.edad,
            this.correo1,
            this.correo2,
            this.tel1,
            this.tel2,
            this.telDomicilio,
            this.telTrabajo,
            this.idProducto});
            this.dataGridView1.Location = new System.Drawing.Point(41, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(992, 227);
            this.dataGridView1.TabIndex = 25;
            // 
            // idProspecto
            // 
            this.idProspecto.DataPropertyName = "idProspecto";
            this.idProspecto.HeaderText = "ID";
            this.idProspecto.Name = "idProspecto";
            this.idProspecto.Width = 30;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombres:";
            this.nombre.Name = "nombre";
            // 
            // dpi
            // 
            this.dpi.DataPropertyName = "dpi";
            this.dpi.HeaderText = "DPI";
            this.dpi.Name = "dpi";
            this.dpi.Width = 90;
            // 
            // nit
            // 
            this.nit.DataPropertyName = "nit";
            this.nit.HeaderText = "Nit";
            this.nit.Name = "nit";
            this.nit.Width = 90;
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.Width = 40;
            // 
            // correo1
            // 
            this.correo1.DataPropertyName = "correo1";
            this.correo1.HeaderText = "Correo 1";
            this.correo1.Name = "correo1";
            this.correo1.Width = 80;
            // 
            // correo2
            // 
            this.correo2.DataPropertyName = "correo2";
            this.correo2.HeaderText = "Correo 2";
            this.correo2.Name = "correo2";
            this.correo2.ReadOnly = true;
            this.correo2.Width = 80;
            // 
            // tel1
            // 
            this.tel1.DataPropertyName = "tel1";
            this.tel1.HeaderText = "Tel 1";
            this.tel1.Name = "tel1";
            this.tel1.Width = 90;
            // 
            // tel2
            // 
            this.tel2.DataPropertyName = "tel2";
            this.tel2.HeaderText = "Tel 2";
            this.tel2.Name = "tel2";
            this.tel2.Width = 90;
            // 
            // telDomicilio
            // 
            this.telDomicilio.DataPropertyName = "telDomicilio";
            this.telDomicilio.HeaderText = "Tel Domicilio";
            this.telDomicilio.Name = "telDomicilio";
            this.telDomicilio.Width = 90;
            // 
            // telTrabajo
            // 
            this.telTrabajo.DataPropertyName = "telTrabajo";
            this.telTrabajo.HeaderText = "Tel Trabajo";
            this.telTrabajo.Name = "telTrabajo";
            this.telTrabajo.Width = 90;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 80;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(41, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 26);
            this.button7.TabIndex = 33;
            this.button7.Text = "Menu Principal";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "CLIENTES";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(173, 372);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 48);
            this.button6.TabIndex = 38;
            this.button6.Text = "Actualizar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(970, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 28);
            this.button5.TabIndex = 37;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 48);
            this.button3.TabIndex = 36;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 48);
            this.button2.TabIndex = 35;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(719, 372);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 48);
            this.button8.TabIndex = 39;
            this.button8.Text = "Reporte";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProspecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn telTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
    }
}