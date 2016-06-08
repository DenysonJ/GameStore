namespace GameStore
{
    partial class Login_GUI
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
            this.Login_btn = new System.Windows.Forms.Button();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.Login_tb = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(80, 251);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(80, 30);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "Entrar";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(50, 200);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.PasswordChar = '*';
            this.Password_tb.Size = new System.Drawing.Size(135, 20);
            this.Password_tb.TabIndex = 1;
            this.Password_tb.Text = "Senha";
            this.Password_tb.Enter += new System.EventHandler(this.Password_tb_Enter);
            this.Password_tb.Leave += new System.EventHandler(this.Password_tb_Leave);
            // 
            // Login_tb
            // 
            this.Login_tb.Location = new System.Drawing.Point(50, 174);
            this.Login_tb.Name = "Login_tb";
            this.Login_tb.Size = new System.Drawing.Size(135, 20);
            this.Login_tb.TabIndex = 2;
            this.Login_tb.Text = "Login";
            this.Login_tb.Enter += new System.EventHandler(this.Login_tb_Enter);
            this.Login_tb.Leave += new System.EventHandler(this.Login_tb_Leave);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(50, 158);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(135, 13);
            this.Error.TabIndex = 3;
            this.Error.Text = "Login e/ou senha errado(s)";
            this.Error.Visible = false;
            // 
            // Login_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 361);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Login_tb);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.Login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Login_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_GUI_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_GUI_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.TextBox Login_tb;
        private System.Windows.Forms.Label Error;
    }
}

