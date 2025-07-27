namespace Saludos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblSaludo = new Label();
            txtombre = new TextBox();
            btnSaludar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(192, 72);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(176, 239);
            lblSaludo.Margin = new Padding(5, 0, 5, 0);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(52, 25);
            lblSaludo.TabIndex = 1;
            lblSaludo.Text = "Hola";
            // 
            // txtombre
            // 
            txtombre.Location = new Point(368, 75);
            txtombre.Margin = new Padding(5, 5, 5, 5);
            txtombre.Name = "txtombre";
            txtombre.Size = new Size(155, 33);
            txtombre.TabIndex = 2;
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaludar.Location = new Point(394, 220);
            btnSaludar.Margin = new Padding(5, 5, 5, 5);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(183, 95);
            btnSaludar.TabIndex = 3;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 749);
            Controls.Add(btnSaludar);
            Controls.Add(txtombre);
            Controls.Add(lblSaludo);
            Controls.Add(lblNombre);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "btnSaludar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblSaludo;
        private TextBox txtombre;
        private Button btnSaludar;
    }
}
