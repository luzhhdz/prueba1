
namespace ControlVersion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPrograma = new System.Windows.Forms.ComboBox();
            this.txtGrupoTeorico = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.lblCarnetEstudiante = new System.Windows.Forms.Label();
            this.lblGrupoTeorico = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnEjecutar);
            this.groupBox1.Controls.Add(this.cmbPrograma);
            this.groupBox1.Controls.Add(this.txtGrupoTeorico);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.txtNombreCompleto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(499, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Estudiante";
            // 
            // cmbPrograma
            // 
            this.cmbPrograma.FormattingEnabled = true;
            this.cmbPrograma.Items.AddRange(new object[] {
            "Git",
            "Subversion",
            "Mercurial",
            "CVS"});
            this.cmbPrograma.Location = new System.Drawing.Point(190, 143);
            this.cmbPrograma.Name = "cmbPrograma";
            this.cmbPrograma.Size = new System.Drawing.Size(121, 24);
            this.cmbPrograma.TabIndex = 7;
            // 
            // txtGrupoTeorico
            // 
            this.txtGrupoTeorico.Location = new System.Drawing.Point(190, 110);
            this.txtGrupoTeorico.Name = "txtGrupoTeorico";
            this.txtGrupoTeorico.Size = new System.Drawing.Size(121, 22);
            this.txtGrupoTeorico.TabIndex = 6;
            this.txtGrupoTeorico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(191, 77);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(120, 22);
            this.txtCarnet.TabIndex = 5;
            this.txtCarnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(191, 43);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(272, 22);
            this.txtNombreCompleto.TabIndex = 4;
            this.txtNombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Programa Seleccionado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grupo Teórico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carnet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGrupoTeorico);
            this.groupBox2.Controls.Add(this.lblCarnetEstudiante);
            this.groupBox2.Controls.Add(this.lblNombreEstudiante);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblMensaje);
            this.groupBox2.Location = new System.Drawing.Point(25, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ficha del Programa Seleccionado";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(33, 32);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(67, 16);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Mensaje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre del Estudiante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Carnet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Grupo Teorico:";
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.Location = new System.Drawing.Point(190, 72);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(45, 16);
            this.lblNombreEstudiante.TabIndex = 4;
            this.lblNombreEstudiante.Text = "label9";
            // 
            // lblCarnetEstudiante
            // 
            this.lblCarnetEstudiante.AutoSize = true;
            this.lblCarnetEstudiante.Location = new System.Drawing.Point(190, 109);
            this.lblCarnetEstudiante.Name = "lblCarnetEstudiante";
            this.lblCarnetEstudiante.Size = new System.Drawing.Size(52, 16);
            this.lblCarnetEstudiante.TabIndex = 5;
            this.lblCarnetEstudiante.Text = "label10";
            // 
            // lblGrupoTeorico
            // 
            this.lblGrupoTeorico.AutoSize = true;
            this.lblGrupoTeorico.Location = new System.Drawing.Point(190, 143);
            this.lblGrupoTeorico.Name = "lblGrupoTeorico";
            this.lblGrupoTeorico.Size = new System.Drawing.Size(52, 16);
            this.lblGrupoTeorico.TabIndex = 6;
            this.lblGrupoTeorico.Text = "label11";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(63, 203);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Padding = new System.Windows.Forms.Padding(1);
            this.btnEjecutar.Size = new System.Drawing.Size(75, 27);
            this.btnEjecutar.TabIndex = 8;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(214, 203);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(1);
            this.btnLimpiar.Size = new System.Drawing.Size(75, 27);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(358, 203);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(1);
            this.btnSalir.Size = new System.Drawing.Size(75, 27);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Seleccion de Programa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPrograma;
        private System.Windows.Forms.TextBox txtGrupoTeorico;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lblGrupoTeorico;
        private System.Windows.Forms.Label lblCarnetEstudiante;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

