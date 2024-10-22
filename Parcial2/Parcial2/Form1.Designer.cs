namespace Parcial2
{
    partial class frmUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegistroUsuario = new Label();
            lblUsuario = new Label();
            lblClave = new Label();
            lblNombre = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            grbRegistroUsuarios = new GroupBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            btnNavegacion = new Button();
            btnAgregarUsuario = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            grbNavegación = new GroupBox();
            btnSiguientePelicula = new Button();
            btnRegistroultimo = new Button();
            lblRegistroPeliculas = new Label();
            btnPrimero = new Button();
            btnAnteriorUsuario = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            grbDatosUsuario = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            grbRegistroUsuarios.SuspendLayout();
            grbNavegación.SuspendLayout();
            grbDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblRegistroUsuario
            // 
            lblRegistroUsuario.AutoSize = true;
            lblRegistroUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroUsuario.ForeColor = SystemColors.ControlText;
            lblRegistroUsuario.Location = new Point(300, 22);
            lblRegistroUsuario.Name = "lblRegistroUsuario";
            lblRegistroUsuario.Size = new Size(245, 38);
            lblRegistroUsuario.TabIndex = 0;
            lblRegistroUsuario.Text = "Registro Usuarios";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(6, 42);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(6, 92);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(46, 20);
            lblClave.TabIndex = 2;
            lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(6, 140);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(6, 191);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(74, 20);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(6, 246);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Telefono";
            // 
            // grbRegistroUsuarios
            // 
            grbRegistroUsuarios.Controls.Add(txtTelefono);
            grbRegistroUsuarios.Controls.Add(txtDireccion);
            grbRegistroUsuarios.Controls.Add(txtNombre);
            grbRegistroUsuarios.Controls.Add(txtClave);
            grbRegistroUsuarios.Controls.Add(txtUsuario);
            grbRegistroUsuarios.Controls.Add(lblUsuario);
            grbRegistroUsuarios.Controls.Add(lblClave);
            grbRegistroUsuarios.Controls.Add(lblTelefono);
            grbRegistroUsuarios.Controls.Add(lblNombre);
            grbRegistroUsuarios.Controls.Add(lblDireccion);
            grbRegistroUsuarios.Location = new Point(12, 72);
            grbRegistroUsuarios.Name = "grbRegistroUsuarios";
            grbRegistroUsuarios.Size = new Size(384, 278);
            grbRegistroUsuarios.TabIndex = 7;
            grbRegistroUsuarios.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(87, 239);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(87, 184);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(87, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(87, 85);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(87, 35);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 6;
            // 
            // btnNavegacion
            // 
            btnNavegacion.Location = new Point(716, 430);
            btnNavegacion.Name = "btnNavegacion";
            btnNavegacion.Size = new Size(105, 29);
            btnNavegacion.TabIndex = 8;
            btnNavegacion.Text = "Navegacion";
            btnNavegacion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(604, 430);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(94, 29);
            btnAgregarUsuario.TabIndex = 9;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(488, 430);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(375, 431);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // grbNavegación
            // 
            grbNavegación.Controls.Add(btnSiguientePelicula);
            grbNavegación.Controls.Add(btnRegistroultimo);
            grbNavegación.Controls.Add(lblRegistroPeliculas);
            grbNavegación.Controls.Add(btnPrimero);
            grbNavegación.Controls.Add(btnAnteriorUsuario);
            grbNavegación.Location = new Point(18, 391);
            grbNavegación.Name = "grbNavegación";
            grbNavegación.Size = new Size(250, 88);
            grbNavegación.TabIndex = 12;
            grbNavegación.TabStop = false;
            grbNavegación.Text = "Navegación";
            // 
            // btnSiguientePelicula
            // 
            btnSiguientePelicula.Location = new Point(195, 34);
            btnSiguientePelicula.Name = "btnSiguientePelicula";
            btnSiguientePelicula.Size = new Size(48, 29);
            btnSiguientePelicula.TabIndex = 15;
            btnSiguientePelicula.Text = ">|";
            btnSiguientePelicula.UseVisualStyleBackColor = true;
            // 
            // btnRegistroultimo
            // 
            btnRegistroultimo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistroultimo.Location = new Point(147, 34);
            btnRegistroultimo.Name = "btnRegistroultimo";
            btnRegistroultimo.Size = new Size(42, 29);
            btnRegistroultimo.TabIndex = 16;
            btnRegistroultimo.Text = ">";
            btnRegistroultimo.UseVisualStyleBackColor = true;
            // 
            // lblRegistroPeliculas
            // 
            lblRegistroPeliculas.AutoSize = true;
            lblRegistroPeliculas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroPeliculas.Location = new Point(90, 43);
            lblRegistroPeliculas.Name = "lblRegistroPeliculas";
            lblRegistroPeliculas.Size = new Size(51, 20);
            lblRegistroPeliculas.TabIndex = 17;
            lblRegistroPeliculas.Text = "x de n";
            // 
            // btnPrimero
            // 
            btnPrimero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrimero.Location = new Point(6, 34);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(40, 29);
            btnPrimero.TabIndex = 13;
            btnPrimero.Text = "|<";
            btnPrimero.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorUsuario
            // 
            btnAnteriorUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnteriorUsuario.Location = new Point(52, 34);
            btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            btnAnteriorUsuario.Size = new Size(22, 29);
            btnAnteriorUsuario.TabIndex = 14;
            btnAnteriorUsuario.Text = "<";
            btnAnteriorUsuario.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(497, 72);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(85, 31);
            lblBuscar.TabIndex = 13;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(614, 80);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(317, 27);
            txtBuscar.TabIndex = 14;
            // 
            // grbDatosUsuario
            // 
            grbDatosUsuario.Controls.Add(dataGridView1);
            grbDatosUsuario.Location = new Point(421, 130);
            grbDatosUsuario.Name = "grbDatosUsuario";
            grbDatosUsuario.Size = new Size(694, 252);
            grbDatosUsuario.TabIndex = 15;
            grbDatosUsuario.TabStop = false;
            grbDatosUsuario.Text = "groupBox1";
            grbDatosUsuario.Enter += grbDatosUsuario_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 232);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Usuario";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Clave";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dirección";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 595);
            Controls.Add(grbDatosUsuario);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(grbNavegación);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnNavegacion);
            Controls.Add(grbRegistroUsuarios);
            Controls.Add(lblRegistroUsuario);
            Name = "frmUsuario";
            Text = "frm_usuario";
            grbRegistroUsuarios.ResumeLayout(false);
            grbRegistroUsuarios.PerformLayout();
            grbNavegación.ResumeLayout(false);
            grbNavegación.PerformLayout();
            grbDatosUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroUsuario;
        private Label lblUsuario;
        private Label lblClave;
        private Label lblNombre;
        private Label lblDireccion;
        private Label lblTelefono;
        private GroupBox grbRegistroUsuarios;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private Button btnNavegacion;
        private Button btnAgregarUsuario;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox grbNavegación;
        private Button btnSiguientePelicula;
        private Button btnRegistroultimo;
        private Label lblRegistroPeliculas;
        private Button btnPrimero;
        private Button btnAnteriorUsuario;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private GroupBox grbDatosUsuario;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
