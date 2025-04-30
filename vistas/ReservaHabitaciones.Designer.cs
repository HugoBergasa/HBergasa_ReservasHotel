using HBergasa_ReservasHotel.bbdd;
using HBergasa_ReservasHotel.modelo;
using HBergasa_ReservasHotel.utilidades;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace HBergasa_ReservasHotel.vistas
{
    partial class ReservaHabitaciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelReserva = new System.Windows.Forms.GroupBox();
            this.calendarioSalida = new System.Windows.Forms.DateTimePicker();
            this.calendarioEntrada = new System.Windows.Forms.DateTimePicker();
            this.comboHabitacion = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.botonReserva = new System.Windows.Forms.Button();
            this.areaTexto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.botonFactura = new System.Windows.Forms.Button();
            this.panelCliente = new System.Windows.Forms.GroupBox();
            this.botonComprobar = new System.Windows.Forms.Button();
            this.campoDni = new System.Windows.Forms.TextBox();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.campoLocalidad = new System.Windows.Forms.TextBox();
            this.campoCp = new System.Windows.Forms.TextBox();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.CampoNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelReserva.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESERVA DE HABITACIONES";
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
            // panelReserva
            // 
            this.panelReserva.Controls.Add(this.calendarioSalida);
            this.panelReserva.Controls.Add(this.calendarioEntrada);
            this.panelReserva.Controls.Add(this.comboHabitacion);
            this.panelReserva.Controls.Add(this.label12);
            this.panelReserva.Controls.Add(this.label11);
            this.panelReserva.Controls.Add(this.label10);
            this.panelReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelReserva.Location = new System.Drawing.Point(20, 597);
            this.panelReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelReserva.Name = "panelReserva";
            this.panelReserva.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelReserva.Size = new System.Drawing.Size(684, 177);
            this.panelReserva.TabIndex = 2;
            this.panelReserva.TabStop = false;
            this.panelReserva.Text = "DATOS DE LA RESERVA";
            // 
            // calendarioSalida
            // 
            this.calendarioSalida.Enabled = false;
            this.calendarioSalida.Location = new System.Drawing.Point(225, 72);
            this.calendarioSalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarioSalida.Name = "calendarioSalida";
            this.calendarioSalida.Size = new System.Drawing.Size(314, 26);
            this.calendarioSalida.TabIndex = 5;
            this.calendarioSalida.Tag = "FECHA DE SALIDA";
            // 
            // calendarioEntrada
            // 
            this.calendarioEntrada.Enabled = false;
            this.calendarioEntrada.Location = new System.Drawing.Point(225, 31);
            this.calendarioEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarioEntrada.Name = "calendarioEntrada";
            this.calendarioEntrada.Size = new System.Drawing.Size(314, 26);
            this.calendarioEntrada.TabIndex = 4;
            this.calendarioEntrada.Tag = "FECHA DE ENTRADA";
            // 
            // comboHabitacion
            // 
            this.comboHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHabitacion.Enabled = false;
            this.comboHabitacion.FormattingEnabled = true;
            this.comboHabitacion.Items.AddRange(new object[] {
            "Doble",
            "Sencilla"});
            this.comboHabitacion.Location = new System.Drawing.Point(225, 115);
            this.comboHabitacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboHabitacion.Name = "comboHabitacion";
            this.comboHabitacion.Size = new System.Drawing.Size(205, 28);
            this.comboHabitacion.TabIndex = 3;
            this.comboHabitacion.Tag = "TIPO DE HABITACIÓN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 120);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tipo de Habitación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(30, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fecha de Salida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(30, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fecha de Entrada";
            // 
            // botonReserva
            // 
            this.botonReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonReserva.Enabled = false;
            this.botonReserva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonReserva.Location = new System.Drawing.Point(250, 803);
            this.botonReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonReserva.Name = "botonReserva";
            this.botonReserva.Size = new System.Drawing.Size(214, 42);
            this.botonReserva.TabIndex = 3;
            this.botonReserva.Text = "Reservar";
            this.botonReserva.UseVisualStyleBackColor = false;
            this.botonReserva.Click += new System.EventHandler(this.botonReserva_Click);
            // 
            // areaTexto
            // 
            this.areaTexto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.areaTexto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.areaTexto.Location = new System.Drawing.Point(771, 154);
            this.areaTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.areaTexto.Multiline = true;
            this.areaTexto.Name = "areaTexto";
            this.areaTexto.ReadOnly = true;
            this.areaTexto.Size = new System.Drawing.Size(516, 599);
            this.areaTexto.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(766, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(303, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "Datos de la última reserva registrada";
            // 
            // botonFactura
            // 
            this.botonFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonFactura.Enabled = false;
            this.botonFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonFactura.Location = new System.Drawing.Point(918, 788);
            this.botonFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonFactura.Name = "botonFactura";
            this.botonFactura.Size = new System.Drawing.Size(210, 35);
            this.botonFactura.TabIndex = 6;
            this.botonFactura.Text = "Generar Factura";
            this.botonFactura.UseVisualStyleBackColor = false;
            this.botonFactura.Click += new System.EventHandler(this.botonFactura_Click);
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.White;
            this.panelCliente.Controls.Add(this.botonComprobar);
            this.panelCliente.Controls.Add(this.campoDni);
            this.panelCliente.Controls.Add(this.botonRegistrar);
            this.panelCliente.Controls.Add(this.campoLocalidad);
            this.panelCliente.Controls.Add(this.campoCp);
            this.panelCliente.Controls.Add(this.campoDireccion);
            this.panelCliente.Controls.Add(this.campoEmail);
            this.panelCliente.Controls.Add(this.campoTelefono);
            this.panelCliente.Controls.Add(this.campoApellidos);
            this.panelCliente.Controls.Add(this.CampoNombre);
            this.panelCliente.Controls.Add(this.label9);
            this.panelCliente.Controls.Add(this.label8);
            this.panelCliente.Controls.Add(this.label7);
            this.panelCliente.Controls.Add(this.label6);
            this.panelCliente.Controls.Add(this.label5);
            this.panelCliente.Controls.Add(this.label4);
            this.panelCliente.Controls.Add(this.label3);
            this.panelCliente.Controls.Add(this.label2);
            this.panelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelCliente.Location = new System.Drawing.Point(20, 125);
            this.panelCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCliente.Size = new System.Drawing.Size(686, 463);
            this.panelCliente.TabIndex = 9;
            this.panelCliente.TabStop = false;
            this.panelCliente.Text = "DATOS DEL CLIENTE";
            // 
            // botonComprobar
            // 
            this.botonComprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonComprobar.ForeColor = System.Drawing.Color.White;
            this.botonComprobar.Location = new System.Drawing.Point(496, 38);
            this.botonComprobar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonComprobar.Name = "botonComprobar";
            this.botonComprobar.Size = new System.Drawing.Size(112, 35);
            this.botonComprobar.TabIndex = 18;
            this.botonComprobar.Text = "Comprobar DNI";
            this.botonComprobar.UseVisualStyleBackColor = false;
            this.botonComprobar.Click += new System.EventHandler(this.botonComprobar_Click_2);
            // 
            // campoDni
            // 
            this.campoDni.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoDni.Location = new System.Drawing.Point(226, 38);
            this.campoDni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(217, 26);
            this.campoDni.TabIndex = 17;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonRegistrar.Enabled = false;
            this.botonRegistrar.ForeColor = System.Drawing.Color.White;
            this.botonRegistrar.Location = new System.Drawing.Point(255, 405);
            this.botonRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(148, 42);
            this.botonRegistrar.TabIndex = 16;
            this.botonRegistrar.Text = "Registrar Cliente";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click_1);
            // 
            // campoLocalidad
            // 
            this.campoLocalidad.Enabled = false;
            this.campoLocalidad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoLocalidad.Location = new System.Drawing.Point(226, 352);
            this.campoLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoLocalidad.Name = "campoLocalidad";
            this.campoLocalidad.Size = new System.Drawing.Size(218, 26);
            this.campoLocalidad.TabIndex = 15;
            this.campoLocalidad.Tag = "LOCALIDAD";
            // 
            // campoCp
            // 
            this.campoCp.Enabled = false;
            this.campoCp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoCp.Location = new System.Drawing.Point(226, 308);
            this.campoCp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoCp.Name = "campoCp";
            this.campoCp.Size = new System.Drawing.Size(218, 26);
            this.campoCp.TabIndex = 14;
            this.campoCp.Tag = "CP";
            // 
            // campoDireccion
            // 
            this.campoDireccion.Enabled = false;
            this.campoDireccion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoDireccion.Location = new System.Drawing.Point(226, 263);
            this.campoDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(218, 26);
            this.campoDireccion.TabIndex = 13;
            this.campoDireccion.Tag = "DIRECCIÓN";
            // 
            // campoEmail
            // 
            this.campoEmail.Enabled = false;
            this.campoEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoEmail.Location = new System.Drawing.Point(226, 217);
            this.campoEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(218, 26);
            this.campoEmail.TabIndex = 12;
            this.campoEmail.Tag = "EMAIL";
            // 
            // campoTelefono
            // 
            this.campoTelefono.Enabled = false;
            this.campoTelefono.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoTelefono.Location = new System.Drawing.Point(226, 174);
            this.campoTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(218, 26);
            this.campoTelefono.TabIndex = 11;
            this.campoTelefono.Tag = "TELÉFONO";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Enabled = false;
            this.campoApellidos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.campoApellidos.Location = new System.Drawing.Point(226, 128);
            this.campoApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(218, 26);
            this.campoApellidos.TabIndex = 10;
            this.campoApellidos.Tag = "APELLIDOS";
            // 
            // CampoNombre
            // 
            this.CampoNombre.Enabled = false;
            this.CampoNombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CampoNombre.Location = new System.Drawing.Point(226, 78);
            this.CampoNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CampoNombre.Name = "CampoNombre";
            this.CampoNombre.Size = new System.Drawing.Size(218, 26);
            this.CampoNombre.TabIndex = 9;
            this.CampoNombre.Tag = "NOMBRE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(106, 365);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Localidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(106, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "CP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(106, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(105, 229);
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
            this.label5.Location = new System.Drawing.Point(105, 186);
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
            this.label4.Location = new System.Drawing.Point(105, 140);
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
            this.label3.Location = new System.Drawing.Point(106, 91);
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
            this.label2.Location = new System.Drawing.Point(105, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // ReservaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1326, 863);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.botonFactura);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.areaTexto);
            this.Controls.Add(this.botonReserva);
            this.Controls.Add(this.panelReserva);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ReservaHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelReserva.ResumeLayout(false);
            this.panelReserva.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox panelReserva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonReserva;
        private System.Windows.Forms.DateTimePicker calendarioSalida;
        private System.Windows.Forms.DateTimePicker calendarioEntrada;
        private System.Windows.Forms.ComboBox comboHabitacion;
        private System.Windows.Forms.TextBox areaTexto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button botonFactura;

        public void Registro()
        {
            if (!utilidades.Utilidades.ValidarDNI(campoDni.Text))
            {
                return;
            }

            if (campoDni.Text != campoDni.Text.ToUpper())
            {
                MessageBox.Show("La letra del DNI tiene que estar en mayúscula");
                return;
            }

            if (utilidades.Utilidades.CampoVacio(CampoNombre))
            {
                utilidades.Utilidades.LanzarAlertaVacio(CampoNombre);
                return;
            }

            if (utilidades.Utilidades.CampoVacio(campoApellidos))
            {
                utilidades.Utilidades.LanzarAlertaVacio(campoApellidos);
                return;
            }

            if (!utilidades.Utilidades.ValidarTelefono(campoTelefono.Text))
            {
                return;
            }

            if (!utilidades.Utilidades.ValidarEmail(campoEmail.Text))
            {
                return;
            }

            if (utilidades.Utilidades.CampoVacio(campoDireccion))
            {
                utilidades.Utilidades.LanzarAlertaVacio(campoDireccion);
                return;
            }

            if (!utilidades.Utilidades.ValidarCp(campoCp.Text))
            {
                return;
            }

            if (utilidades.Utilidades.CampoVacio(campoLocalidad))
            {
                utilidades.Utilidades.LanzarAlertaVacio(campoLocalidad);
                return;
            }

            string dni = campoDni.Text;
            string nom = CampoNombre.Text;
            string ape = campoApellidos.Text;
            int tel = int.Parse(campoTelefono.Text);
            string ema = campoEmail.Text;
            string dir = campoDireccion.Text;
            int cp = int.Parse(campoCp.Text);
            string loc = campoLocalidad.Text;

            modelo.Cliente micliente = new Cliente(dir, loc, dni, cp, nom, ape, tel, ema);

            if (bbdd.ConsultasClientes.registrarPersona(micliente))
            {
                MessageBox.Show("Cliente Registrado Correctamente");
                botonComprobar.Enabled = false;
                campoDni.Enabled = false;
                CampoNombre.Enabled = false;
                campoApellidos.Enabled = false;
                campoTelefono.Enabled = false;
                campoEmail.Enabled = false;
                campoDireccion.Enabled = false;
                campoCp.Enabled = false;
                campoLocalidad.Enabled = false;
                botonRegistrar.Enabled = false;
                calendarioEntrada.Enabled = true;
                calendarioSalida.Enabled = true;
                comboHabitacion.Enabled = true;
                botonReserva.Enabled = true;
            }
            else
            {
                MessageBox.Show("ERROR EN EL REGISTRO");
            }
        }

        private const double precioNocheSimple = 60;
        private const double precioNocheDoble = 100;
        private readonly string rutaFactura = "FacturaDeHabitaciones.txt";

        public string ObtenerTipoHabitacion()
        {
            if (comboHabitacion.SelectedItem == null) return null;

            string tipo = comboHabitacion.SelectedItem.ToString().Trim();
            return tipo == "Sencilla" || tipo == "Doble" ? tipo : null;
        }

        public int TotalNoches()
        {
            if (!calendarioEntrada.Checked || !calendarioSalida.Checked) return 0;

            TimeSpan diferencia = calendarioSalida.Value.Date - calendarioEntrada.Value.Date;
            return diferencia.Days;
        }

        public double TotalPrecio()
        {
            string tipo = ObtenerTipoHabitacion();
            int noches = TotalNoches();

            if (tipo == "Sencilla")
            {
                return noches * precioNocheSimple;
            }
            else if (tipo == "Doble")
            {
                return noches * precioNocheDoble;
            }

            return 0;
        }

        public void Reserva()
        {
            if (!utilidades.Utilidades.ValidarFechas(calendarioEntrada, calendarioSalida))
            {
                return;
            }
            if (utilidades.Utilidades.ComboVacio(comboHabitacion))
            {
                utilidades.Utilidades.LanzarAlertaCombo(comboHabitacion);
                return;
            }

            string dni = campoDni.Text;
            string dniResc = Login.dniRescatado;
            DateTime ent = calendarioEntrada.Value;
            DateTime sal=calendarioSalida.Value;
            int noc= TotalNoches();
            string tip = comboHabitacion.SelectedItem.ToString();
            double pre = TotalPrecio();

            modelo.Habitaciones mihabitacion = new Habitaciones(dni, dniResc,ent, sal,tip,noc, pre);

            if (bbdd.ConsultasHabitaciones.reservarHabitacion(mihabitacion))
            {
                MessageBox.Show("Reserva Registrada Correctamente");
                botonFactura.Enabled = true;
                areaTexto.Text = mihabitacion.ToString();
                ImprimirFactura();
            }
            else
            {
                MessageBox.Show("Error en la reserva");

            }
        }

        private FileInfo factura;

        public void CrearFichero()
        {
            factura = new FileInfo(rutaFactura);

            if (!factura.Exists)
            {
                try
                {
                    using (factura.Create()) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear archivo: {ex.Message}");
                }
            }
        }

        public void ImprimirFactura()
        {
            try
            {
                File.WriteAllText(rutaFactura, areaTexto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar factura: {ex.Message}");
            }
        }

        public void AbrirFactura()
        {
            try
            {
                if (factura.Exists)
                {
                    System.Diagnostics.Process.Start(factura.FullName);
                }
                else
                {
                    CrearFichero();
                    MessageBox.Show("Se ha creado un nuevo archivo de factura.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al abrir el archivo: ");
            }
        }


        private GroupBox panelCliente;
        private Button botonRegistrar;
        private TextBox campoLocalidad;
        private TextBox campoCp;
        private TextBox campoDireccion;
        private TextBox campoEmail;
        private TextBox campoTelefono;
        private TextBox campoApellidos;
        private TextBox CampoNombre;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox campoDni;
        private Button botonComprobar;
    }
}