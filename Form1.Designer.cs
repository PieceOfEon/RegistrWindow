namespace RegistrWindow
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.Registr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(158, 96);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(25, 13);
            this.Log.TabIndex = 2;
            this.Log.Text = "Log";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(158, 157);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(30, 13);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "Pass";
            // 
            // Registr
            // 
            this.Registr.AutoSize = true;
            this.Registr.Location = new System.Drawing.Point(307, 293);
            this.Registr.Name = "Registr";
            this.Registr.Size = new System.Drawing.Size(40, 13);
            this.Registr.TabIndex = 4;
            this.Registr.Text = "Registr";
            this.Registr.Click += new System.EventHandler(this.Registr_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(223, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пароль должен быть минимум из 9 символов и содрежать один из следующих знаков \r\n[" +
    "!],[_],[+],[@],[$]\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Programmer",
            "Designer",
            "Manager",
            "BlaBla",
            "Lala",
            "oOoo"});
            this.comboBox1.Location = new System.Drawing.Point(216, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Profession";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registr);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label Registr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

