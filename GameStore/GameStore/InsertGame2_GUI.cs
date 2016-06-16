using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GameStore
{
    public partial class InsertGame2_GUI : Form
    {
        private ushort genre = 0x00;
        private string GameName;
        private int GameId;
        private Bitmap cover = null;

        public InsertGame2_GUI(string name, int id)
        {
            InitializeComponent();
            GameName = name;
            GameId = id;
            this.DialogResult = DialogResult.No;
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
            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand comm = new SqlCommand("INSERT INTO GameTable (GameId, Name, Developer, ReleaseYear, Genre, Description, Image)  Values (" + GameId.ToString() + ",'" + GameName + "','" + Developer_textBox.Text + "'," + int.Parse(ReleaseYear_textBox.Text).ToString()+ ",'" + genre + "','" + Description_textBox.Text + "','" + capa_openFileDialog.FileName +"');", con);
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(capa_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cover = new Bitmap(capa_openFileDialog.FileName);
                cover_pictureBox.Image = cover;
            }
        }
    }
}
