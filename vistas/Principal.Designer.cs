namespace HBergasa_ReservasHotel.vistas
{
    partial class Principal
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
            this.botonListaEmpleados = new System.Windows.Forms.Button();
            this.botonListaSalones = new System.Windows.Forms.Button();
            this.botonListaHabitaciones = new System.Windows.Forms.Button();
            this.botonAltaEmpleados = new System.Windows.Forms.Button();
            this.botonReservaSalones = new System.Windows.Forms.Button();
            this.botonReservaHabitaciones = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.labelBienvenida);
            this.panel1.Controls.Add(this.botonListaEmpleados);
            this.panel1.Controls.Add(this.botonListaSalones);
            this.panel1.Controls.Add(this.botonListaHabitaciones);
            this.panel1.Controls.Add(this.botonAltaEmpleados);
            this.panel1.Controls.Add(this.botonReservaSalones);
            this.panel1.Controls.Add(this.botonReservaHabitaciones);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 189);
            this.panel1.TabIndex = 1;
            // 
            // botonListaEmpleados
            // 
            this.botonListaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonListaEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonListaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonListaEmpleados.Location = new System.Drawing.Point(1013, 38);
            this.botonListaEmpleados.Name = "botonListaEmpleados";
            this.botonListaEmpleados.Size = new System.Drawing.Size(159, 108);
            this.botonListaEmpleados.TabIndex = 5;
            this.botonListaEmpleados.Text = "Ver Empleados";
            this.botonListaEmpleados.UseVisualStyleBackColor = false;
            this.botonListaEmpleados.Click += new System.EventHandler(this.botonListaEmpleados_Click);
            // 
            // botonListaSalones
            // 
            this.botonListaSalones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonListaSalones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonListaSalones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonListaSalones.Location = new System.Drawing.Point(808, 38);
            this.botonListaSalones.Name = "botonListaSalones";
            this.botonListaSalones.Size = new System.Drawing.Size(159, 108);
            this.botonListaSalones.TabIndex = 4;
            this.botonListaSalones.Text = "Ver Reservas \r\nde Salones";
            this.botonListaSalones.UseVisualStyleBackColor = false;
            this.botonListaSalones.Click += new System.EventHandler(this.botonListaSalones_Click);
            // 
            // botonListaHabitaciones
            // 
            this.botonListaHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonListaHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonListaHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonListaHabitaciones.Location = new System.Drawing.Point(610, 38);
            this.botonListaHabitaciones.Name = "botonListaHabitaciones";
            this.botonListaHabitaciones.Size = new System.Drawing.Size(159, 108);
            this.botonListaHabitaciones.TabIndex = 3;
            this.botonListaHabitaciones.Text = "Ver Reservas\r\nde Habitaciones";
            this.botonListaHabitaciones.UseVisualStyleBackColor = false;
            this.botonListaHabitaciones.Click += new System.EventHandler(this.botonListaHabitaciones_Click);
            // 
            // botonAltaEmpleados
            // 
            this.botonAltaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonAltaEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAltaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonAltaEmpleados.Location = new System.Drawing.Point(405, 38);
            this.botonAltaEmpleados.Name = "botonAltaEmpleados";
            this.botonAltaEmpleados.Size = new System.Drawing.Size(159, 108);
            this.botonAltaEmpleados.TabIndex = 2;
            this.botonAltaEmpleados.Text = "Alta de Empleados";
            this.botonAltaEmpleados.UseVisualStyleBackColor = false;
            this.botonAltaEmpleados.Click += new System.EventHandler(this.botonAltaEmpleados_Click);
            // 
            // botonReservaSalones
            // 
            this.botonReservaSalones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonReservaSalones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonReservaSalones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonReservaSalones.Location = new System.Drawing.Point(209, 38);
            this.botonReservaSalones.Name = "botonReservaSalones";
            this.botonReservaSalones.Size = new System.Drawing.Size(159, 108);
            this.botonReservaSalones.TabIndex = 1;
            this.botonReservaSalones.Text = "Reserva \r\nde Salones";
            this.botonReservaSalones.UseVisualStyleBackColor = false;
            this.botonReservaSalones.Click += new System.EventHandler(this.botonReservaSalones_Click);
            // 
            // botonReservaHabitaciones
            // 
            this.botonReservaHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonReservaHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonReservaHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonReservaHabitaciones.Location = new System.Drawing.Point(12, 38);
            this.botonReservaHabitaciones.Name = "botonReservaHabitaciones";
            this.botonReservaHabitaciones.Size = new System.Drawing.Size(159, 108);
            this.botonReservaHabitaciones.TabIndex = 0;
            this.botonReservaHabitaciones.Text = "Reserva \r\nde Habitaciones";
            this.botonReservaHabitaciones.UseVisualStyleBackColor = false;
            this.botonReservaHabitaciones.Click += new System.EventHandler(this.botonReservaHabitaciones_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::HBergasa_ReservasHotel.Properties.Resources.hotel1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1186, 701);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBienvenida.Location = new System.Drawing.Point(13, 4);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(0, 13);
            this.labelBienvenida.TabIndex = 6;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonListaEmpleados;
        private System.Windows.Forms.Button botonListaSalones;
        private System.Windows.Forms.Button botonListaHabitaciones;
        private System.Windows.Forms.Button botonAltaEmpleados;
        private System.Windows.Forms.Button botonReservaSalones;
        private System.Windows.Forms.Button botonReservaHabitaciones;
        private System.Windows.Forms.Label labelBienvenida;
    }
}