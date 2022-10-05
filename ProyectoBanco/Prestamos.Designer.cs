namespace ProyectoBanco
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.label1 = new System.Windows.Forms.Label();
            this.Saludo = new System.Windows.Forms.Label();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DetalledelPrestamo = new System.Windows.Forms.Panel();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DatosPersonales = new System.Windows.Forms.Panel();
            this.Provincias = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DetalledelPrestamo.SuspendLayout();
            this.DatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.Location = new System.Drawing.Point(51, 69);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(187, 38);
            this.Saludo.TabIndex = 1;
            this.Saludo.Text = "Bienvenido,";
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.BackColor = System.Drawing.Color.DarkRed;
            this.btnConfirmarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(420, 410);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(240, 97);
            this.btnConfirmarSolicitud.TabIndex = 2;
            this.btnConfirmarSolicitud.Text = "Confirmar Solicitud";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = false;
            this.btnConfirmarSolicitud.Click += new System.EventHandler(this.btnConfirmarSolicitud_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(959, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos Personales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detalle del préstamo:";
            // 
            // DetalledelPrestamo
            // 
            this.DetalledelPrestamo.BackColor = System.Drawing.Color.LightBlue;
            this.DetalledelPrestamo.Controls.Add(this.Monto);
            this.DetalledelPrestamo.Controls.Add(this.cuotas);
            this.DetalledelPrestamo.Controls.Add(this.label7);
            this.DetalledelPrestamo.Controls.Add(this.label6);
            this.DetalledelPrestamo.Location = new System.Drawing.Point(573, 204);
            this.DetalledelPrestamo.Name = "DetalledelPrestamo";
            this.DetalledelPrestamo.Size = new System.Drawing.Size(481, 165);
            this.DetalledelPrestamo.TabIndex = 7;
            // 
            // cuotas
            // 
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(274, 113);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(187, 24);
            this.cuotas.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cuotas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Monto del Préstamo:";
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.BackColor = System.Drawing.Color.LightBlue;
            this.DatosPersonales.Controls.Add(this.textBox1);
            this.DatosPersonales.Controls.Add(this.Provincias);
            this.DatosPersonales.Controls.Add(this.label5);
            this.DatosPersonales.Controls.Add(this.label4);
            this.DatosPersonales.Location = new System.Drawing.Point(25, 204);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(463, 165);
            this.DatosPersonales.TabIndex = 8;
            // 
            // Provincias
            // 
            this.Provincias.FormattingEnabled = true;
            this.Provincias.Location = new System.Drawing.Point(236, 34);
            this.Provincias.Name = "Provincias";
            this.Provincias.Size = new System.Drawing.Size(187, 24);
            this.Provincias.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Provincia:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(274, 41);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(177, 22);
            this.Monto.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1119, 603);
            this.Controls.Add(this.DatosPersonales);
            this.Controls.Add(this.DetalledelPrestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.Saludo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prestamos";
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.DetalledelPrestamo.ResumeLayout(false);
            this.DetalledelPrestamo.PerformLayout();
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Button btnConfirmarSolicitud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel DetalledelPrestamo;
        private System.Windows.Forms.Panel DatosPersonales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Provincias;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}