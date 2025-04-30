namespace HBergasa_ReservasHotel.vistas
{
    partial class ListadoReservaHabitaciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.botonMostrar = new System.Windows.Forms.Button();
            this.botonActuales = new System.Windows.Forms.Button();
            this.botonHistorico = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 115);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESERVAS DE HABITACIONES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HBergasa_ReservasHotel.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(851, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filtrar por Fecha";
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabla.Location = new System.Drawing.Point(25, 202);
            this.tabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersWidth = 62;
            this.tabla.Size = new System.Drawing.Size(924, 378);
            this.tabla.TabIndex = 17;
            // 
            // botonMostrar
            // 
            this.botonMostrar.Location = new System.Drawing.Point(449, 141);
            this.botonMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(112, 35);
            this.botonMostrar.TabIndex = 19;
            this.botonMostrar.Text = "Mostrar";
            this.botonMostrar.UseVisualStyleBackColor = true;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // botonActuales
            // 
            this.botonActuales.Location = new System.Drawing.Point(599, 141);
            this.botonActuales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonActuales.Name = "botonActuales";
            this.botonActuales.Size = new System.Drawing.Size(183, 35);
            this.botonActuales.TabIndex = 20;
            this.botonActuales.Text = "Reservas Actuales";
            this.botonActuales.UseVisualStyleBackColor = true;
            this.botonActuales.Click += new System.EventHandler(this.botonActuales_Click);
            // 
            // botonHistorico
            // 
            this.botonHistorico.Location = new System.Drawing.Point(808, 141);
            this.botonHistorico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonHistorico.Name = "botonHistorico";
            this.botonHistorico.Size = new System.Drawing.Size(141, 35);
            this.botonHistorico.TabIndex = 21;
            this.botonHistorico.Text = "Ver Histórico";
            this.botonHistorico.UseVisualStyleBackColor = true;
            this.botonHistorico.Click += new System.EventHandler(this.botonHistorico_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(139, 143);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(289, 26);
            this.calendario.TabIndex = 22;
            this.calendario.Tag = "FECHA";
            // 
            // ListadoReservaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.botonHistorico);
            this.Controls.Add(this.botonActuales);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ListadoReservaHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Reservas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button botonMostrar;
        private System.Windows.Forms.Button botonActuales;
        private System.Windows.Forms.Button botonHistorico;
        private System.Windows.Forms.DateTimePicker calendario;
    }
}