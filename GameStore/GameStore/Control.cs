using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace GameStore
{
    public class ClientManager
    {
        public bool validate(string password, ref int userID)
        {

            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\storeDatabase.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT" + user + "FROM UserTable", connection);
            SqlDataReader reader;

            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                reader.Read();

                if(reader.GetFieldValue<string>(3) == password)
                {
                    userID = reader.GetFieldType<int>(0);
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }

            return false;
        }

    }

    public class GameManager
    {
        private gamelist gl = new gamelist();
        public List<Games> gameList = new List<Games>();
        public ushort genre;

        public void insert_new_game(Games new_game)
        {
            gl.insert_game(new_game);
        }

        private object ConvertByteToObject(byte[] bytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();

            //grava na stream o array de bytes passado como parâmetro
            memStream.Write(bytes, 0, bytes.Length);

            //modifica a posição de início da stream (posição zero)
            memStream.Seek(0, SeekOrigin.Begin);

            //converte a stream em um object
            object obj = binForm.Deserialize(memStream);

            return obj;
        }
        
        public void LoadGameList()
        {
            if(File.Exists(".\\data\\game_list.bin"))
            {
                FileStream file = new FileStream(".\\data\\game_list.bin", FileMode.Open);
                BinaryReader br = new BinaryReader(file);

                int obj_size;
                int size = 0;

                file.Seek(0, SeekOrigin.Begin);

                while (size < file.Length)
                {
                    obj_size = br.ReadInt32();

                    gameList.Add((Games)ConvertByteToObject(br.ReadBytes(obj_size)));

                    //Read the size of the object (int) and then the object
                    size += sizeof(int);
                    size += obj_size;

                }
            }
            
        }

        public List<Games> SearchGameByName(string name)
        {
            List<Games> games = new List<Games>();
            string game_name;
            int j = 0;

            name = name.ToLower();

            foreach(Games game in gameList)
            {
                game_name = game.name.ToLower();

                if (string.Compare(game_name, name, false) == 0)
                {
                    games.Insert(j, game);
                    j++;
                }
                else if (game_name.Contains(name))
                    games.Add(game);
            }

            return games;
        }

    }
}
