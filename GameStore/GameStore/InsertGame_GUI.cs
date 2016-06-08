using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GameStore
{
    public partial class InsertGame_GUI : Form
    {

        public GameManager gm = new GameManager();

        public InsertGame_GUI()
        {
            InitializeComponent();
        }

        private void button_insertgame_Click(object sender, EventArgs e)
        {
            /*
            Games new_game = new Games();
            new_game.name = text_game_name.Text;
            new_game.releaseYear = int.Parse(text_releaseyear.Text);
            new_game.gameAge = int.Parse(text_gameage.Text);
            new_game.description = text_description.Text;
            new_game.genre = genre;
            new_game.image_name = ".\\data\\images\\" + text_imagename.Text;
            gm.insert_new_game(new_game);
            Hide();*/
            int FisGameId, GameId;
            bool exist;

            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM GameTable", connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable ds = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(ds);
                ds.PrimaryKey = new DataColumn[] { ds.Columns["GameID"] };
                DataRow[] foundRows = ds.Select("Name Like" + name_textBox.Text);
                if (foundRows.Length == 0)
                {
                    GameId = ds.Rows.Count;         //afinal, vai ser inserido no fim
                    exist = false;
                }
                else
                {
                    GameId = foundRows[0].Field<int>("GameID");
                    exist = true;
                }
                FisGameId = ds.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }

            if (!exist) //se o jogo não existe na gameTable, é necessário abrir a nova janela
            {
                InsertGame2_GUI insert = new InsertGame2_GUI(name_textBox.Text, GameId);
                insert.Show();
            }

            //insere na FisGameTable
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand com = new SqlCommand("Insert Into FisGameTable (FisGameId, GameId, Platform, BuyDate, Owner, Avaliation, Available) Values (" + FisGameId.ToString() + "," +  GameId.ToString() +"," + Platform_textBox.Text +"," + buyDate_dateTimePicker.Text +"," + owner_comboBox.SelectedValue.ToString() + "," + Avaliation_textBox.Text +","+ Available_checkBox.ToString() + ")", connection);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
