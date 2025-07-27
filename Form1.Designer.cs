namespace calular
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(349, 220);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(184, 78);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(282, 37);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(38, 13);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "Num 1";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(282, 126);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(38, 13);
            this.lblrespuesta.TabIndex = 2;
            this.lblrespuesta.Text = "Num 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(511, 37);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(492, 126);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
    }
}

