namespace GameStore
{
    partial class InsertGame_GUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label platformLabel;
            System.Windows.Forms.Label buyDateLabel;
            System.Windows.Forms.Label ownerLabel;
            System.Windows.Forms.Label availableLabel;
            this.label_top = new System.Windows.Forms.Label();
            this.label_gamename = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.button_insertgame = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.Platform_textBox = new System.Windows.Forms.TextBox();
            this.buyDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.owner_comboBox = new System.Windows.Forms.ComboBox();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDatabaseDataSet1 = new GameStore.storeDatabaseDataSet();
            this.Avaliation_textBox = new System.Windows.Forms.TextBox();
            this.Available_checkBox = new System.Windows.Forms.CheckBox();
            this.userTableTableAdapter = new GameStore.storeDatabaseDataSetTableAdapters.UserTableTableAdapter();
            platformLabel = new System.Windows.Forms.Label();
            buyDateLabel = new System.Windows.Forms.Label();
            ownerLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // platformLabel
            // 
            platformLabel.AutoSize = true;
            platformLabel.Location = new System.Drawing.Point(14, 93);
            platformLabel.Name = "platformLabel";
            platformLabel.Size = new System.Drawing.Size(57, 13);
            platformLabel.TabIndex = 25;
            platformLabel.Text = "Plataforma";
            // 
            // buyDateLabel
            // 
            buyDateLabel.AutoSize = true;
            buyDateLabel.Location = new System.Drawing.Point(14, 131);
            buyDateLabel.Name = "buyDateLabel";
            buyDateLabel.Size = new System.Drawing.Size(84, 13);
            buyDateLabel.TabIndex = 26;
            buyDateLabel.Text = "Data de Compra";
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(14, 162);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(33, 13);
            ownerLabel.TabIndex = 27;
            ownerLabel.Text = "Dono";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(37, 340);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(118, 13);
            availableLabel.TabIndex = 31;
            availableLabel.Text = "Iniciar como Disponível";
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Location = new System.Drawing.Point(66, 9);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(150, 13);
            this.label_top.TabIndex = 1;
            this.label_top.Text = "Insira os Dados do Novo Jogo";
            // 
            // label_gamename
            // 
            this.label_gamename.AutoSize = true;
            this.label_gamename.Location = new System.Drawing.Point(14, 57);
            this.label_gamename.Name = "label_gamename";
            this.label_gamename.Size = new System.Drawing.Size(35, 13);
            this.label_gamename.TabIndex = 2;
            this.label_gamename.Text = "Nome";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(14, 198);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(54, 13);
            this.label_description.TabIndex = 8;
            this.label_description.Text = "Avaliação";
            // 
            // button_insertgame
            // 
            this.button_insertgame.Location = new System.Drawing.Point(188, 336);
            this.button_insertgame.Name = "button_insertgame";
            this.button_insertgame.Size = new System.Drawing.Size(75, 23);
            this.button_insertgame.TabIndex = 20;
            this.button_insertgame.Text = "Inserir Jogo";
            this.button_insertgame.UseVisualStyleBackColor = true;
            this.button_insertgame.Click += new System.EventHandler(this.button_insertgame_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(133, 54);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(130, 20);
            this.name_textBox.TabIndex = 32;
            // 
            // Platform_textBox
            // 
            this.Platform_textBox.Location = new System.Drawing.Point(133, 90);
            this.Platform_textBox.Name = "Platform_textBox";
            this.Platform_textBox.Size = new System.Drawing.Size(130, 20);
            this.Platform_textBox.TabIndex = 33;
            // 
            // buyDate_dateTimePicker
            // 
            this.buyDate_dateTimePicker.Location = new System.Drawing.Point(133, 131);
            this.buyDate_dateTimePicker.Name = "buyDate_dateTimePicker";
            this.buyDate_dateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.buyDate_dateTimePicker.TabIndex = 34;
            // 
            // owner_comboBox
            // 
            this.owner_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userTableBindingSource, "Login", true));
            this.owner_comboBox.DataSource = this.userTableBindingSource;
            this.owner_comboBox.DisplayMember = "Login";
            this.owner_comboBox.FormattingEnabled = true;
            this.owner_comboBox.Location = new System.Drawing.Point(133, 162);
            this.owner_comboBox.Name = "owner_comboBox";
            this.owner_comboBox.Size = new System.Drawing.Size(130, 21);
            this.owner_comboBox.TabIndex = 35;
            this.owner_comboBox.ValueMember = "UserID";
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.storeDatabaseDataSet1;
            // 
            // storeDatabaseDataSet1
            // 
            this.storeDatabaseDataSet1.DataSetName = "storeDatabaseDataSet";
            this.storeDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Avaliation_textBox
            // 
            this.Avaliation_textBox.Location = new System.Drawing.Point(40, 214);
            this.Avaliation_textBox.Multiline = true;
            this.Avaliation_textBox.Name = "Avaliation_textBox";
            this.Avaliation_textBox.Size = new System.Drawing.Size(223, 116);
            this.Avaliation_textBox.TabIndex = 36;
            // 
            // Available_checkBox
            // 
            this.Available_checkBox.AutoSize = true;
            this.Available_checkBox.Checked = true;
            this.Available_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Available_checkBox.Location = new System.Drawing.Point(16, 339);
            this.Available_checkBox.Name = "Available_checkBox";
            this.Available_checkBox.Size = new System.Drawing.Size(15, 14);
            this.Available_checkBox.TabIndex = 37;
            this.Available_checkBox.UseVisualStyleBackColor = true;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // InsertGame_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 379);
            this.Controls.Add(this.Available_checkBox);
            this.Controls.Add(this.Avaliation_textBox);
            this.Controls.Add(this.owner_comboBox);
            this.Controls.Add(this.buyDate_dateTimePicker);
            this.Controls.Add(this.Platform_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(availableLabel);
            this.Controls.Add(ownerLabel);
            this.Controls.Add(buyDateLabel);
            this.Controls.Add(platformLabel);
            this.Controls.Add(this.button_insertgame);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_gamename);
            this.Controls.Add(this.label_top);
            this.Name = "InsertGame_GUI";
            this.Text = "Inserir Novo Jogo";
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Label label_gamename;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button button_insertgame;
        private storeDatabaseDataSet storeDatabaseDataSet;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox Platform_textBox;
        private System.Windows.Forms.DateTimePicker buyDate_dateTimePicker;
        private System.Windows.Forms.ComboBox owner_comboBox;
        private System.Windows.Forms.TextBox Avaliation_textBox;
        private System.Windows.Forms.CheckBox Available_checkBox;
        private storeDatabaseDataSet storeDatabaseDataSet1;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private storeDatabaseDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
    }
}