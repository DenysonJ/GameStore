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
    public partial class store_iGUI2 : Form
    {
        private bool adminModeOn = false, adminRemoveOn = false;
        private int GameID, receiverID;
        private List<int> indexer = new List<int>();
        public store_iGUI2(int user, int GameId, int platformindex, bool availableonly)
        {
            InitializeComponent();
            if (user == -1)
            {
                adminModeOn = true;
            }
            else if (user >= 0)
            {
                receiverID = user;
            }
            else if (user == -2)
            {
                adminRemoveOn = true;
            }
            GameID = GameId;
            fillplatCombobox();
            platform_comboBox.SelectedIndex = platformindex;
            loadLabels();
            if (availableonly)
                AvailableOnly_checkBox.CheckState = CheckState.Checked;
            else
                AvailableOnly_checkBox.CheckState = CheckState.Unchecked;
            SearchAndShow();
            if (adminModeOn)
            {
                receiver_comboBox.Visible = true;
                receiver_label.Visible = true;
                fillreceiverCombobox();
            }
            if (adminRemoveOn)
            {
                rentGame_button.Text = "Excluir Jogo";
            }
        }
        private void fillreceiverCombobox()
        {
            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable", connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(9);      //9 is Login index in fisgametable
                    receiver_comboBox.Items.Add(name);
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
        private string genreConverter(int genr)
        { //traduz o gender de int pra string
            string Genre = "";
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

            if (Genre == "")
                Genre = "none";

            return Genre;
        }

        private void loadLabels()
        {
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
                DataRow game = ds.Rows.Find(GameID);

                name_label.Text = game.Field<string>("Name");
                dev_label.Text = game.Field<string>("Developer");
                year_label.Text = game.Field<int>("ReleaseYear").ToString();
                genre_label.Text = genreConverter(game.Field<int>("Genre"));
                if (game.Field<string>("Image") != null)
                    Cover_pictureBox.Image = Image.FromFile(game.Field<string>("Image"));
                else
                    Cover_pictureBox.Image = Image.FromFile("..\\..\\Resources\\null.png");

                this.Text = name_label.Text;
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

        private void fillplatCombobox()
        {

            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM FisGameTable", connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(1) == GameID)
                    {  // 1 is gameid
                        string name = reader.GetString(4);      //4 is platform index in fisgametable
                        platform_comboBox.Items.Add(name);
                    }
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
        private void gamesViewClear()
        {
            gamesView.Clear();
            gamesView.Columns.Add(" ");
            gamesView.Columns.Add("Dono", 100);
            gamesView.Columns.Add("Plataforma", 100);
            gamesView.Columns.Add("Data de Compra", 100);
            gamesView.Columns.Add("Avaliação", 100);
            gamesView.Columns.Add("Disponibilidade", 100);
        }

        private void platform_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndShow();
        }

        private void AvailableOnly_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SearchAndShow();
        }

        private bool checkstatetobool(CheckState chk)
        {
            if (chk == CheckState.Checked)
                return true;
            else
                return false;
        }

        private bool availableTest(bool gameav, CheckState chkbox)
        {
            return (!checkstatetobool(chkbox)) || (gameav && checkstatetobool(chkbox));
        }

        private void SearchAndShow()
        {
            gamesViewClear();
            indexer.Clear();

            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM FisGameTable; SELECT * FROM UserTable", connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                ds.Tables[1].PrimaryKey = new DataColumn[] { ds.Tables[1].Columns["UserID"] };

                foreach (DataRow fisGame in ds.Tables[0].Rows)
                {
                    if (fisGame.Field<int>("GameId") == GameID && availableTest(fisGame.Field<bool>("Available"), AvailableOnly_checkBox.CheckState) && (platform_comboBox.SelectedIndex == 0 || fisGame.Field<string>("Platform") == platform_comboBox.Text))
                    {
                        ListViewItem ite = new ListViewItem();
                        foreach (DataRow user in ds.Tables[1].Rows)
                        {
                            if (fisGame.Field<int>("Owner") == user.Field<int>("UserID"))
                            {
                                ite.SubItems.Add(user.Field<string>("Login"));
                                ite.SubItems.Add(fisGame.Field<string>("Platform"));
                                if (fisGame.Field<DateTime?>("BuyDate").HasValue)
                                    ite.SubItems.Add(fisGame.Field<DateTime>("BuyDate").ToShortDateString());
                                else
                                    ite.SubItems.Add("Não fornecido.");
                                ite.SubItems.Add(fisGame.Field<string>("Avaliation"));
                                if (fisGame.Field<bool>("Available"))
                                    ite.SubItems.Add("Disponível.");
                                else
                                    ite.SubItems.Add("Indisponível.");

                                gamesView.Items.Add(ite);

                                indexer.Add(fisGame.Field<int>("FisGameId"));
                            }
                        }
                    }
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

        private void rentGame_button_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            if (adminRemoveOn)
            {
                SqlConnection connection = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("DELETE FROM FisGameTable WHERE FisGameId = '" + indexer[gamesView.SelectedIndices[0]].ToString() + "';", connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();


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
            else
            {
                if (adminModeOn)
                {
                    SqlConnection conn = new SqlConnection(strcon);
                    SqlCommand comm = new SqlCommand("SELECT * FROM  UserTable WHERE Login=" + receiver_comboBox.Text + ";", conn);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataTable ds = new DataTable();
                        da.SelectCommand = comm;
                        da.Fill(ds);

                        receiverID = ds.Rows[0].Field<int>("UserID");
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
                bool Continue = true;
                SqlConnection conne = new SqlConnection(strcon);
                SqlCommand comma = new SqlCommand("SELECT * FROM  FisGameTable WHERE FisGameId= '" + indexer[gamesView.SelectedIndices[0]] + "';", conne);
                try
                {
                    conne.Open();
                    comma.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable ds = new DataTable();
                    da.SelectCommand = comma;
                    da.Fill(ds);

                    if (!ds.Rows[0].Field<bool>("Available"))
                    {
                        MessageBox.Show("Este jogo não está disponível.");
                        Continue = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    throw;
                }
                finally
                {
                    conne.Close();
                }
                if (Continue)
                {
                    bool error = true;
                    SqlConnection con = new SqlConnection(strcon);
                    SqlCommand com = new SqlCommand("SELECT * FROM  UserTable;", con);
                    try
                    {
                        con.Open();
                        com.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataTable ds = new DataTable();
                        da.SelectCommand = com;
                        da.Fill(ds);/////////////////////////////
                        List<DataRow> final = new List<DataRow>();

                        foreach (DataRow user in ds.Rows)
                        {
                            
                            if (user.Field<int>("UserID") == receiverID)
                            {
                                
                                if (user.Field<int>("Counter") > 0)
                                {
                                    if (user.Field<int>("Rented") == -1)
                                        error = false;
                                    else
                                        if (adminModeOn)
                                        MessageBox.Show("O usuário " + user.Field<string>("Login") + " não pode locar jogos.\n É necessário devolver antes de locar novamente.");
                                    else
                                        MessageBox.Show("Você não pode locar jogos.\n É necessário devolver antes de locar novamente.");
                                }
                                else
                            if (adminModeOn)
                                    MessageBox.Show("O usuário " + user.Field<string>("Login") + " não pode locar jogos.\n É necessário emprestar mais um jogo para continuar.");
                                else
                                    MessageBox.Show("Você não pode locar jogos.\n É necessário emprestar mais um jogo para continuar.");
                            }
                        }
                        /*
                        if (final[0].Field<int>("Counter") > 0)
                        {
                            if (final[0].Field<int>("Rented") == -1)
                                error = false;
                            else
                                if (adminModeOn)
                                MessageBox.Show("O usuário " + final[0].Field<string>("Login") + " não pode locar jogos.\n É necessário devolver antes de locar novamente.");
                            else
                                MessageBox.Show("Você não pode locar jogos.\n É necessário devolver antes de locar novamente.");
                        }
                        else
                            if (adminModeOn)
                            MessageBox.Show("O usuário " + final[0].Field<string>("Login") + " não pode locar jogos.\n É necessário emprestar mais um jogo para continuar.");
                        else
                            MessageBox.Show("Você não pode locar jogos.\n É necessário emprestar mais um jogo para continuar.");
                        */

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

                    if (!error)
                    {

                        SqlConnection connection = new SqlConnection(strcon);
                        SqlCommand cmd = new SqlCommand("UPDATE FisGameTable SET Available=0 WHERE FisGameId=" + indexer[gamesView.SelectedIndices[0]] + "; UPDATE UserTable SET Rented=" + indexer[gamesView.SelectedIndices[0]] + " WHERE UserID=" + receiverID + ";", connection);
                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
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
                }
            }
            SearchAndShow();
        }
    }
}
