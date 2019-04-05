using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 圣灵之战pre_alpha_4.Variable;
using DataEdit;

namespace 圣灵之战pre_alpha_4
{
    static class PlayerValue
    {
        public static Player Player { get; set; }
        public static Array_Item Items { get; set; }
        public static void PlayerDataLoad(string name)
        {
            string PlayerPath = Environment.CurrentDirectory + "/Data/PlayerData/" + name + "/";
            Player = GetPlayer(name);
            Items = PlayerDataRead.PlayerItemLoad(PlayerPath+"PlayerItem.txt");
            Player.Equipments = PlayerDataRead.PlayerEquipmentLoad(PlayerPath + "PlayerEquipment.txt");
        }
        public static void PlayerDataSave()
        {
            string PlayerPath = Environment.CurrentDirectory + "/Data/PlayerData/" + Player.Name + "/";
            PlayerDataWrite.PlayerItemSave(Items, PlayerPath + "PlayerItem.txt");
            PlayerDataWrite.PlayerEquipmentSave(Player.Equipments, PlayerPath + "PlayerEquipment.txt");
        }
        public static void PlayerCreate(string i_name, string i_profession)
        {
            TalentPoints tem = new TalentPoints()
            {
                HP = 0,
                Agile = 0,
                Defense = 0,
                Power = 0,
                Precise = 0
            };
            Player player = new Player()
            {
                Name = i_name,
                Profession = i_profession,
                Equipments = new Array_Equipment(),
                Exp = 0,
                HP = 0,
                PP = 50,
                PP_Max = 50,
                Money = 0,
                RemainTalentPoints = 25,
                TalentPoints = tem
            };
            Array_Item items = new Array_Item();
            GameValue.Players.Add(player);
            GameDataWrite.GamePlayerSave(GameValue.Players,
                Environment.CurrentDirectory + "/Data/PlayerData/Players.txt");
            string PlayerPath = Environment.CurrentDirectory + "/Data/PlayerData/" + player.Name + "/";
            Directory.CreateDirectory(PlayerPath);
            PlayerDataWrite.PlayerItemSave(items, PlayerPath + "PlayerItem.txt");
            PlayerDataWrite.PlayerEquipmentSave(player.Equipments, PlayerPath + "PlayerEquipment.txt");
        }
        public static void PlayerDelete(int index)
        {
            Directory.Delete(Environment.CurrentDirectory + "/Data/PlayerData/" + 
                GameValue.Players.GetArray()[index].Name,true);
            GameValue.Players.Delete(index);
            GameDataWrite.GamePlayerSave(GameValue.Players, 
                Environment.CurrentDirectory + "/Data/PlayerData/Players.txt");
        }
        private static Player GetPlayer(string name)
        {
            foreach(Player tem in GameValue.Players.GetArray())
            {
                if(tem.Name == name)
                {
                    return tem;
                }
            }
            throw new Exception("找不到玩家");
        }

    }
}
