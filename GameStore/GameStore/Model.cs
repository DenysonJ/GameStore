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

    public class Games
    {
        public int gameid;
        public string name;
        public int releaseYear;
        public ushort genre;
        public string description;
        public string image_name;
    }

}

