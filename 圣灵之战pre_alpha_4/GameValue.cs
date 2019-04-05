using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 圣灵之战pre_alpha_4.Variable;

namespace 圣灵之战pre_alpha_4
{
    static class GameValue
    {
        public static Array_Item Items { get; set; }
        public static Array_Monster Monsters { get; set; }
        public static Array_Instance Instances { get; set; }
        public static Array_Commodity Commodities { get; set; }
        public static Array_Place Places { get; set; }
        public static Array_NPC NPCs { get; set; }
        public static Levels Levels { get; set; }
        public static Array_Player Players { get; set; }
        private static readonly string GamePath = Environment.CurrentDirectory + "/Data/GameData/";
        private static readonly string PlayerPath = Environment.CurrentDirectory + "/Data/PlayerData/";
        public static void GameDataLoad()
        {
            Items = GameDataRead.GameItemLoad(GamePath + "GameItem.txt");
            var tem = GameDataRead.GameLevelLoad(GamePath + "GameLevel.txt");
            Levels = new Levels(tem.Item1, tem.Item2);
            Commodities = GameDataRead.GameShopLoad(GamePath + "GameShop.txt");
            Monsters = GameDataRead.GameMonsterLoad(GamePath + "GameMonster.txt");
            Instances = GameDataRead.GameInstanceLoad(GamePath + "GameInstance.txt");
            NPCs = GameDataRead.GameNpcLoad(GamePath + "GameNpc.txt");
            Places = GameDataRead.GamePlaceLoad(GamePath + "GamePlace.txt");
        }
        public static void GamePlayersDataLoad()
        {
            Players = GameDataRead.GamePlayerLoad(PlayerPath + "Players.txt");
        }
        public static void GameDataSave()
        {
            GameDataWrite.GamePlayerSave(Players, PlayerPath + "Players.txt");
        }
    }
}
