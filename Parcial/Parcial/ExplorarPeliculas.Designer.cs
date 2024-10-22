namespace Parcial
{
    partial class ExplorarPeliculas
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
            this.btnVolverPeliculas = new System.Windows.Forms.Button();
            this.btnComprarPeliculas = new System.Windows.Forms.Button();
            this.lblBuscarPeliculas = new System.Windows.Forms.Label();
            this.txtBuscarPeliculas = new System.Windows.Forms.TextBox();
            this.grdDatosPeliculas = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNavegacionPeliculas = new System.Windows.Forms.GroupBox();
            this.lblRegistrosPeliculas = new System.Windows.Forms.Label();
            this.btnUltimaPeliculas = new System.Windows.Forms.Button();
            this.btnSiguientePeliculas = new System.Windows.Forms.Button();
            this.btnAnteriorPeliculas = new System.Windows.Forms.Button();
            this.btnPrimeroPeliculas = new System.Windows.Forms.Button();
            this.grbDatosPeliculas = new System.Windows.Forms.GroupBox();
            this.lblDescripcionPeliculas = new System.Windows.Forms.Label();
            this.txtDescripcionPeliculas = new System.Windows.Forms.TextBox();
            this.lblPrecioPeliculas = new System.Windows.Forms.Label();
            this.txtPrecioPeliculas = new System.Windows.Forms.TextBox();
            this.lblAñoPeliculas = new System.Windows.Forms.Label();
            this.txtAñoPeliculas = new System.Windows.Forms.TextBox();
            this.lblNombrePeliculas = new System.Windows.Forms.Label();
            this.txtNombrePeliculas = new System.Windows.Forms.TextBox();
            this.lblCodigoPeliculas = new System.Windows.Forms.Label();
            this.txtCodigoPeliculas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPeliculas)).BeginInit();
            this.grbNavegacionPeliculas.SuspendLayout();
            this.grbDatosPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolverPeliculas
            // 
            this.btnVolverPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPeliculas.Location = new System.Drawing.Point(571, 448);
            this.btnVolverPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverPeliculas.Name = "btnVolverPeliculas";
            this.btnVolverPeliculas.Size = new System.Drawing.Size(175, 47);
            this.btnVolverPeliculas.TabIndex = 31;
            this.btnVolverPeliculas.Text = "volver";
            this.btnVolverPeliculas.UseVisualStyleBackColor = true;
            // 
            // btnComprarPeliculas
            // 
            this.btnComprarPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarPeliculas.Location = new System.Drawing.Point(364, 440);
            this.btnComprarPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprarPeliculas.Name = "btnComprarPeliculas";
            this.btnComprarPeliculas.Size = new System.Drawing.Size(175, 47);
            this.btnComprarPeliculas.TabIndex = 30;
            this.btnComprarPeliculas.Text = "Comprar";
            this.btnComprarPeliculas.UseVisualStyleBackColor = true;
            // 
            // lblBuscarPeliculas
            // 
            this.lblBuscarPeliculas.AutoSize = true;
            this.lblBuscarPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPeliculas.Location = new System.Drawing.Point(515, 2);
            this.lblBuscarPeliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarPeliculas.Name = "lblBuscarPeliculas";
            this.lblBuscarPeliculas.Size = new System.Drawing.Size(117, 29);
            this.lblBuscarPeliculas.TabIndex = 28;
            this.lblBuscarPeliculas.Text = "BUSCAR:";
            // 
            // txtBuscarPeliculas
            // 
            this.txtBuscarPeliculas.Location = new System.Drawing.Point(636, 8);
            this.txtBuscarPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPeliculas.Name = "txtBuscarPeliculas";
            this.txtBuscarPeliculas.Size = new System.Drawing.Size(441, 22);
            this.txtBuscarPeliculas.TabIndex = 29;
            // 
            // grdDatosPeliculas
            // 
            this.grdDatosPeliculas.AllowUserToAddRows = false;
            this.grdDatosPeliculas.AllowUserToDeleteRows = false;
            this.grdDatosPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.Año,
            this.Precio,
            this.Descripcion});
            this.grdDatosPeliculas.Location = new System.Drawing.Point(520, 52);
            this.grdDatosPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatosPeliculas.Name = "grdDatosPeliculas";
            this.grdDatosPeliculas.ReadOnly = true;
            this.grdDatosPeliculas.RowHeadersWidth = 51;
            this.grdDatosPeliculas.Size = new System.Drawing.Size(683, 297);
            this.grdDatosPeliculas.TabIndex = 27;
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.MinimumWidth = 6;
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            this.idAlumno.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "Año";
            this.Año.HeaderText = "AÑO";
            this.Año.MinimumWidth = 6;
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "PRECIO";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "DESCRIPCION";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // grbNavegacionPeliculas
            // 
            this.grbNavegacionPeliculas.Controls.Add(this.lblRegistrosPeliculas);
            this.grbNavegacionPeliculas.Controls.Add(this.btnUltimaPeliculas);
            this.grbNavegacionPeliculas.Controls.Add(this.btnSiguientePeliculas);
            this.grbNavegacionPeliculas.Controls.Add(this.btnAnteriorPeliculas);
            this.grbNavegacionPeliculas.Controls.Add(this.btnPrimeroPeliculas);
            this.grbNavegacionPeliculas.Location = new System.Drawing.Point(23, 418);
            this.grbNavegacionPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionPeliculas.Name = "grbNavegacionPeliculas";
            this.grbNavegacionPeliculas.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionPeliculas.Size = new System.Drawing.Size(284, 71);
            this.grbNavegacionPeliculas.TabIndex = 26;
            this.grbNavegacionPeliculas.TabStop = false;
            this.grbNavegacionPeliculas.Text = "Navegacion";
            // 
            // lblRegistrosPeliculas
            // 
            this.lblRegistrosPeliculas.AutoSize = true;
            this.lblRegistrosPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosPeliculas.Location = new System.Drawing.Point(101, 30);
            this.lblRegistrosPeliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosPeliculas.Name = "lblRegistrosPeliculas";
            this.lblRegistrosPeliculas.Size = new System.Drawing.Size(77, 29);
            this.lblRegistrosPeliculas.TabIndex = 10;
            this.lblRegistrosPeliculas.Text = "x de n";
            // 
            // btnUltimaPeliculas
            // 
            this.btnUltimaPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaPeliculas.Location = new System.Drawing.Point(229, 17);
            this.btnUltimaPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimaPeliculas.Name = "btnUltimaPeliculas";
            this.btnUltimaPeliculas.Size = new System.Drawing.Size(47, 47);
            this.btnUltimaPeliculas.TabIndex = 3;
            this.btnUltimaPeliculas.Text = ">|";
            this.btnUltimaPeliculas.UseVisualStyleBackColor = true;
            // 
            // btnSiguientePeliculas
            // 
            this.btnSiguientePeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguientePeliculas.Location = new System.Drawing.Point(185, 17);
            this.btnSiguientePeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguientePeliculas.Name = "btnSiguientePeliculas";
            this.btnSiguientePeliculas.Size = new System.Drawing.Size(47, 47);
            this.btnSiguientePeliculas.TabIndex = 2;
            this.btnSiguientePeliculas.Text = ">";
            this.btnSiguientePeliculas.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorPeliculas
            // 
            this.btnAnteriorPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorPeliculas.Location = new System.Drawing.Point(53, 22);
            this.btnAnteriorPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorPeliculas.Name = "btnAnteriorPeliculas";
            this.btnAnteriorPeliculas.Size = new System.Drawing.Size(47, 47);
            this.btnAnteriorPeliculas.TabIndex = 1;
            this.btnAnteriorPeliculas.Text = "<";
            this.btnAnteriorPeliculas.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroPeliculas
            // 
            this.btnPrimeroPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroPeliculas.Location = new System.Drawing.Point(9, 22);
            this.btnPrimeroPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroPeliculas.Name = "btnPrimeroPeliculas";
            this.btnPrimeroPeliculas.Size = new System.Drawing.Size(47, 47);
            this.btnPrimeroPeliculas.TabIndex = 0;
            this.btnPrimeroPeliculas.Text = "|<";
            this.btnPrimeroPeliculas.UseVisualStyleBackColor = true;
            // 
            // grbDatosPeliculas
            // 
            this.grbDatosPeliculas.Controls.Add(this.lblDescripcionPeliculas);
            this.grbDatosPeliculas.Controls.Add(this.txtDescripcionPeliculas);
            this.grbDatosPeliculas.Controls.Add(this.lblPrecioPeliculas);
            this.grbDatosPeliculas.Controls.Add(this.txtPrecioPeliculas);
            this.grbDatosPeliculas.Controls.Add(this.lblAñoPeliculas);
            this.grbDatosPeliculas.Controls.Add(this.txtAñoPeliculas);
            this.grbDatosPeliculas.Controls.Add(this.lblNombrePeliculas);
            this.grbDatosPeliculas.Controls.Add(this.txtNombrePeliculas);
            this.grbDatosPeliculas.Controls.Add(this.lblCodigoPeliculas);
            this.grbDatosPeliculas.Controls.Add(this.txtCodigoPeliculas);
            this.grbDatosPeliculas.Enabled = false;
            this.grbDatosPeliculas.Location = new System.Drawing.Point(0, 2);
            this.grbDatosPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosPeliculas.Name = "grbDatosPeliculas";
            this.grbDatosPeliculas.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosPeliculas.Size = new System.Drawing.Size(493, 386);
            this.grbDatosPeliculas.TabIndex = 25;
            this.grbDatosPeliculas.TabStop = false;
            this.grbDatosPeliculas.Text = "Datos Peliculas";
            // 
            // lblDescripcionPeliculas
            // 
            this.lblDescripcionPeliculas.AutoSize = true;
            this.lblDescripcionPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionPeliculas.Location = new System.Drawing.Point(41, 246);
            this.lblDescripcionPeliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionPeliculas.Name = "lblDescripcionPeliculas";
            this.lblDescripcionPeliculas.Size = new System.Drawing.Size(147, 29);
            this.lblDescripcionPeliculas.TabIndex = 9;
            this.lblDescripcionPeliculas.Text = "Descripcion:";
            // 
            // txtDescripcionPeliculas
            // 
            this.txtDescripcionPeliculas.Location = new System.Drawing.Point(191, 252);
            this.txtDescripcionPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionPeliculas.Multiline = true;
            this.txtDescripcionPeliculas.Name = "txtDescripcionPeliculas";
            this.txtDescripcionPeliculas.Size = new System.Drawing.Size(281, 110);
            this.txtDescripcionPeliculas.TabIndex = 8;
            // 
            // lblPrecioPeliculas
            // 
            this.lblPrecioPeliculas.AutoSize = true;
            this.lblPrecioPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPeliculas.Location = new System.Drawing.Point(41, 191);
            this.lblPrecioPeliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioPeliculas.Name = "lblPrecioPeliculas";
            this.lblPrecioPeliculas.Size = new System.Drawing.Size(89, 29);
            this.lblPrecioPeliculas.TabIndex = 7;
            this.lblPrecioPeliculas.Text = "Precio:";
            // 
            // txtPrecioPeliculas
            // 
            this.txtPrecioPeliculas.Location = new System.Drawing.Point(175, 196);
            this.txtPrecioPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioPeliculas.Name = "txtPrecioPeliculas";
            this.txtPrecioPeliculas.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioPeliculas.TabIndex = 6;
            // 
            // lblAñoPeliculas
            // 
            this.lblAñoPeliculas.AutoSize = true;
            this.lblAñoPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoPeliculas.Location = new System.Drawing.Point(41, 143);
            this.lblAñoPeliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAñoPeliculas.Name = "lblAñoPeliculas";
            this.lblAñoPeliculas.Size = new System.Drawing.Size(61, 29);
            this.lblAñoPeliculas.TabIndex = 5;
            this.lblAñoPeliculas.Text = "Año:";
            // 
            // txtAñoPeliculas
            // 
            this.txtAñoPeliculas.Location = new System.Drawing.Point(175, 148);
            this.txtAñoPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.txtAñoPeliculas.Name = "txtAñoPeliculas";
            this.txtAñoPeliculas.Size = new System.Drawing.Size(97, 22);
            this.txtAñoPeliculas.TabIndex = 4;
            // 
            // lblNombrePeliculas
            // 
            this.lblNombrePeliculas.AutoSize = true;
            this.lblNombrePeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePeliculas.Location = new System.Drawing.Point(41, 94);
            this.lblNombrePeliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePeliculas.Name = "lblNombrePeliculas";
            this.lblNombrePeliculas.Size = new System.Drawing.Size(107, 29);
            this.lblNombrePeliculas.TabIndex = 3;
            this.lblNombrePeliculas.Text = "Nombre:";
            // 
            // txtNombrePeliculas
            // 
            this.txtNombrePeliculas.Location = new System.Drawing.Point(161, 100);
            this.txtNombrePeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePeliculas.Name = "txtNombrePeliculas";
            this.txtNombrePeliculas.Size = new System.Drawing.Size(323, 22);
            this.txtNombrePeliculas.TabIndex = 2;
            // 
            // lblCodigoPeliculas
            // 
            this.lblCodigoPeliculas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lblCodigoPeliculas.AutoSize = true;
            this.lblCodigoPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPeliculas.Location = new System.Drawing.Point(41, 46);
            this.lblCodigoPeliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPeliculas.Name = "lblCodigoPeliculas";
            this.lblCodigoPeliculas.Size = new System.Drawing.Size(98, 29);
            this.lblCodigoPeliculas.TabIndex = 1;
            this.lblCodigoPeliculas.Text = "Codigo:";
            // 
            // txtCodigoPeliculas
            // 
            this.txtCodigoPeliculas.Location = new System.Drawing.Point(175, 50);
            this.txtCodigoPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPeliculas.Name = "txtCodigoPeliculas";
            this.txtCodigoPeliculas.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoPeliculas.TabIndex = 0;
            // 
            // ExplorarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 515);
            this.Controls.Add(this.btnVolverPeliculas);
            this.Controls.Add(this.btnComprarPeliculas);
            this.Controls.Add(this.lblBuscarPeliculas);
            this.Controls.Add(this.txtBuscarPeliculas);
            this.Controls.Add(this.grdDatosPeliculas);
            this.Controls.Add(this.grbNavegacionPeliculas);
            this.Controls.Add(this.grbDatosPeliculas);
            this.Name = "ExplorarPeliculas";
            this.Text = "ExplorarPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPeliculas)).EndInit();
            this.grbNavegacionPeliculas.ResumeLayout(false);
            this.grbNavegacionPeliculas.PerformLayout();
            this.grbDatosPeliculas.ResumeLayout(false);
            this.grbDatosPeliculas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverPeliculas;
        private System.Windows.Forms.Button btnComprarPeliculas;
        private System.Windows.Forms.Label lblBuscarPeliculas;
        private System.Windows.Forms.TextBox txtBuscarPeliculas;
        private System.Windows.Forms.DataGridView grdDatosPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.GroupBox grbNavegacionPeliculas;
        private System.Windows.Forms.Label lblRegistrosPeliculas;
        private System.Windows.Forms.Button btnUltimaPeliculas;
        private System.Windows.Forms.Button btnSiguientePeliculas;
        private System.Windows.Forms.Button btnAnteriorPeliculas;
        private System.Windows.Forms.Button btnPrimeroPeliculas;
        private System.Windows.Forms.GroupBox grbDatosPeliculas;
        private System.Windows.Forms.Label lblDescripcionPeliculas;
        private System.Windows.Forms.TextBox txtDescripcionPeliculas;
        private System.Windows.Forms.Label lblPrecioPeliculas;
        private System.Windows.Forms.TextBox txtPrecioPeliculas;
        private System.Windows.Forms.Label lblAñoPeliculas;
        private System.Windows.Forms.TextBox txtAñoPeliculas;
        private System.Windows.Forms.Label lblNombrePeliculas;
        private System.Windows.Forms.TextBox txtNombrePeliculas;
        private System.Windows.Forms.Label lblCodigoPeliculas;
        private System.Windows.Forms.TextBox txtCodigoPeliculas;
    }
}