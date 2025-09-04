namespace Parcial
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblImpuestoActividad = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 58);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE LA CANTIDAD ECONOMICA";
            // 
            // lblImpuestoActividad
            // 
            this.lblImpuestoActividad.AutoSize = true;
            this.lblImpuestoActividad.Location = new System.Drawing.Point(412, 307);
            this.lblImpuestoActividad.Name = "lblImpuestoActividad";
            this.lblImpuestoActividad.Size = new System.Drawing.Size(113, 13);
            this.lblImpuestoActividad.TabIndex = 1;
            this.lblImpuestoActividad.Text = "IMPUESTO A PAGAR";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(347, 143);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(100, 20);
            this.txtActividad.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(213, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(195, 52);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR:";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(487, 240);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 52);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.lblImpuestoActividad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImpuestoActividad;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

