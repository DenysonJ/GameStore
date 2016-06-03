using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameStore
{
    public partial class Store_iGUI : Form
    {
        public int genre = 0x00;
        private GameManager game_manager = new GameManager();

        public Store_iGUI()
        {
            InitializeComponent();
        }

        private void Store_iGUI_Load(object sender, EventArgs e)
        {
            gamesView.View = View.Details;
            imageList1.ImageSize = new Size(64, 64);

            game_manager.LoadGameList();

            gamesView.Columns.Add(" ", 80);
            gamesView.Columns.Add("Nome");
            gamesView.Columns.Add("Ano");

            int j = 0;
            foreach (Games game in game_manager.gameList)
            {

                ListViewItem item = new ListViewItem();

                imageList1.Images.Add(Image.FromFile(game.image_name));

                item.ImageIndex = j;
                item.SubItems.Add(game.name);
                item.SubItems.Add(game.releaseYear.ToString());

                gamesView.Items.Add(item);

                j++;
            }

            gamesView.LargeImageList = imageList1;

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if(txt_search.Text != string.Empty)
            {
                List<Games> gameList = new List<Games>();
                gameList = game_manager.SearchGameByName(txt_search.Text);

                gamesView.Clear();

                gamesView.View = View.Details;
                imageList1.ImageSize = new Size(64, 64);

                gamesView.Columns.Add(" ", 80);
                gamesView.Columns.Add("Nome");
                gamesView.Columns.Add("Ano");

                int j = 0;
                foreach (Games game in gameList)
                {

                    ListViewItem item = new ListViewItem();

                    imageList1.Images.Add(Image.FromFile(game.image_name));

                    item.ImageIndex = j;
                    item.SubItems.Add(game.name);
                    item.SubItems.Add(game.releaseYear.ToString());

                    gamesView.Items.Add(item);

                    j++;
                }
            }
        }

        private void check_opt_Action_CheckedChanged(object sender, EventArgs e)
        {
            genre ^= Constants.game_type_action; //flip the option
        }

        private void check_opt_Adventure_CheckedChanged(object sender, EventArgs e)
        {
            genre ^= Constants.game_type_adventure;
        }

        private void check_opt_racing_CheckedChanged(object sender, EventArgs e)
        {
            genre ^= Constants.game_type_racing;
        }

        private void check_opt_sports_CheckedChanged(object sender, EventArgs e)
        {
            genre ^= Constants.game_type_sports;
        }

        private void check_opt_strategy_CheckedChanged(object sender, EventArgs e)
        {
            genre ^= Constants.game_type_strategy;
        }

        private void check_opt_puzzles_CheckedChanged(object sender, EventArgs e)
        {
            genre ^= Constants.game_type_puzzle;
        }

        private void check_opt_shooter_CheckedChanged(object sender, EventArgs e)
        {
            genre ^= Constants.game_type_shooter;
        }

        private void chk_opt_RPG_CheckedChanged(object sender, EventArgs e)
        {
            genre ^= Constants.game_type_RPG;
        }

        private void Store_iGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Digite o nome do jogo")
                txt_search.Text = string.Empty;
            
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == string.Empty)
                txt_search.Text = "Digite o nome do jogo";
        }
    }
}
