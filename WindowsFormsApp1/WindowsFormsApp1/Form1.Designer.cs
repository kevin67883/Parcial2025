namespace WindowsFormsApp1
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
            this.lblsueldo = new System.Windows.Forms.Label();
            this.txtdeduccion = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblafp = new System.Windows.Forms.Label();
            this.lblisr = new System.Windows.Forms.Label();
            this.lblsueldoneto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldeducciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.Location = new System.Drawing.Point(379, 89);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(51, 13);
            this.lblsueldo.TabIndex = 0;
            this.lblsueldo.Text = "SUELDO";
            // 
            // txtdeduccion
            // 
            this.txtdeduccion.Location = new System.Drawing.Point(455, 89);
            this.txtdeduccion.Name = "txtdeduccion";
            this.txtdeduccion.Size = new System.Drawing.Size(100, 20);
            this.txtdeduccion.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(480, 192);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // lblafp
            // 
            this.lblafp.AutoSize = true;
            this.lblafp.Location = new System.Drawing.Point(379, 116);
            this.lblafp.Name = "lblafp";
            this.lblafp.Size = new System.Drawing.Size(39, 13);
            this.lblafp.TabIndex = 0;
            this.lblafp.Text = "AFP: ?";
            // 
            // lblisr
            // 
            this.lblisr.AutoSize = true;
            this.lblisr.Location = new System.Drawing.Point(379, 148);
            this.lblisr.Name = "lblisr";
            this.lblisr.Size = new System.Drawing.Size(37, 13);
            this.lblisr.TabIndex = 0;
            this.lblisr.Text = "ISR: ?";
            // 
            // lblsueldoneto
            // 
            this.lblsueldoneto.AutoSize = true;
            this.lblsueldoneto.Location = new System.Drawing.Point(379, 175);
            this.lblsueldoneto.Name = "lblsueldoneto";
            this.lblsueldoneto.Size = new System.Drawing.Size(66, 13);
            this.lblsueldoneto.TabIndex = 0;
            this.lblsueldoneto.Text = "Sueldo Neto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUELDO";
            // 
            // lbldeducciones
            // 
            this.lbldeducciones.AutoSize = true;
            this.lbldeducciones.Location = new System.Drawing.Point(379, 202);
            this.lbldeducciones.Name = "lbldeducciones";
            this.lbldeducciones.Size = new System.Drawing.Size(64, 13);
            this.lbldeducciones.TabIndex = 0;
            this.lbldeducciones.Text = "Deduciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtdeduccion);
            this.Controls.Add(this.lbldeducciones);
            this.Controls.Add(this.lblsueldoneto);
            this.Controls.Add(this.lblisr);
            this.Controls.Add(this.lblafp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsueldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.TextBox txtdeduccion;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblafp;
        private System.Windows.Forms.Label lblisr;
        private System.Windows.Forms.Label lblsueldoneto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldeducciones;
    }
}

