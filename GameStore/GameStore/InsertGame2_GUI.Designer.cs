namespace GameStore
{
    partial class InsertGame2_GUI
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
            this.label_genre = new System.Windows.Forms.Label();
            this.check_opt_strategy = new System.Windows.Forms.CheckBox();
            this.check_opt_puzzles = new System.Windows.Forms.CheckBox();
            this.check_opt_racing = new System.Windows.Forms.CheckBox();
            this.check_opt_sports = new System.Windows.Forms.CheckBox();
            this.check_opt_shooter = new System.Windows.Forms.CheckBox();
            this.check_opt_Adventure = new System.Windows.Forms.CheckBox();
            this.check_opt_Action = new System.Windows.Forms.CheckBox();
            this.chk_opt_RPG = new System.Windows.Forms.CheckBox();
            this.button_insertgame = new System.Windows.Forms.Button();
            this.label_description = new System.Windows.Forms.Label();
            this.Developer_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReleaseYear_textBox = new System.Windows.Forms.TextBox();
            this.Title_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.capa_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cover_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cover_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Location = new System.Drawing.Point(37, 205);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(42, 13);
            this.label_genre.TabIndex = 28;
            this.label_genre.Text = "Gênero";
            // 
            // check_opt_strategy
            // 
            this.check_opt_strategy.AutoSize = true;
            this.check_opt_strategy.Location = new System.Drawing.Point(40, 236);
            this.check_opt_strategy.Name = "check_opt_strategy";
            this.check_opt_strategy.Size = new System.Drawing.Size(73, 17);
            this.check_opt_strategy.TabIndex = 27;
            this.check_opt_strategy.Text = "Estratégia";
            this.check_opt_strategy.UseVisualStyleBackColor = true;
            this.check_opt_strategy.CheckedChanged += new System.EventHandler(this.check_opt_strategy_CheckedChanged);
            // 
            // check_opt_puzzles
            // 
            this.check_opt_puzzles.AutoSize = true;
            this.check_opt_puzzles.Location = new System.Drawing.Point(40, 259);
            this.check_opt_puzzles.Name = "check_opt_puzzles";
            this.check_opt_puzzles.Size = new System.Drawing.Size(62, 17);
            this.check_opt_puzzles.TabIndex = 26;
            this.check_opt_puzzles.Text = "Puzzles";
            this.check_opt_puzzles.UseVisualStyleBackColor = true;
            this.check_opt_puzzles.CheckedChanged += new System.EventHandler(this.check_opt_puzzles_CheckedChanged);
            // 
            // check_opt_racing
            // 
            this.check_opt_racing.AutoSize = true;
            this.check_opt_racing.Location = new System.Drawing.Point(151, 282);
            this.check_opt_racing.Name = "check_opt_racing";
            this.check_opt_racing.Size = new System.Drawing.Size(59, 17);
            this.check_opt_racing.TabIndex = 25;
            this.check_opt_racing.Text = "Corrida";
            this.check_opt_racing.UseVisualStyleBackColor = true;
            this.check_opt_racing.CheckedChanged += new System.EventHandler(this.check_opt_racing_CheckedChanged);
            // 
            // check_opt_sports
            // 
            this.check_opt_sports.AutoSize = true;
            this.check_opt_sports.Location = new System.Drawing.Point(240, 259);
            this.check_opt_sports.Name = "check_opt_sports";
            this.check_opt_sports.Size = new System.Drawing.Size(67, 17);
            this.check_opt_sports.TabIndex = 24;
            this.check_opt_sports.Text = "Esportes";
            this.check_opt_sports.UseVisualStyleBackColor = true;
            this.check_opt_sports.CheckedChanged += new System.EventHandler(this.check_opt_sports_CheckedChanged);
            // 
            // check_opt_shooter
            // 
            this.check_opt_shooter.AutoSize = true;
            this.check_opt_shooter.Location = new System.Drawing.Point(40, 282);
            this.check_opt_shooter.Name = "check_opt_shooter";
            this.check_opt_shooter.Size = new System.Drawing.Size(63, 17);
            this.check_opt_shooter.TabIndex = 23;
            this.check_opt_shooter.Text = "Shooter";
            this.check_opt_shooter.UseVisualStyleBackColor = true;
            this.check_opt_shooter.CheckedChanged += new System.EventHandler(this.check_opt_shooter_CheckedChanged);
            // 
            // check_opt_Adventure
            // 
            this.check_opt_Adventure.AutoSize = true;
            this.check_opt_Adventure.Location = new System.Drawing.Point(151, 259);
            this.check_opt_Adventure.Name = "check_opt_Adventure";
            this.check_opt_Adventure.Size = new System.Drawing.Size(69, 17);
            this.check_opt_Adventure.TabIndex = 22;
            this.check_opt_Adventure.Text = "Aventura";
            this.check_opt_Adventure.UseVisualStyleBackColor = true;
            this.check_opt_Adventure.CheckedChanged += new System.EventHandler(this.check_opt_Adventure_CheckedChanged);
            // 
            // check_opt_Action
            // 
            this.check_opt_Action.AutoSize = true;
            this.check_opt_Action.Location = new System.Drawing.Point(151, 236);
            this.check_opt_Action.Name = "check_opt_Action";
            this.check_opt_Action.Size = new System.Drawing.Size(51, 17);
            this.check_opt_Action.TabIndex = 21;
            this.check_opt_Action.Text = "Ação";
            this.check_opt_Action.UseVisualStyleBackColor = true;
            this.check_opt_Action.CheckedChanged += new System.EventHandler(this.check_opt_Action_CheckedChanged);
            // 
            // chk_opt_RPG
            // 
            this.chk_opt_RPG.AutoSize = true;
            this.chk_opt_RPG.Location = new System.Drawing.Point(240, 236);
            this.chk_opt_RPG.Name = "chk_opt_RPG";
            this.chk_opt_RPG.Size = new System.Drawing.Size(49, 17);
            this.chk_opt_RPG.TabIndex = 20;
            this.chk_opt_RPG.Text = "RPG";
            this.chk_opt_RPG.UseVisualStyleBackColor = true;
            this.chk_opt_RPG.CheckedChanged += new System.EventHandler(this.chk_opt_RPG_CheckedChanged);
            // 
            // button_insertgame
            // 
            this.button_insertgame.Location = new System.Drawing.Point(174, 452);
            this.button_insertgame.Name = "button_insertgame";
            this.button_insertgame.Size = new System.Drawing.Size(75, 23);
            this.button_insertgame.TabIndex = 34;
            this.button_insertgame.Text = "Inserir Jogo";
            this.button_insertgame.UseVisualStyleBackColor = true;
            this.button_insertgame.Click += new System.EventHandler(this.button_insertgame_Click);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(44, 315);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(55, 13);
            this.label_description.TabIndex = 33;
            this.label_description.Text = "Descrição";
            // 
            // Developer_textBox
            // 
            this.Developer_textBox.Location = new System.Drawing.Point(174, 53);
            this.Developer_textBox.Name = "Developer_textBox";
            this.Developer_textBox.Size = new System.Drawing.Size(100, 20);
            this.Developer_textBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Desenvolvedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ano de Lançamento";
            // 
            // ReleaseYear_textBox
            // 
            this.ReleaseYear_textBox.Location = new System.Drawing.Point(174, 89);
            this.ReleaseYear_textBox.Name = "ReleaseYear_textBox";
            this.ReleaseYear_textBox.Size = new System.Drawing.Size(100, 20);
            this.ReleaseYear_textBox.TabIndex = 37;
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Location = new System.Drawing.Point(12, 9);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(308, 13);
            this.Title_label.TabIndex = 39;
            this.Title_label.Text = "Este jogo necessita de mais uma etapa para ser inserido na loja.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Imagem de Capa";
            // 
            // capa_openFileDialog
            // 
            this.capa_openFileDialog.FileName = "openFileDialog1";
            this.capa_openFileDialog.Title = "Abrir Imagem";
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(40, 331);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(230, 115);
            this.Description_textBox.TabIndex = 42;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(43, 452);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 43;
            this.cancel_button.Text = "Cancelar";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 44;
            this.button1.Text = "Escolher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Por favor, preencha os dados abaixo.";
            // 
            // pictureBox1
            // 
            this.cover_pictureBox.Image = global::GameStore.Properties.Resources._null;
            this.cover_pictureBox.InitialImage = global::GameStore.Properties.Resources._null;
            this.cover_pictureBox.Location = new System.Drawing.Point(144, 125);
            this.cover_pictureBox.Name = "pictureBox1";
            this.cover_pictureBox.Size = new System.Drawing.Size(90, 81);
            this.cover_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cover_pictureBox.TabIndex = 45;
            this.cover_pictureBox.TabStop = false;
            // 
            // InsertGame2_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cover_pictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReleaseYear_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Developer_textBox);
            this.Controls.Add(this.button_insertgame);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.check_opt_strategy);
            this.Controls.Add(this.check_opt_puzzles);
            this.Controls.Add(this.check_opt_racing);
            this.Controls.Add(this.check_opt_sports);
            this.Controls.Add(this.check_opt_shooter);
            this.Controls.Add(this.check_opt_Adventure);
            this.Controls.Add(this.check_opt_Action);
            this.Controls.Add(this.chk_opt_RPG);
            this.Name = "InsertGame2_GUI";
            this.Text = "Adicionar Jogo";
            ((System.ComponentModel.ISupportInitialize)(this.cover_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.CheckBox check_opt_strategy;
        private System.Windows.Forms.CheckBox check_opt_puzzles;
        private System.Windows.Forms.CheckBox check_opt_racing;
        private System.Windows.Forms.CheckBox check_opt_sports;
        private System.Windows.Forms.CheckBox check_opt_shooter;
        private System.Windows.Forms.CheckBox check_opt_Adventure;
        private System.Windows.Forms.CheckBox check_opt_Action;
        private System.Windows.Forms.CheckBox chk_opt_RPG;
        private System.Windows.Forms.Button button_insertgame;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox Developer_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReleaseYear_textBox;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog capa_openFileDialog;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox cover_pictureBox;
        private System.Windows.Forms.Label label4;
    }
}