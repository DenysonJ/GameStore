using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GameStore
{
    
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
