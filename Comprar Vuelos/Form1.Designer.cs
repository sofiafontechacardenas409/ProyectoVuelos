namespace Comprar_Vuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboPuntoPartida = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVuelos = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboPuntoPartida
            // 
            this.cboPuntoPartida.FormattingEnabled = true;
            this.cboPuntoPartida.Location = new System.Drawing.Point(189, 80);
            this.cboPuntoPartida.Name = "cboPuntoPartida";
            this.cboPuntoPartida.Size = new System.Drawing.Size(121, 21);
            this.cboPuntoPartida.TabIndex = 0;
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(189, 160);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(121, 21);
            this.cboDestino.TabIndex = 1;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(61, 83);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(86, 13);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Punto de Partida";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(78, 160);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dtpFechaVuelos
            // 
            this.dtpFechaVuelos.AutoSize = true;
            this.dtpFechaVuelos.Location = new System.Drawing.Point(382, 90);
            this.dtpFechaVuelos.Name = "dtpFechaVuelos";
            this.dtpFechaVuelos.Size = new System.Drawing.Size(74, 13);
            this.dtpFechaVuelos.TabIndex = 5;
            this.dtpFechaVuelos.Text = "Fecha vuelos ";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(481, 174);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "RESERVAR ";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtpFechaVuelos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.cboPuntoPartida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPuntoPartida;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dtpFechaVuelos;
        private System.Windows.Forms.Button btnReservar;
    }
}

