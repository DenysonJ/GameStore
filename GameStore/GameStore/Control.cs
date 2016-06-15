using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace GameStore
{

    public class GameManager
    {
        public ushort genre;

        public List<string> LoadPlatformCombobox()
        {
            List<string> names = new List<string>();
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
                    string name = reader.GetString(4);      //4 is login index in fisgametable
                    names.Add(name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return names;
        }

        public List<ListViewItem> LoadList(ref int globalimageindex, ref List<string> images, ref List<int> indexer)
        {
            List<ListViewItem> items = new List<ListViewItem>();
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

                int index = 0;

                foreach (DataRow game in ds.Rows)
                {
                    ListViewItem item = new ListViewItem();

                    if (game.Field<string>("Image") != null)
                    {
                        images.Add(game.Field<string>("Image"));
                        //Image cov = Image.FromFile(game.Field<string>("Image"));
                        //imageList1.Images.Add(cov);
                    }
                    else
                    {
                        images.Add("null");
                        //imageList1.Images.Add(Image.FromFile("..\\..\\Resources\\null.png"));
                    }
                    item.ImageIndex = globalimageindex++;

                    indexer.Add(game.Field<int>("GameID"));

                    item.SubItems.Add(game.Field<string>("Name"));
                    item.SubItems.Add(game.Field<int>("ReleaseYear").ToString());
                    item.SubItems.Add(game.Field<string>("Developer"));
                    item.SubItems.Add(genreConverter(game.Field<int>("Genre")));
                    item.SubItems.Add(game.Field<string>("Description"));

                    items.Add(item);

                    //gamesView.Items.Add(ite);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //Search();
            return items;
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
    }
}
