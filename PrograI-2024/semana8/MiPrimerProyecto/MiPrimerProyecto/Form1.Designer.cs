namespace MiPrimerProyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.lblCodigoalumno = new System.Windows.Forms.Label();
            this.txtCodigoalumnos = new System.Windows.Forms.ComboBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtNombrealumno = new System.Windows.Forms.ComboBox();
            this.txtDireccionAlumno = new System.Windows.Forms.ComboBox();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.ComboBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtDuiAlumno = new System.Windows.Forms.ComboBox();
            this.lblDuiAlumno = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosAlumno
            // 
            this.grbDatosAlumno.Controls.Add(this.txtDuiAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblDuiAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtNombrealumno);
            this.grbDatosAlumno.Controls.Add(this.lblNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtCodigoalumnos);
            this.grbDatosAlumno.Controls.Add(this.lblCodigoalumno);
            this.grbDatosAlumno.Location = new System.Drawing.Point(47, 12);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Size = new System.Drawing.Size(455, 353);
            this.grbDatosAlumno.TabIndex = 0;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "Datos Alumno";
            // 
            // lblCodigoalumno
            // 
            this.lblCodigoalumno.AutoSize = true;
            this.lblCodigoalumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoalumno.Location = new System.Drawing.Point(19, 41);
            this.lblCodigoalumno.Name = "lblCodigoalumno";
            this.lblCodigoalumno.Size = new System.Drawing.Size(88, 25);
            this.lblCodigoalumno.TabIndex = 1;
            this.lblCodigoalumno.Text = "Codigo:";
            this.lblCodigoalumno.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigoalumnos
            // 
            this.txtCodigoalumnos.FormattingEnabled = true;
            this.txtCodigoalumnos.Location = new System.Drawing.Point(113, 42);
            this.txtCodigoalumnos.Name = "txtCodigoalumnos";
            this.txtCodigoalumnos.Size = new System.Drawing.Size(121, 24);
            this.txtCodigoalumnos.TabIndex = 2;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(19, 107);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(94, 25);
            this.lblNombreAlumno.TabIndex = 3;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // txtNombrealumno
            // 
            this.txtNombrealumno.FormattingEnabled = true;
            this.txtNombrealumno.Location = new System.Drawing.Point(113, 108);
            this.txtNombrealumno.Name = "txtNombrealumno";
            this.txtNombrealumno.Size = new System.Drawing.Size(230, 24);
            this.txtNombrealumno.TabIndex = 4;
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.FormattingEnabled = true;
            this.txtDireccionAlumno.Location = new System.Drawing.Point(127, 161);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(230, 24);
            this.txtDireccionAlumno.TabIndex = 6;
            this.txtDireccionAlumno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDireccionAlumno
            // 
            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionAlumno.Location = new System.Drawing.Point(19, 161);
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";
            this.lblDireccionAlumno.Size = new System.Drawing.Size(102, 25);
            this.lblDireccionAlumno.TabIndex = 5;
            this.lblDireccionAlumno.Text = "Direccion";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.FormattingEnabled = true;
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(113, 208);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(230, 24);
            this.txtTelefonoAlumno.TabIndex = 8;
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(19, 207);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(97, 25);
            this.lblTelefonoAlumno.TabIndex = 7;
            this.lblTelefonoAlumno.Text = "Telefono";
            // 
            // txtDuiAlumno
            // 
            this.txtDuiAlumno.FormattingEnabled = true;
            this.txtDuiAlumno.Location = new System.Drawing.Point(113, 263);
            this.txtDuiAlumno.Name = "txtDuiAlumno";
            this.txtDuiAlumno.Size = new System.Drawing.Size(230, 24);
            this.txtDuiAlumno.TabIndex = 10;
            // 
            // lblDuiAlumno
            // 
            this.lblDuiAlumno.AutoSize = true;
            this.lblDuiAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiAlumno.Location = new System.Drawing.Point(19, 262);
            this.lblDuiAlumno.Name = "lblDuiAlumno";
            this.lblDuiAlumno.Size = new System.Drawing.Size(51, 25);
            this.lblDuiAlumno.TabIndex = 9;
            this.lblDuiAlumno.Text = "Dui:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(47, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(462, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 670);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbDatosAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.Label lblCodigoalumno;
        private System.Windows.Forms.ComboBox txtCodigoalumnos;
        private System.Windows.Forms.ComboBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.ComboBox txtNombrealumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.ComboBox txtDuiAlumno;
        private System.Windows.Forms.Label lblDuiAlumno;
        private System.Windows.Forms.ComboBox txtTelefonoAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

