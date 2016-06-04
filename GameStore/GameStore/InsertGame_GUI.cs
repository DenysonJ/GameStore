using System;
using System.Windows.Forms;

namespace GameStore
{
    public partial class InsertGame_GUI : Form
    {

        public GameManager gm = new GameManager();

        public ushort genre = 0x00;

        public InsertGame_GUI()
        {
            InitializeComponent();
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

        private void button_insertgame_Click(object sender, EventArgs e)
        {
            Games new_game = new Games();
            new_game.name = text_game_name.Text;
            new_game.releaseYear = int.Parse(text_releaseyear.Text);
            new_game.gameAge = int.Parse(text_gameage.Text);
            new_game.description = text_description.Text;
            new_game.genre = genre;
            new_game.image_name = ".\\data\\images\\" + text_imagename.Text;
            gm.insert_new_game(new_game);
            Hide();
        }
    }
}
