namespace GameStore
{
    partial class store_iGUI2
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
            this.rentGame_button = new System.Windows.Forms.Button();
            this.AvailableOnly_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.platform_comboBox = new System.Windows.Forms.ComboBox();
            this.gameIDLabel1 = new System.Windows.Forms.Label();
            this.gamesView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // rentGame_button
            // 
            this.rentGame_button.Location = new System.Drawing.Point(358, 514);
            this.rentGame_button.Name = "rentGame_button";
            this.rentGame_button.Size = new System.Drawing.Size(75, 23);
            this.rentGame_button.TabIndex = 36;
            this.rentGame_button.Text = "Alugar Jogo";
            this.rentGame_button.UseVisualStyleBackColor = true;
            // 
            // AvailableOnly_checkBox
            // 
            this.AvailableOnly_checkBox.AutoSize = true;
            this.AvailableOnly_checkBox.Location = new System.Drawing.Point(358, 41);
            this.AvailableOnly_checkBox.Name = "AvailableOnly_checkBox";
            this.AvailableOnly_checkBox.Size = new System.Drawing.Size(121, 17);
            this.AvailableOnly_checkBox.TabIndex = 35;
            this.AvailableOnly_checkBox.Text = "Apenas Disponíveis";
            this.AvailableOnly_checkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Plataforma:";
            // 
            // platform_comboBox
            // 
            this.platform_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platform_comboBox.FormattingEnabled = true;
            this.platform_comboBox.Items.AddRange(new object[] {
            "Todas"});
            this.platform_comboBox.Location = new System.Drawing.Point(204, 37);
            this.platform_comboBox.MaxDropDownItems = 100;
            this.platform_comboBox.Name = "platform_comboBox";
            this.platform_comboBox.Size = new System.Drawing.Size(121, 21);
            this.platform_comboBox.TabIndex = 33;
            // 
            // gameIDLabel1
            // 
            this.gameIDLabel1.Location = new System.Drawing.Point(77, 27);
            this.gameIDLabel1.Name = "gameIDLabel1";
            this.gameIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.gameIDLabel1.TabIndex = 21;
            // 
            // gamesView
            // 
            this.gamesView.Location = new System.Drawing.Point(29, 85);
            this.gamesView.Name = "gamesView";
            this.gamesView.Size = new System.Drawing.Size(510, 405);
            this.gamesView.TabIndex = 32;
            this.gamesView.UseCompatibleStateImageBehavior = false;
            this.gamesView.View = System.Windows.Forms.View.Details;
            // 
            // store_iGUI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 565);
            this.Controls.Add(this.rentGame_button);
            this.Controls.Add(this.AvailableOnly_checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platform_comboBox);
            this.Controls.Add(this.gameIDLabel1);
            this.Controls.Add(this.gamesView);
            this.Name = "store_iGUI2";
            this.Text = "store_iGUI2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rentGame_button;
        private System.Windows.Forms.CheckBox AvailableOnly_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox platform_comboBox;
        private System.Windows.Forms.Label gameIDLabel1;
        private System.Windows.Forms.ListView gamesView;
    }
}