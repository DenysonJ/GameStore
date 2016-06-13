namespace GameStore
{
    partial class deleteUser_GUI
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
            System.Windows.Forms.Label ownerLabel;
            this.user_comboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ownerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_comboBox
            // 
            this.user_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_comboBox.FormattingEnabled = true;
            this.user_comboBox.Location = new System.Drawing.Point(55, 53);
            this.user_comboBox.Name = "user_comboBox";
            this.user_comboBox.Size = new System.Drawing.Size(130, 21);
            this.user_comboBox.TabIndex = 37;
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(39, 24);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(165, 13);
            ownerLabel.TabIndex = 36;
            ownerLabel.Text = "Escolha o Usuário a ser removido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Deletar Usuário";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // deleteUser_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 187);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_comboBox);
            this.Controls.Add(ownerLabel);
            this.Name = "deleteUser_GUI";
            this.Text = "Deletar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox user_comboBox;
        private System.Windows.Forms.Button button1;
    }
}