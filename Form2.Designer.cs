namespace Credi_Pisto
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prospectos = new System.Windows.Forms.ToolStripMenuItem();
            this.verProspectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarProspectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productos = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisos = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREDI PISTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarios,
            this.prospectos,
            this.clientes,
            this.productos,
            this.permisos,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usuarios
            // 
            this.usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuariosToolStripMenuItem});
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(71, 21);
            this.usuarios.Text = "Usuarios";
            // 
            // agregarUsuariosToolStripMenuItem
            // 
            this.agregarUsuariosToolStripMenuItem.Name = "agregarUsuariosToolStripMenuItem";
            this.agregarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.agregarUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.agregarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuariosToolStripMenuItem_Click);
            // 
            // prospectos
            // 
            this.prospectos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProspectosToolStripMenuItem,
            this.verificarProspectosToolStripMenuItem,
            this.evaluacionesToolStripMenuItem});
            this.prospectos.Name = "prospectos";
            this.prospectos.Size = new System.Drawing.Size(85, 21);
            this.prospectos.Text = "Prospectos";
            this.prospectos.Click += new System.EventHandler(this.prospectos_Click);
            // 
            // verProspectosToolStripMenuItem
            // 
            this.verProspectosToolStripMenuItem.Name = "verProspectosToolStripMenuItem";
            this.verProspectosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.verProspectosToolStripMenuItem.Text = "Ver Prospectos";
            this.verProspectosToolStripMenuItem.Click += new System.EventHandler(this.verProspectosToolStripMenuItem_Click);
            // 
            // verificarProspectosToolStripMenuItem
            // 
            this.verificarProspectosToolStripMenuItem.Name = "verificarProspectosToolStripMenuItem";
            this.verificarProspectosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.verificarProspectosToolStripMenuItem.Text = "Evaluar Prospectos";
            this.verificarProspectosToolStripMenuItem.Click += new System.EventHandler(this.verificarProspectosToolStripMenuItem_Click);
            // 
            // clientes
            // 
            this.clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verClientesToolStripMenuItem,
            this.estadoClientesToolStripMenuItem});
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(65, 21);
            this.clientes.Text = "Clientes";
            // 
            // verClientesToolStripMenuItem
            // 
            this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.verClientesToolStripMenuItem.Text = "Ver Clientes";
            this.verClientesToolStripMenuItem.Click += new System.EventHandler(this.verClientesToolStripMenuItem_Click);
            // 
            // estadoClientesToolStripMenuItem
            // 
            this.estadoClientesToolStripMenuItem.Name = "estadoClientesToolStripMenuItem";
            this.estadoClientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.estadoClientesToolStripMenuItem.Text = "Estado Clientes";
            // 
            // productos
            // 
            this.productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosToolStripMenuItem});
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(79, 21);
            this.productos.Text = "Productos";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.verProductosToolStripMenuItem.Text = "Ver Productos";
            // 
            // permisos
            // 
            this.permisos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPermisosToolStripMenuItem});
            this.permisos.Name = "permisos";
            this.permisos.Size = new System.Drawing.Size(73, 21);
            this.permisos.Text = "Permisos";
            // 
            // gestionarPermisosToolStripMenuItem
            // 
            this.gestionarPermisosToolStripMenuItem.Name = "gestionarPermisosToolStripMenuItem";
            this.gestionarPermisosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionarPermisosToolStripMenuItem.Text = "Gestionar Permisos";
            this.gestionarPermisosToolStripMenuItem.Click += new System.EventHandler(this.gestionarPermisosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 21);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "USUARIOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "PROSPECTOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "CLIENTES";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(173, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "PRODUCTOS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(438, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 27);
            this.button5.TabIndex = 11;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.evaluacionesToolStripMenuItem.Text = "Evaluaciones";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 465);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarios;
        private System.Windows.Forms.ToolStripMenuItem prospectos;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem productos;
        private System.Windows.Forms.ToolStripMenuItem permisos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProspectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarProspectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPermisosToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem estadoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem;
    }
}