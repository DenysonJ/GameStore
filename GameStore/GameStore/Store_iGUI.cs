using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GameStore
{
    public partial class Store_iGUI : Form
    {
        public int genre = 0xFFFF;
        private GameManager game_manager = new GameManager();
        private int globalimageindex = 0;

        public Store_iGUI()
        {
            InitializeComponent();
        }

        private void gamesViewClear() {
            gamesView.Clear();
            gamesView.Columns.Add("Capa", 80);
            gamesView.Columns.Add("Nome");
            gamesView.Columns.Add("Ano");
            gamesView.Columns.Add("Developer");
            gamesView.Columns.Add("Gênero");
            gamesView.Columns.Add("Descrição");
        }

        private void Store_iGUI_Load(object sender, EventArgs e)
        {
            gamesView.View = View.Details;
            imageList1.ImageSize = new Size(64, 64);

            game_manager.LoadGameList();

            gamesViewClear();

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
                
                foreach (DataRow game in ds.Rows) {
                    ListViewItem ite = new ListViewItem();
                    if (game.Field<Image>("Image") != null)
                        imageList1.Images.Add(game.Field<Image>("Image"));
                    else
                    {
                        imageList1.Images.Add(Image.FromFile("..\\..\\Resources\\null.png"));
                    }
                    ite.ImageIndex = globalimageindex++;       //pode ser sempre 0 aqui?
                    ite.SubItems.Add(game.Field<string>("Name"));
                    ite.SubItems.Add(game.Field<int>("ReleaseYear").ToString());
                    ite.SubItems.Add(game.Field<string>("Developer"));
                    ite.SubItems.Add(genreConverter(game.Field<int>("Genre")));
                    ite.SubItems.Add(game.Field<string>("Description"));

                    gamesView.Items.Add(ite);
                }

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
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            String keywords;
            if (txt_search.Text == "Digite o nome do jogo") {
                keywords = "";
            } else {
                keywords = txt_search.Text;
            }
            gamesViewClear();

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
                List<DataRow> final = new List<DataRow>();
                DataTable dt = ds.Clone();
                dt.Columns["ReleaseYear"].DataType = typeof(string);
                foreach (DataRow row in ds.Rows){
                    dt.ImportRow(row);
                }
                foreach (string token in keywords.Split(' '))      //procura no nome
                {  
                    DataRow[] foundRows;
                    foundRows = dt.Select("Name Like '%" + token + "%'");
                    foreach (DataRow row in foundRows)
                        if (!((row.Field<int>("Genre") != 0x0) && (row.Field<int>("Genre") & genre) == 0x0))
                            final.Add(row);
                }
                foreach (string token in keywords.Split(' '))    //procura na descrição
                {
                    DataRow[] foundRows;
                    foundRows = dt.Select("Description Like '%" + token + "%'");
                    
                    foreach (DataRow row in foundRows)
                        if (!final.Contains(row))
                            if (!((row.Field<int>("Genre") != 0x0) && (row.Field<int>("Genre") & genre) == 0x0))
                                final.Add(row);
                }
                foreach (string token in keywords.Split(' '))    //procura no desenvolvedor
                {
                    DataRow[] foundRows;
                    foundRows = dt.Select("Developer Like '%" + token + "%'");

                    foreach (DataRow row in foundRows)
                        if (!final.Contains(row))
                            if (!((row.Field<int>("Genre") != 0x0) && (row.Field<int>("Genre") & genre) == 0x0))
                                final.Add(row);
                }
                foreach (string token in keywords.Split(' '))    //procura no ano
                {
                    DataRow[] foundRows;
                    foundRows = dt.Select("ReleaseYear Like '%" + token + "%'");

                    foreach (DataRow row in foundRows)
                        if (!final.Contains(row))
                            if (!((row.Field<int>("Genre") != 0x0) && (row.Field<int>("Genre") & genre) == 0x0))
                                final.Add(row);
                }

                foreach (DataRow game in final)
                {
                    ShowOnGameView(game.Field<int>("GameID"));
                }
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
        }

        private void ShowOnGameView(int gameid) {   //mostra o jogo no gameview a partir da gameid

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
                ds.PrimaryKey = new DataColumn[] { ds.Columns["GameID"]};       //não sei pq, mas ao pegar a tabela da database ela perde a primary key
                DataRow game = ds.Rows.Find(gameid);
                ListViewItem item = new ListViewItem();

                item.ImageIndex = game.Field<int>("GameID");
                item.SubItems.Add(game.Field<string>("Name"));
                item.SubItems.Add(game.Field<int>("ReleaseYear").ToString());
                item.SubItems.Add(game.Field<string>("Developer")); 
                item.SubItems.Add(genreConverter(game.Field<int>("Genre")));
                item.SubItems.Add(game.Field<string>("Description"));

                gamesView.Items.Add(item);

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
        }

        private string genreConverter(int genr) { //traduz o gender de int pra string
            string Genre = "";
            Console.WriteLine(~Constants.game_type_action);
            Console.WriteLine(genr);
            Console.WriteLine((genr | (~Constants.game_type_action)));
            if (~(genr | (~Constants.game_type_action)) == 0x00)
                Genre += "Ação ";
            if (~(genr | (~Constants.game_type_adventure)) == 0x00)
                Genre += "Aventura ";
            if (~(genr | (~Constants.game_type_racing)) == 0x00)
                Genre += "Corrida ";
            if (~(genr | (~Constants.game_type_sports)) == 0x00)
                Genre += "Esportes ";
            if (~(genr | (~Constants.game_type_strategy)) == 0x00)
                Genre += "Estratégia ";
            if (~(genr | (~Constants.game_type_puzzle)) == 0x00)
                Genre += "Puzzle ";
            if (~(genr | (~Constants.game_type_shooter)) == 0x00)
                Genre += "Shooter ";
            if (~(genr | (~Constants.game_type_RPG)) == 0x00)
                Genre += "RPG ";
            
            if(Genre == "")
                 Genre = "none";

            return Genre;
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
