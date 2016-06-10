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
            this.button2 = new System.Windows.Forms.Button();
            this.button_insertgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Store_button
            // 
            this.Store_button.Location = new System.Drawing.Point(12, 56);
            this.Store_button.Name = "Store_button";
            this.Store_button.Size = new System.Drawing.Size(75, 23);
            this.Store_button.TabIndex = 0;
            this.Store_button.Text = "Loja";
            this.Store_button.UseVisualStyleBackColor = true;
            this.Store_button.Click += new System.EventHandler(this.Store_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_insertgame);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Store_button);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Store_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_insertgame;
    }
}