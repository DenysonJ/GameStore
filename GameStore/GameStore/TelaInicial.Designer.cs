namespace GameStore
{
    partial class TelaInicial
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
            this.Store_button = new System.Windows.Forms.Button();
            this.deleteGame_button = new System.Windows.Forms.Button();
            this.button_insertgame = new System.Windows.Forms.Button();
            this.newUser_button = new System.Windows.Forms.Button();
            this.deleteUser_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Store_button
            // 
            this.Store_button.Location = new System.Drawing.Point(26, 96);
            this.Store_button.Name = "Store_button";
            this.Store_button.Size = new System.Drawing.Size(75, 23);
            this.Store_button.TabIndex = 0;
            this.Store_button.Text = "Loja";
            this.Store_button.UseVisualStyleBackColor = true;
            this.Store_button.Click += new System.EventHandler(this.Store_button_Click);
            // 
            // deleteGame_button
            // 
            this.deleteGame_button.Location = new System.Drawing.Point(12, 41);
            this.deleteGame_button.Name = "deleteGame_button";
            this.deleteGame_button.Size = new System.Drawing.Size(103, 23);
            this.deleteGame_button.TabIndex = 1;
            this.deleteGame_button.Text = "Excluir Jogo";
            this.deleteGame_button.UseVisualStyleBackColor = true;
            this.deleteGame_button.Click += new System.EventHandler(this.deleteGame_button_Click);
            // 
            // button_insertgame
            // 
            this.button_insertgame.Location = new System.Drawing.Point(12, 12);
            this.button_insertgame.Name = "button_insertgame";
            this.button_insertgame.Size = new System.Drawing.Size(103, 23);
            this.button_insertgame.TabIndex = 13;
            this.button_insertgame.Text = "Inserir Novo Jogo";
            this.button_insertgame.UseVisualStyleBackColor = true;
            this.button_insertgame.Click += new System.EventHandler(this.button_insertgame_Click);
            // 
            // newUser_button
            // 
            this.newUser_button.Location = new System.Drawing.Point(12, 158);
            this.newUser_button.Name = "newUser_button";
            this.newUser_button.Size = new System.Drawing.Size(103, 23);
            this.newUser_button.TabIndex = 14;
            this.newUser_button.Text = "Novo Usuário";
            this.newUser_button.UseVisualStyleBackColor = true;
            this.newUser_button.Click += new System.EventHandler(this.newUser_button_Click);
            // 
            // deleteUser_button
            // 
            this.deleteUser_button.Location = new System.Drawing.Point(12, 187);
            this.deleteUser_button.Name = "deleteUser_button";
            this.deleteUser_button.Size = new System.Drawing.Size(103, 23);
            this.deleteUser_button.TabIndex = 15;
            this.deleteUser_button.Text = "Excluir Usuário";
            this.deleteUser_button.UseVisualStyleBackColor = true;
            this.deleteUser_button.Click += new System.EventHandler(this.deleteUser_button_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.deleteUser_button);
            this.Controls.Add(this.newUser_button);
            this.Controls.Add(this.button_insertgame);
            this.Controls.Add(this.deleteGame_button);
            this.Controls.Add(this.Store_button);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Store_button;
        private System.Windows.Forms.Button deleteGame_button;
        private System.Windows.Forms.Button button_insertgame;
        private System.Windows.Forms.Button newUser_button;
        private System.Windows.Forms.Button deleteUser_button;
    }
}