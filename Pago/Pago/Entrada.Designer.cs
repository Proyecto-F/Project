namespace Pago
{
    partial class Entrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monsters Attack!", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 107);
            this.label1.TabIndex = 9;
            this.label1.Text = "METODO DE PAGO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Monsters Attack!", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(622, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(188, 66);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Font = new System.Drawing.Font("Monsters Attack!", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectivo.Location = new System.Drawing.Point(391, 503);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(180, 66);
            this.btnEfectivo.TabIndex = 7;
            this.btnEfectivo.Text = "EFECTIVO";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Font = new System.Drawing.Font("Monsters Attack!", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjeta.Location = new System.Drawing.Point(160, 503);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(175, 66);
            this.btnTarjeta.TabIndex = 6;
            this.btnTarjeta.Text = "TARJETA";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pago.Properties.Resources.fondo4;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.btnTarjeta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

