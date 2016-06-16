namespace GameStore
{
    partial class newUser_GUI
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
            System.Windows.Forms.Label buyDateLabel;
            System.Windows.Forms.Label platformLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            this.cancel_button = new System.Windows.Forms.Button();
            this.birthdate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.button_insertuser = new System.Windows.Forms.Button();
            this.label_gamename = new System.Windows.Forms.Label();
            this.label_top = new System.Windows.Forms.Label();
            this.confirmPassword_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoginInvalid_label = new System.Windows.Forms.Label();
            this.senhas_incorretas_label = new System.Windows.Forms.Label();
            this.EmailInvalid_label = new System.Windows.Forms.Label();
            buyDateLabel = new System.Windows.Forms.Label();
            platformLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buyDateLabel
            // 
            buyDateLabel.AutoSize = true;
            buyDateLabel.Location = new System.Drawing.Point(12, 272);
            buyDateLabel.Name = "buyDateLabel";
            buyDateLabel.Size = new System.Drawing.Size(104, 13);
            buyDateLabel.TabIndex = 44;
            buyDateLabel.Text = "Data de Nascimento";
            // 
            // platformLabel
            // 
            platformLabel.AutoSize = true;
            platformLabel.Location = new System.Drawing.Point(12, 94);
            platformLabel.Name = "platformLabel";
            platformLabel.Size = new System.Drawing.Size(33, 13);
            platformLabel.TabIndex = 43;
            platformLabel.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 13);
            label1.TabIndex = 55;
            label1.Text = "Confirmar Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(15, 239);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 13);
            label5.TabIndex = 59;
            label5.Text = "Telefone";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(26, 311);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 53;
            this.cancel_button.Text = "Cancelar";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // birthdate_dateTimePicker
            // 
            this.birthdate_dateTimePicker.Location = new System.Drawing.Point(131, 272);
            this.birthdate_dateTimePicker.Name = "birthdate_dateTimePicker";
            this.birthdate_dateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.birthdate_dateTimePicker.TabIndex = 49;
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(131, 91);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(130, 20);
            this.Login_textBox.TabIndex = 48;
            this.Login_textBox.TextChanged += new System.EventHandler(this.Login_textBox_TextChanged);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(131, 55);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(130, 20);
            this.name_textBox.TabIndex = 47;
            // 
            // button_insertuser
            // 
            this.button_insertuser.Location = new System.Drawing.Point(159, 311);
            this.button_insertuser.Name = "button_insertuser";
            this.button_insertuser.Size = new System.Drawing.Size(90, 23);
            this.button_insertuser.TabIndex = 42;
            this.button_insertuser.Text = "Inserir Usuário";
            this.button_insertuser.UseVisualStyleBackColor = true;
            this.button_insertuser.Click += new System.EventHandler(this.button_insertuser_Click);
            // 
            // label_gamename
            // 
            this.label_gamename.AutoSize = true;
            this.label_gamename.Location = new System.Drawing.Point(12, 58);
            this.label_gamename.Name = "label_gamename";
            this.label_gamename.Size = new System.Drawing.Size(35, 13);
            this.label_gamename.TabIndex = 40;
            this.label_gamename.Text = "Nome";
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Location = new System.Drawing.Point(64, 10);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(163, 13);
            this.label_top.TabIndex = 39;
            this.label_top.Text = "Insira os Dados do Novo Usuário";
            // 
            // confirmPassword_textBox
            // 
            this.confirmPassword_textBox.Location = new System.Drawing.Point(131, 164);
            this.confirmPassword_textBox.Name = "confirmPassword_textBox";
            this.confirmPassword_textBox.PasswordChar = '*';
            this.confirmPassword_textBox.Size = new System.Drawing.Size(130, 20);
            this.confirmPassword_textBox.TabIndex = 57;
            this.confirmPassword_textBox.TextChanged += new System.EventHandler(this.confirmPassword_textBox_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(131, 128);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(130, 20);
            this.password_textBox.TabIndex = 56;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Senha";
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(131, 236);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(130, 20);
            this.phone_textBox.TabIndex = 61;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(131, 200);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(130, 20);
            this.email_textBox.TabIndex = 60;
            this.email_textBox.TextChanged += new System.EventHandler(this.email_textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "email";
            // 
            // LoginInvalid_label
            // 
            this.LoginInvalid_label.AutoSize = true;
            this.LoginInvalid_label.ForeColor = System.Drawing.Color.Red;
            this.LoginInvalid_label.Location = new System.Drawing.Point(132, 75);
            this.LoginInvalid_label.Name = "LoginInvalid_label";
            this.LoginInvalid_label.Size = new System.Drawing.Size(98, 13);
            this.LoginInvalid_label.TabIndex = 65;
            this.LoginInvalid_label.Text = "Este Login já existe";
            // 
            // senhas_incorretas_label
            // 
            this.senhas_incorretas_label.AutoSize = true;
            this.senhas_incorretas_label.ForeColor = System.Drawing.Color.Red;
            this.senhas_incorretas_label.Location = new System.Drawing.Point(132, 148);
            this.senhas_incorretas_label.Name = "senhas_incorretas_label";
            this.senhas_incorretas_label.Size = new System.Drawing.Size(124, 13);
            this.senhas_incorretas_label.TabIndex = 66;
            this.senhas_incorretas_label.Text = "As senhas não conferem";
            // 
            // EmailInvalid_label
            // 
            this.EmailInvalid_label.AutoSize = true;
            this.EmailInvalid_label.ForeColor = System.Drawing.Color.Red;
            this.EmailInvalid_label.Location = new System.Drawing.Point(131, 184);
            this.EmailInvalid_label.Name = "EmailInvalid_label";
            this.EmailInvalid_label.Size = new System.Drawing.Size(96, 13);
            this.EmailInvalid_label.TabIndex = 67;
            this.EmailInvalid_label.Text = "Este email já existe";
            // 
            // newUser_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 346);
            this.Controls.Add(this.EmailInvalid_label);
            this.Controls.Add(this.senhas_incorretas_label);
            this.Controls.Add(this.LoginInvalid_label);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirmPassword_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.birthdate_dateTimePicker);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(buyDateLabel);
            this.Controls.Add(platformLabel);
            this.Controls.Add(this.button_insertuser);
            this.Controls.Add(this.label_gamename);
            this.Controls.Add(this.label_top);
            this.Name = "newUser_GUI";
            this.Text = "Novo Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DateTimePicker birthdate_dateTimePicker;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button button_insertuser;
        private System.Windows.Forms.Label label_gamename;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.TextBox confirmPassword_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LoginInvalid_label;
        private System.Windows.Forms.Label senhas_incorretas_label;
        private System.Windows.Forms.Label EmailInvalid_label;
    }
}