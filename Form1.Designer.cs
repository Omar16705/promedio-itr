namespace proyecto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNoat1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPromObtenido = new System.Windows.Forms.TextBox();
            this.lblPromedioObtenido = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNRegistro = new System.Windows.Forms.Button();
            this.btnAgregarPromedio = new System.Windows.Forms.Button();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblerror);
            this.groupBox1.Controls.Add(this.txtN3);
            this.groupBox1.Controls.Add(this.txtN2);
            this.groupBox1.Controls.Add(this.txtN1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNota3);
            this.groupBox1.Controls.Add(this.lblNota2);
            this.groupBox1.Controls.Add(this.lblNoat1);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Notas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto.Properties.Resources.icons8_usuario_masculino_en_círculo_100;
            this.pictureBox1.Location = new System.Drawing.Point(459, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 127);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(23, 198);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(59, 26);
            this.lblerror.TabIndex = 7;
            this.lblerror.Text = "Error";
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(73, 144);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(174, 20);
            this.txtN3.TabIndex = 6;
            this.tlpAyuda.SetToolTip(this.txtN3, "Ingresa valores en 0 y 10\r\n");
            this.txtN3.TextChanged += new System.EventHandler(this.txtN3_TextChanged);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(74, 92);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(173, 20);
            this.txtN2.TabIndex = 5;
            this.tlpAyuda.SetToolTip(this.txtN2, "Ingresa valores en 0 y 10\r\n");
            this.txtN2.TextChanged += new System.EventHandler(this.txtN2_TextChanged);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(73, 39);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(175, 20);
            this.txtN1.TabIndex = 4;
            this.tlpAyuda.SetToolTip(this.txtN1, "Ingresa valores en 0 y 10");
            this.txtN1.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(18, 144);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(42, 13);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota 3:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(20, 88);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(42, 13);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNoat1
            // 
            this.lblNoat1.AutoSize = true;
            this.lblNoat1.Location = new System.Drawing.Point(13, 42);
            this.lblNoat1.Name = "lblNoat1";
            this.lblNoat1.Size = new System.Drawing.Size(42, 13);
            this.lblNoat1.TabIndex = 0;
            this.lblNoat1.Text = "Nota 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPromObtenido);
            this.groupBox2.Controls.Add(this.lblPromedioObtenido);
            this.groupBox2.Location = new System.Drawing.Point(71, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Promedio";
            // 
            // txtPromObtenido
            // 
            this.txtPromObtenido.Location = new System.Drawing.Point(134, 62);
            this.txtPromObtenido.Multiline = true;
            this.txtPromObtenido.Name = "txtPromObtenido";
            this.txtPromObtenido.ReadOnly = true;
            this.txtPromObtenido.Size = new System.Drawing.Size(169, 54);
            this.txtPromObtenido.TabIndex = 1;
            // 
            // lblPromedioObtenido
            // 
            this.lblPromedioObtenido.AutoSize = true;
            this.lblPromedioObtenido.Location = new System.Drawing.Point(31, 62);
            this.lblPromedioObtenido.Name = "lblPromedioObtenido";
            this.lblPromedioObtenido.Size = new System.Drawing.Size(97, 13);
            this.lblPromedioObtenido.TabIndex = 0;
            this.lblPromedioObtenido.Text = "Promedio Obtenido";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnNRegistro);
            this.groupBox3.Controls.Add(this.btnAgregarPromedio);
            this.groupBox3.Location = new System.Drawing.Point(611, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 317);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Image = global::proyecto.Properties.Resources.icons8_salida_50;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(3, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(307, 61);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNRegistro
            // 
            this.btnNRegistro.Image = global::proyecto.Properties.Resources.icons8_agregar_propiedad_501;
            this.btnNRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNRegistro.Location = new System.Drawing.Point(18, 132);
            this.btnNRegistro.Name = "btnNRegistro";
            this.btnNRegistro.Size = new System.Drawing.Size(278, 115);
            this.btnNRegistro.TabIndex = 1;
            this.btnNRegistro.Text = "Nuevo Registro";
            this.btnNRegistro.UseVisualStyleBackColor = true;
            this.btnNRegistro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregarPromedio
            // 
            this.btnAgregarPromedio.Image = global::proyecto.Properties.Resources.icons8_agregar_propiedad_50;
            this.btnAgregarPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPromedio.Location = new System.Drawing.Point(3, 16);
            this.btnAgregarPromedio.Name = "btnAgregarPromedio";
            this.btnAgregarPromedio.Size = new System.Drawing.Size(304, 96);
            this.btnAgregarPromedio.TabIndex = 0;
            this.btnAgregarPromedio.Text = "Agregar Promedio";
            this.btnAgregarPromedio.UseVisualStyleBackColor = true;
            this.btnAgregarPromedio.Click += new System.EventHandler(this.btnAgregarPromedio_Click);
            // 
            // tlpAyuda
            // 
            this.tlpAyuda.IsBalloon = true;
            this.tlpAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpAyuda.ToolTipTitle = "Mensaje de ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 672);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sistema de Promedio ITR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNoat1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNRegistro;
        private System.Windows.Forms.Button btnAgregarPromedio;
        private System.Windows.Forms.TextBox txtPromObtenido;
        private System.Windows.Forms.Label lblPromedioObtenido;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpAyuda;
    }
}

