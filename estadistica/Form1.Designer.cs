namespace estadistica
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
            this.lblserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btnmedia_aritmetica = new System.Windows.Forms.Button();
            this.lblrespuesta_serie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(109, 60);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(42, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "SERIE.";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(170, 57);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(100, 20);
            this.txtserie.TabIndex = 1;
            // 
            // btnmedia_aritmetica
            // 
            this.btnmedia_aritmetica.Location = new System.Drawing.Point(112, 122);
            this.btnmedia_aritmetica.Name = "btnmedia_aritmetica";
            this.btnmedia_aritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnmedia_aritmetica.TabIndex = 2;
            this.btnmedia_aritmetica.Text = "Calcular x";
            this.btnmedia_aritmetica.UseVisualStyleBackColor = true;
            // 
            // lblrespuesta_serie
            // 
            this.lblrespuesta_serie.AutoSize = true;
            this.lblrespuesta_serie.Location = new System.Drawing.Point(116, 89);
            this.lblrespuesta_serie.Name = "lblrespuesta_serie";
            this.lblrespuesta_serie.Size = new System.Drawing.Size(14, 13);
            this.lblrespuesta_serie.TabIndex = 3;
            this.lblrespuesta_serie.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 262);
            this.Controls.Add(this.lblrespuesta_serie);
            this.Controls.Add(this.btnmedia_aritmetica);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "calculo basico de estadistica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btnmedia_aritmetica;
        private System.Windows.Forms.Label lblrespuesta_serie;
    }
}

