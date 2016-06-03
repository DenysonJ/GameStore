using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace GameStore
{
    // a class to store all constants needed
    public class Constants
    {
        //flag options for game genres
        public const ushort game_type_action      = 0x01;
        public const ushort game_type_adventure   = 0x02;
        public const ushort game_type_racing      = 0x04;
        public const ushort game_type_sports      = 0x08;
        public const ushort game_type_strategy    = 0x10;
        public const ushort game_type_puzzle      = 0x20;
        public const ushort game_type_shooter     = 0x40;
        public const ushort game_type_RPG         = 0x80;
    }

    [Serializable]
    public class Games
    {
        public string name;
        public int releaseYear;
        public int gameAge; //how long was purchased
        public ushort genre;
        public string description;
        public string image_name;
    }

    public class gamelist
    {
        
        public void insert_game(Games game)
        {
            saveElement(game);            
        }

        public static byte[] ConvertObjectToByte(object obj)
        {
            if (obj == null)
            {
                return null;
            }

            BinaryFormatter bf = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            //cria um array de bytes através do objeto obj
            bf.Serialize(ms, obj);

            //recebe o array referente ao objeto obj
            byte[] byt_array = ms.ToArray();

            return byt_array;
        }

      
        public void saveElement(Games element)
        {
            FileStream file = new FileStream(".\\data\\game_list.bin", FileMode.Append);
            BinaryWriter bw = new BinaryWriter(file);
            byte[] byt;
            byt = ConvertObjectToByte(element);
            bw.Write(byt.GetLength(1));
            bw.Write(byt);
            bw.Close();
            file.Close();
        }
    }
}

