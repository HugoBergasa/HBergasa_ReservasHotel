using HBergasa_ReservasHotel.bbdd;
using System.Windows.Forms;

namespace HBergasa_ReservasHotel
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonEntrar = new System.Windows.Forms.Button();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::HBergasa_ReservasHotel.Properties.Resources.hotel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 709);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonEntrar);
            this.groupBox1.Controls.Add(this.campoPass);
            this.groupBox1.Controls.Add(this.campoUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(726, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(483, 348);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // botonEntrar
            // 
            this.botonEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonEntrar.Location = new System.Drawing.Point(255, 220);
            this.botonEntrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(112, 35);
            this.botonEntrar.TabIndex = 4;
            this.botonEntrar.Text = "Entrar";
            this.botonEntrar.UseVisualStyleBackColor = false;
            this.botonEntrar.Click += new System.EventHandler(this.botonEntrar_Click);
            // 
            // campoPass
            // 
            this.campoPass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoPass.Location = new System.Drawing.Point(196, 154);
            this.campoPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(211, 26);
            this.campoPass.TabIndex = 3;
            this.campoPass.UseSystemPasswordChar = true;
            // 
            // campoUsuario
            // 
            this.campoUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoUsuario.Location = new System.Drawing.Point(196, 83);
            this.campoUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(211, 26);
            this.campoUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1268, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " APLICACION DE RESERVAS - ENTRAR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonEntrar;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.TextBox campoUsuario;
       
        public void Entrar()
        {
     
            if (Conexion.acceder(campoUsuario.Text, campoPass.Text))
            {
                dniRescatado = Conexion.rescatarDniYNombreCompleto(campoUsuario.Text).Dni;
                nombreRescatado = Conexion.rescatarDniYNombreCompleto(campoUsuario.Text).Nombre;
                apellidosRescatado = Conexion.rescatarDniYNombreCompleto(campoUsuario.Text).Apellidos;

                vistas.Principal vp = new vistas.Principal();
                vp.Show();
                
            }
            else
            {
                MessageBox.Show("Error de logado. Por favor inténtelo de nuevo más tarde.");
            }
        }
        public static string dniRescatado, nombreRescatado, apellidosRescatado;
    }
}

