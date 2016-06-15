namespace GameStore
{
    partial class Store_iGUI
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.chk_opt_RPG = new System.Windows.Forms.CheckBox();
            this.check_opt_Action = new System.Windows.Forms.CheckBox();
            this.check_opt_Adventure = new System.Windows.Forms.CheckBox();
            this.check_opt_shooter = new System.Windows.Forms.CheckBox();
            this.check_opt_sports = new System.Windows.Forms.CheckBox();
            this.check_opt_racing = new System.Windows.Forms.CheckBox();
            this.check_opt_puzzles = new System.Windows.Forms.CheckBox();
            this.check_opt_strategy = new System.Windows.Forms.CheckBox();
            this.gamesView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.storeDatabaseDataSet = new GameStore.storeDatabaseDataSet();
            this.gameTableTableAdapter = new GameStore.storeDatabaseDataSetTableAdapters.GameTableTableAdapter();
            this.tableAdapterManager = new GameStore.storeDatabaseDataSetTableAdapters.TableAdapterManager();
            this.gameIDLabel1 = new System.Windows.Forms.Label();
            this.platform_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AvailableOnly_checkBox = new System.Windows.Forms.CheckBox();
            this.ShowGame_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alugadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_btn = new System.Windows.Forms.Button();
            this.gameTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.storeDatabaseDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(350, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(195, 20);
            this.txt_search.TabIndex = 2;
            this.txt_search.Text = "Digite o nome do jogo";
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // chk_opt_RPG
            // 
            this.chk_opt_RPG.AutoSize = true;
            this.chk_opt_RPG.Checked = true;
            this.chk_opt_RPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_opt_RPG.Location = new System.Drawing.Point(529, 232);
            this.chk_opt_RPG.Name = "chk_opt_RPG";
            this.chk_opt_RPG.Size = new System.Drawing.Size(49, 17);
            this.chk_opt_RPG.TabIndex = 3;
            this.chk_opt_RPG.Text = "RPG";
            this.chk_opt_RPG.UseVisualStyleBackColor = true;
            this.chk_opt_RPG.CheckedChanged += new System.EventHandler(this.chk_opt_RPG_CheckedChanged);
            // 
            // check_opt_Action
            // 
            this.check_opt_Action.AutoSize = true;
            this.check_opt_Action.Checked = true;
            this.check_opt_Action.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_opt_Action.Location = new System.Drawing.Point(529, 71);
            this.check_opt_Action.Name = "check_opt_Action";
            this.check_opt_Action.Size = new System.Drawing.Size(51, 17);
            this.check_opt_Action.TabIndex = 4;
            this.check_opt_Action.Text = "Ação";
            this.check_opt_Action.UseVisualStyleBackColor = true;
            this.check_opt_Action.CheckedChanged += new System.EventHandler(this.check_opt_Action_CheckedChanged);
            // 
            // check_opt_Adventure
            // 
            this.check_opt_Adventure.AutoSize = true;
            this.check_opt_Adventure.Checked = true;
            this.check_opt_Adventure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_opt_Adventure.Location = new System.Drawing.Point(529, 94);
            this.check_opt_Adventure.Name = "check_opt_Adventure";
            this.check_opt_Adventure.Size = new System.Drawing.Size(69, 17);
            this.check_opt_Adventure.TabIndex = 5;
            this.check_opt_Adventure.Text = "Aventura";
            this.check_opt_Adventure.UseVisualStyleBackColor = true;
            this.check_opt_Adventure.CheckedChanged += new System.EventHandler(this.check_opt_Adventure_CheckedChanged);
            // 
            // check_opt_shooter
            // 
            this.check_opt_shooter.AutoSize = true;
            this.check_opt_shooter.Checked = true;
            this.check_opt_shooter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_opt_shooter.Location = new System.Drawing.Point(529, 209);
            this.check_opt_shooter.Name = "check_opt_shooter";
            this.check_opt_shooter.Size = new System.Drawing.Size(63, 17);
            this.check_opt_shooter.TabIndex = 6;
            this.check_opt_shooter.Text = "Shooter";
            this.check_opt_shooter.UseVisualStyleBackColor = true;
            this.check_opt_shooter.CheckedChanged += new System.EventHandler(this.check_opt_shooter_CheckedChanged);
            // 
            // check_opt_sports
            // 
            this.check_opt_sports.AutoSize = true;
            this.check_opt_sports.Checked = true;
            this.check_opt_sports.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_opt_sports.Location = new System.Drawing.Point(529, 140);
            this.check_opt_sports.Name = "check_opt_sports";
            this.check_opt_sports.Size = new System.Drawing.Size(67, 17);
            this.check_opt_sports.TabIndex = 7;
            this.check_opt_sports.Text = "Esportes";
            this.check_opt_sports.UseVisualStyleBackColor = true;
            this.check_opt_sports.CheckedChanged += new System.EventHandler(this.check_opt_sports_CheckedChanged);
            // 
            // check_opt_racing
            // 
            this.check_opt_racing.AutoSize = true;
            this.check_opt_racing.Checked = true;
            this.check_opt_racing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_opt_racing.Location = new System.Drawing.Point(529, 117);
            this.check_opt_racing.Name = "check_opt_racing";
            this.check_opt_racing.Size = new System.Drawing.Size(59, 17);
            this.check_opt_racing.TabIndex = 8;
            this.check_opt_racing.Text = "Corrida";
            this.check_opt_racing.UseVisualStyleBackColor = true;
            this.check_opt_racing.CheckedChanged += new System.EventHandler(this.check_opt_racing_CheckedChanged);
            // 
            // check_opt_puzzles
            // 
            this.check_opt_puzzles.AutoSize = true;
            this.check_opt_puzzles.Checked = true;
            this.check_opt_puzzles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_opt_puzzles.Location = new System.Drawing.Point(529, 186);
            this.check_opt_puzzles.Name = "check_opt_puzzles";
            this.check_opt_puzzles.Size = new System.Drawing.Size(62, 17);
            this.check_opt_puzzles.TabIndex = 9;
            this.check_opt_puzzles.Text = "Puzzles";
            this.check_opt_puzzles.UseVisualStyleBackColor = true;
            this.check_opt_puzzles.CheckedChanged += new System.EventHandler(this.check_opt_puzzles_CheckedChanged);
            // 
            // check_opt_strategy
            // 
            this.check_opt_strategy.AutoSize = true;
            this.check_opt_strategy.Checked = true;
            this.check_opt_strategy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_opt_strategy.Location = new System.Drawing.Point(529, 163);
            this.check_opt_strategy.Name = "check_opt_strategy";
            this.check_opt_strategy.Size = new System.Drawing.Size(73, 17);
            this.check_opt_strategy.TabIndex = 10;
            this.check_opt_strategy.Text = "Estratégia";
            this.check_opt_strategy.UseVisualStyleBackColor = true;
            this.check_opt_strategy.CheckedChanged += new System.EventHandler(this.check_opt_strategy_CheckedChanged);
            // 
            // gamesView
            // 
            this.gamesView.HideSelection = false;
            this.gamesView.LargeImageList = this.imageList1;
            this.gamesView.Location = new System.Drawing.Point(12, 70);
            this.gamesView.MultiSelect = false;
            this.gamesView.Name = "gamesView";
            this.gamesView.Size = new System.Drawing.Size(510, 405);
            this.gamesView.SmallImageList = this.imageList1;
            this.gamesView.TabIndex = 11;
            this.gamesView.UseCompatibleStateImageBehavior = false;
            this.gamesView.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // storeDatabaseDataSet
            // 
            this.storeDatabaseDataSet.DataSetName = "storeDatabaseDataSet";
            this.storeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameTableTableAdapter
            // 
            this.gameTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FisGameTableTableAdapter = null;
            this.tableAdapterManager.GameTableTableAdapter = null;
            this.tableAdapterManager.OperationsTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GameStore.storeDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableTableAdapter = null;
            // 
            // gameIDLabel1
            // 
            this.gameIDLabel1.Location = new System.Drawing.Point(198, 12);
            this.gameIDLabel1.Name = "gameIDLabel1";
            this.gameIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.gameIDLabel1.TabIndex = 1;
            // 
            // platform_comboBox
            // 
            this.platform_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platform_comboBox.FormattingEnabled = true;
            this.platform_comboBox.Items.AddRange(new object[] {
            "Todas"});
            this.platform_comboBox.Location = new System.Drawing.Point(78, 45);
            this.platform_comboBox.MaxDropDownItems = 100;
            this.platform_comboBox.Name = "platform_comboBox";
            this.platform_comboBox.Size = new System.Drawing.Size(121, 21);
            this.platform_comboBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plataforma:";
            // 
            // AvailableOnly_checkBox
            // 
            this.AvailableOnly_checkBox.AutoSize = true;
            this.AvailableOnly_checkBox.Location = new System.Drawing.Point(350, 47);
            this.AvailableOnly_checkBox.Name = "AvailableOnly_checkBox";
            this.AvailableOnly_checkBox.Size = new System.Drawing.Size(121, 17);
            this.AvailableOnly_checkBox.TabIndex = 18;
            this.AvailableOnly_checkBox.Text = "Apenas Disponíveis";
            this.AvailableOnly_checkBox.UseVisualStyleBackColor = true;
            // 
            // ShowGame_button
            // 
            this.ShowGame_button.Location = new System.Drawing.Point(529, 522);
            this.ShowGame_button.Name = "ShowGame_button";
            this.ShowGame_button.Size = new System.Drawing.Size(75, 23);
            this.ShowGame_button.TabIndex = 19;
            this.ShowGame_button.Text = "Mostrar Jogos";
            this.ShowGame_button.UseVisualStyleBackColor = true;
            this.ShowGame_button.Click += new System.EventHandler(this.ShowGame_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaContaToolStripMenuItem,
            this.bibliotecaToolStripMenuItem,
            this.históricoToolStripMenuItem,
            this.emprestarJogoToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // minhaContaToolStripMenuItem
            // 
            this.minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            this.minhaContaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.minhaContaToolStripMenuItem.Text = "Minha Conta";
            // 
            // bibliotecaToolStripMenuItem
            // 
            this.bibliotecaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alugadosToolStripMenuItem,
            this.emprestadosToolStripMenuItem});
            this.bibliotecaToolStripMenuItem.Name = "bibliotecaToolStripMenuItem";
            this.bibliotecaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bibliotecaToolStripMenuItem.Text = "Meus Jogos";
            // 
            // alugadosToolStripMenuItem
            // 
            this.alugadosToolStripMenuItem.Name = "alugadosToolStripMenuItem";
            this.alugadosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.alugadosToolStripMenuItem.Text = "Alugados";
            // 
            // emprestadosToolStripMenuItem
            // 
            this.emprestadosToolStripMenuItem.Name = "emprestadosToolStripMenuItem";
            this.emprestadosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.emprestadosToolStripMenuItem.Text = "Emprestados";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            // 
            // emprestarJogoToolStripMenuItem
            // 
            this.emprestarJogoToolStripMenuItem.Name = "emprestarJogoToolStripMenuItem";
            this.emprestarJogoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.emprestarJogoToolStripMenuItem.Text = "Emprestar Jogo";
            this.emprestarJogoToolStripMenuItem.Click += new System.EventHandler(this.emprestarJogoToolStripMenuItem_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.Transparent;
            this.Search_btn.BackgroundImage = global::GameStore.Properties.Resources.search_lupa;
            this.Search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Location = new System.Drawing.Point(550, 12);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(45, 43);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Store_iGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(615, 557);
            this.Controls.Add(this.ShowGame_button);
            this.Controls.Add(this.AvailableOnly_checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platform_comboBox);
            this.Controls.Add(this.gameIDLabel1);
            this.Controls.Add(this.gamesView);
            this.Controls.Add(this.check_opt_strategy);
            this.Controls.Add(this.check_opt_puzzles);
            this.Controls.Add(this.check_opt_racing);
            this.Controls.Add(this.check_opt_sports);
            this.Controls.Add(this.check_opt_shooter);
            this.Controls.Add(this.check_opt_Adventure);
            this.Controls.Add(this.check_opt_Action);
            this.Controls.Add(this.chk_opt_RPG);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Store_iGUI";
            this.Text = "ES Games";
            this.Load += new System.EventHandler(this.Store_iGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDatabaseDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.CheckBox chk_opt_RPG;
        private System.Windows.Forms.CheckBox check_opt_Action;
        private System.Windows.Forms.CheckBox check_opt_Adventure;
        private System.Windows.Forms.CheckBox check_opt_shooter;
        private System.Windows.Forms.CheckBox check_opt_sports;
        private System.Windows.Forms.CheckBox check_opt_racing;
        private System.Windows.Forms.CheckBox check_opt_puzzles;
        private System.Windows.Forms.CheckBox check_opt_strategy;
        private System.Windows.Forms.ListView gamesView;
        private System.Windows.Forms.ImageList imageList1;
        private storeDatabaseDataSet storeDatabaseDataSet;
        private System.Windows.Forms.BindingSource gameTableBindingSource;
        private storeDatabaseDataSetTableAdapters.GameTableTableAdapter gameTableTableAdapter;
        private storeDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label gameIDLabel1;
        private System.Windows.Forms.ComboBox platform_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AvailableOnly_checkBox;
        private System.Windows.Forms.Button ShowGame_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alugadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestarJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}