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
            this.gamesView = new System.Windows.Forms.ListView();
            this.Cover_pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.dev_label = new System.Windows.Forms.Label();
            this.genre_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.receiver_label = new System.Windows.Forms.Label();
            this.receiver_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cover_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rentGame_button
            // 
            this.rentGame_button.Location = new System.Drawing.Point(414, 512);
            this.rentGame_button.Name = "rentGame_button";
            this.rentGame_button.Size = new System.Drawing.Size(75, 23);
            this.rentGame_button.TabIndex = 36;
            this.rentGame_button.Text = "Ok";
            this.rentGame_button.UseVisualStyleBackColor = true;
            this.rentGame_button.Click += new System.EventHandler(this.rentGame_button_Click);
            // 
            // AvailableOnly_checkBox
            // 
            this.AvailableOnly_checkBox.AutoSize = true;
            this.AvailableOnly_checkBox.Location = new System.Drawing.Point(418, 203);
            this.AvailableOnly_checkBox.Name = "AvailableOnly_checkBox";
            this.AvailableOnly_checkBox.Size = new System.Drawing.Size(121, 17);
            this.AvailableOnly_checkBox.TabIndex = 35;
            this.AvailableOnly_checkBox.Text = "Apenas Disponíveis";
            this.AvailableOnly_checkBox.UseVisualStyleBackColor = true;
            this.AvailableOnly_checkBox.CheckedChanged += new System.EventHandler(this.AvailableOnly_checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 207);
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
            this.platform_comboBox.Location = new System.Drawing.Point(289, 202);
            this.platform_comboBox.MaxDropDownItems = 100;
            this.platform_comboBox.Name = "platform_comboBox";
            this.platform_comboBox.Size = new System.Drawing.Size(121, 21);
            this.platform_comboBox.TabIndex = 33;
            this.platform_comboBox.SelectedIndexChanged += new System.EventHandler(this.platform_comboBox_SelectedIndexChanged);
            // 
            // gamesView
            // 
            this.gamesView.Location = new System.Drawing.Point(12, 229);
            this.gamesView.Name = "gamesView";
            this.gamesView.Size = new System.Drawing.Size(527, 261);
            this.gamesView.TabIndex = 32;
            this.gamesView.UseCompatibleStateImageBehavior = false;
            this.gamesView.View = System.Windows.Forms.View.Details;
            // 
            // Cover_pictureBox
            // 
            this.Cover_pictureBox.Location = new System.Drawing.Point(35, 30);
            this.Cover_pictureBox.Name = "Cover_pictureBox";
            this.Cover_pictureBox.Size = new System.Drawing.Size(182, 179);
            this.Cover_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cover_pictureBox.TabIndex = 37;
            this.Cover_pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ano de Lançamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Desenvolvedor";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Location = new System.Drawing.Point(253, 141);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(53, 13);
            this.label_genre.TabIndex = 42;
            this.label_genre.Text = "Gênero(s)";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(436, 108);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(103, 13);
            this.year_label.TabIndex = 48;
            this.year_label.Text = "Ano de Lançamento";
            // 
            // dev_label
            // 
            this.dev_label.AutoSize = true;
            this.dev_label.Location = new System.Drawing.Point(436, 73);
            this.dev_label.Name = "dev_label";
            this.dev_label.Size = new System.Drawing.Size(79, 13);
            this.dev_label.TabIndex = 47;
            this.dev_label.Text = "Desenvolvedor";
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(436, 141);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(53, 13);
            this.genre_label.TabIndex = 46;
            this.genre_label.Text = "Gênero(s)";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(317, 30);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(66, 24);
            this.name_label.TabIndex = 45;
            this.name_label.Text = "Nome";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiver_label
            // 
            this.receiver_label.AutoSize = true;
            this.receiver_label.Location = new System.Drawing.Point(32, 517);
            this.receiver_label.Name = "receiver_label";
            this.receiver_label.Size = new System.Drawing.Size(141, 13);
            this.receiver_label.TabIndex = 50;
            this.receiver_label.Text = "Usuário que receberá o jogo";
            this.receiver_label.Visible = false;
            // 
            // receiver_comboBox
            // 
            this.receiver_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receiver_comboBox.FormattingEnabled = true;
            this.receiver_comboBox.Items.AddRange(new object[] {
            "Todas"});
            this.receiver_comboBox.Location = new System.Drawing.Point(195, 514);
            this.receiver_comboBox.MaxDropDownItems = 100;
            this.receiver_comboBox.Name = "receiver_comboBox";
            this.receiver_comboBox.Size = new System.Drawing.Size(121, 21);
            this.receiver_comboBox.TabIndex = 49;
            this.receiver_comboBox.Visible = false;
            // 
            // store_iGUI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 565);
            this.Controls.Add(this.receiver_label);
            this.Controls.Add(this.receiver_comboBox);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.dev_label);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.Cover_pictureBox);
            this.Controls.Add(this.rentGame_button);
            this.Controls.Add(this.AvailableOnly_checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platform_comboBox);
            this.Controls.Add(this.gamesView);
            this.Name = "store_iGUI2";
            this.Text = "<NomeDoJogo>";
            ((System.ComponentModel.ISupportInitialize)(this.Cover_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rentGame_button;
        private System.Windows.Forms.CheckBox AvailableOnly_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox platform_comboBox;
        private System.Windows.Forms.ListView gamesView;
        private System.Windows.Forms.PictureBox Cover_pictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label dev_label;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label receiver_label;
        private System.Windows.Forms.ComboBox receiver_comboBox;
    }
}