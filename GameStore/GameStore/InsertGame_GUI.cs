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
            FillOwnerCombobox();
            this.DialogResult = DialogResult.No;
        }

        private void FillOwnerCombobox() {

            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable", connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    string name = reader.GetString(9);      //9 is login index in usertable
                    owner_comboBox.Items.Add(name);
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

        private bool checkstatetobool(CheckState chk)
        {
            if (chk == CheckState.Checked)
                return true;
            else
                return false;
        }

        private void button_insertgame_Click(object sender, EventArgs e)
        {
            int FisGameId, GameId;
            bool exist;

            string name = name_textBox.Text;
            if (name.Contains("'")) {
                name = name.Insert(name.IndexOf("'"), "'");
            }

            Console.Write(name);
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
                DataRow[] foundRows = ds.Select("Name Like '" + name +"'");
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
                InsertGame2_GUI insert = new InsertGame2_GUI(name, GameId);
                var result = insert.ShowDialog();
                if (result == DialogResult.No)
                    this.Close();
            }

            //insere na FisGameTable
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand com = new SqlCommand("Insert Into FisGameTable (FisGameId, GameId, Platform, BuyDate, Owner, Avaliation, Available) Values('" + FisGameId.ToString() + "','" +  GameId.ToString() +"','" + Platform_textBox.Text +"','"  +buyDate_dateTimePicker.Value.Date.ToString("yyyyMMdd")  + "','" + owner_comboBox.SelectedIndex.ToString() + "','" + Avaliation_textBox.Text +"','"+ checkstatetobool(Available_checkBox.CheckState) + "');", conn);
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

            SqlConnection conne = new SqlConnection(strcon);
            SqlCommand comma = new SqlCommand("UPDATE UserTable SET Counter=Counter+4 WHERE Owner="+owner_comboBox.SelectedIndex+"; UPDATE UserTable SET List=CONCAT(List,"+FisGameId.ToString()+") WHERE Owner="+owner_comboBox.SelectedIndex+";", conne);
            try
            {
                conne.Open();
                comma.ExecuteNonQuery();
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

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
