using HBergasa_ReservasHotel.bbdd;
using HBergasa_ReservasHotel.modelo;
using HBergasa_ReservasHotel.utilidades;
using System.Windows.Forms;
using System;

namespace HBergasa_ReservasHotel.vistas
{
    partial class AltaEmpleados
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
            this.campoPass = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.campoSalario = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.CampoNombre = new System.Windows.Forms.TextBox();
            this.campoDni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEmpleados = new System.Windows.Forms.GroupBox();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEmpleados.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // campoPass
            // 
            this.campoPass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoPass.Location = new System.Drawing.Point(298, 551);
            this.campoPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(218, 26);
            this.campoPass.TabIndex = 15;
            this.campoPass.Tag = "CONTRASEÑA";
            // 
            // campoUsuario
            // 
            this.campoUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoUsuario.Location = new System.Drawing.Point(298, 495);
            this.campoUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(218, 26);
            this.campoUsuario.TabIndex = 14;
            this.campoUsuario.Tag = "USUARIO";
            this.campoUsuario.TextChanged += new System.EventHandler(this.campoUsuario_TextChanged);
            // 
            // campoSalario
            // 
            this.campoSalario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoSalario.Location = new System.Drawing.Point(298, 435);
            this.campoSalario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoSalario.Name = "campoSalario";
            this.campoSalario.Size = new System.Drawing.Size(218, 26);
            this.campoSalario.TabIndex = 13;
            this.campoSalario.Tag = "SALARIO";
            // 
            // campoEmail
            // 
            this.campoEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoEmail.Location = new System.Drawing.Point(298, 255);
            this.campoEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(218, 26);
            this.campoEmail.TabIndex = 12;
            this.campoEmail.Tag = "EMAIL";
            // 
            // campoTelefono
            // 
            this.campoTelefono.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoTelefono.Location = new System.Drawing.Point(298, 202);
            this.campoTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(218, 26);
            this.campoTelefono.TabIndex = 11;
            this.campoTelefono.Tag = "TELÉFONO";
            // 
            // campoApellidos
            // 
            this.campoApellidos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoApellidos.Location = new System.Drawing.Point(298, 148);
            this.campoApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(218, 26);
            this.campoApellidos.TabIndex = 10;
            this.campoApellidos.Tag = "APELLIDOS";
            // 
            // CampoNombre
            // 
            this.CampoNombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CampoNombre.Location = new System.Drawing.Point(298, 97);
            this.CampoNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CampoNombre.Name = "CampoNombre";
            this.CampoNombre.Size = new System.Drawing.Size(218, 26);
            this.CampoNombre.TabIndex = 9;
            this.CampoNombre.Tag = "NOMBRE";
            // 
            // campoDni
            // 
            this.campoDni.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoDni.Location = new System.Drawing.Point(298, 43);
            this.campoDni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(218, 26);
            this.campoDni.TabIndex = 8;
            this.campoDni.Tag = "DNI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(128, 562);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(128, 506);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Usuario";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(128, 446);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Salario Base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(128, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(128, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(128, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(128, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.BackColor = System.Drawing.Color.White;
            this.panelEmpleados.Controls.Add(this.calendario);
            this.panelEmpleados.Controls.Add(this.comboTurno);
            this.panelEmpleados.Controls.Add(this.label11);
            this.panelEmpleados.Controls.Add(this.label10);
            this.panelEmpleados.Controls.Add(this.botonRegistrar);
            this.panelEmpleados.Controls.Add(this.campoPass);
            this.panelEmpleados.Controls.Add(this.campoUsuario);
            this.panelEmpleados.Controls.Add(this.campoSalario);
            this.panelEmpleados.Controls.Add(this.campoEmail);
            this.panelEmpleados.Controls.Add(this.campoTelefono);
            this.panelEmpleados.Controls.Add(this.campoApellidos);
            this.panelEmpleados.Controls.Add(this.CampoNombre);
            this.panelEmpleados.Controls.Add(this.campoDni);
            this.panelEmpleados.Controls.Add(this.label9);
            this.panelEmpleados.Controls.Add(this.label8);
            this.panelEmpleados.Controls.Add(this.label7);
            this.panelEmpleados.Controls.Add(this.label6);
            this.panelEmpleados.Controls.Add(this.label5);
            this.panelEmpleados.Controls.Add(this.label4);
            this.panelEmpleados.Controls.Add(this.label3);
            this.panelEmpleados.Controls.Add(this.label2);
            this.panelEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelEmpleados.Location = new System.Drawing.Point(321, 168);
            this.panelEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEmpleados.Size = new System.Drawing.Size(686, 725);
            this.panelEmpleados.TabIndex = 9;
            this.panelEmpleados.TabStop = false;
            this.panelEmpleados.Text = "NUEVO USUARIO";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(298, 311);
            this.calendario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(298, 26);
            this.calendario.TabIndex = 20;
            // 
            // comboTurno
            // 
            this.comboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(298, 372);
            this.comboTurno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(218, 28);
            this.comboTurno.TabIndex = 19;
            this.comboTurno.Tag = "TURNO";
            this.comboTurno.SelectedIndexChanged += new System.EventHandler(this.comboTurno_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(128, 385);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Turno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(128, 323);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha de Contrato";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonRegistrar.ForeColor = System.Drawing.Color.White;
            this.botonRegistrar.Location = new System.Drawing.Point(338, 622);
            this.botonRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(148, 42);
            this.botonRegistrar.TabIndex = 16;
            this.botonRegistrar.Text = "Registrar Usuario";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 115);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALTA DE EMPLEADOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HBergasa_ReservasHotel.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1198, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1326, 955);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEmpleados);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AltaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Empleados";
            this.panelEmpleados.ResumeLayout(false);
            this.panelEmpleados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.TextBox campoSalario;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoTelefono;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox CampoNombre;
        private System.Windows.Forms.TextBox campoDni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox panelEmpleados;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.ComboBox comboTurno;

        public void Registrar()
        {
            if (!Utilidades.ValidarDNI(campoDni.Text))
                return;

            if (campoDni.Text != campoDni.Text.ToUpper())
            {
                MessageBox.Show(this, "La letra del DNI tiene que estar en mayúscula", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(utilidades.Utilidades.CampoVacio(CampoNombre))
            {
                Utilidades.LanzarAlertaVacio(CampoNombre);
                return;
            }

            if (utilidades.Utilidades.CampoVacio(campoApellidos))
            {
                Utilidades.LanzarAlertaVacio(campoApellidos);
                return;
            }

            if (!Utilidades.ValidarTelefono(campoTelefono.Text))
                return;

            if (!Utilidades.ValidarEmail(campoEmail.Text))
                return;

            if (Utilidades.ComboVacio(comboTurno))
            {
                Utilidades.LanzarAlertaCombo(comboTurno);
                return;
            }

            if (Utilidades.CampoVacio(campoSalario))
            {
                Utilidades.LanzarAlertaVacio(campoSalario);
                return;
            }

            if (Utilidades.CampoVacio(campoUsuario))
            {
                Utilidades.LanzarAlertaVacio(campoUsuario);
                return;
            }

            if (Utilidades.CampoVacio(campoPass))
            {
                Utilidades.LanzarAlertaVacio(campoPass);
                return;
            }

            string dni = campoDni.Text;
            string nom = CampoNombre.Text;
            string ape = campoApellidos.Text;
            int tel = int.Parse(campoTelefono.Text);
            string ema = campoEmail.Text;
            DateTime fech = calendario.Value;
            string tur = comboTurno.SelectedItem.ToString();
            int sal = int.Parse(campoSalario.Text);
            string usu = campoUsuario.Text;
            string con = campoPass.Text;


            if (ConsultaEmpleados.dniDuplicado(dni))
            {
                MessageBox.Show(this, "Ese DNI ya ha sido registrado anteriormente.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado miempleado = new Empleado(dni, nom, ape, tel, ema, fech, tur, sal, usu, con);

            if (ConsultaEmpleados.RegistrarEmpleado(miempleado))
            {
                MessageBox.Show(this, "Usuario registrado correctamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(this, "ERROR EN EL REGISTRO", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            campoDni.Text = "";
            CampoNombre.Text = "";
            campoApellidos.Text = "";
            campoTelefono.Text = "";
            campoEmail.Text = "";
            calendario.Checked = false;
            comboTurno.SelectedIndex = -1;
            campoSalario.Text = "";
            campoUsuario.Text = "";
            campoPass.Text = "";
        }

    }
}