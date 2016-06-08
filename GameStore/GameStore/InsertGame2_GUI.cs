using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class InsertGame2_GUI : Form
    {
        private ushort genre = 0x00;
        private string GameName;
        private int GameId;

        public InsertGame2_GUI(string name, int id)
        {
            InitializeComponent();
            GameName = name;
            GameId = id;
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
            int FisGameId;      //tem q pegar do openfiledialog
            Image cover = Image.FromFile("..\\..\\Resources\\search_lupa.png");

            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("Insert Into GameTable (GameId, Name, Developer, ReleaseYear, Gender, Description, Image) Values (" + GameId.ToString() + "," + GameName + "," + Developer_textBox.ToString() + "," + ReleaseYear_textBox.ToString() + "," + genre.ToString() + "," + Description_textBox.Text + "," + cover.ToString() + ")", con);
            try
            {
                con.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
