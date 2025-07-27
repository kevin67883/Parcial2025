namespace kkk
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
            btncalcular = new Button();
            lblnum1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            lblcalcular = new Label();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(342, 218);
            btncalcular.Name = "btncalcular";
            btncalcular.RightToLeft = RightToLeft.No;
            btncalcular.Size = new Size(161, 70);
            btncalcular.TabIndex = 0;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Location = new Point(290, 73);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(43, 15);
            lblnum1.TabIndex = 1;
            lblnum1.Text = "Num 1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(483, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 119);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label1";
            // 
            // lblcalcular
            // 
            lblcalcular.AutoSize = true;
            lblcalcular.Location = new Point(290, 119);
            lblcalcular.Name = "lblcalcular";
            lblcalcular.Size = new Size(43, 15);
            lblcalcular.TabIndex = 1;
            lblcalcular.Text = "Num 2";
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(483, 75);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(100, 23);
            txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(483, 104);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(100, 23);
            txtnum2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(textBox1);
            Controls.Add(lblcalcular);
            Controls.Add(label2);
            Controls.Add(lblnum1);
            Controls.Add(btncalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Label lblnum1;
        private TextBox textBox1;
        private Label label2;
        private Label lblcalcular;
        private TextBox txtnum1;
        private TextBox txtnum2;
    }
}
