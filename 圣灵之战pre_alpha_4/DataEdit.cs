using DataEdit;
using System;
using 圣灵之战pre_alpha_4.FinalValue;
using 圣灵之战pre_alpha_4.Variable;
namespace 圣灵之战pre_alpha_4
{
    public class GameDataRead
    {
        public static Array_Item GameItemLoad(string path)//GameItem读取
        {
            Array_Item items = new Array_Item();
            var data_input = ReadFiles.ItemRead(path);
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0;
            //定义输出变量
            Array_Additive additives = new Array_Additive();
            Item item = new Item();
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "item_id":
                        additives = new Array_Additive();
                        item = new Item();
                        item.ID = item_value[i];
                        break;
                    case "item_name":
                        item.Name = item_value[i];
                        break;
                    case "item_info":
                        item.Info = item_value[i];
                        break;
                    case "item_prize":
                        item.Prize = int.Parse(item_value[i]);
                        break;
                    case "item_add":
                        additives.Add(GetAdditive(item_value[i]));
                        break;
                    case "item_add_end":
                        additives.Add(GetAdditive(item_value[i]));
                        item.Additives = additives;
                        item.Number = -1;
                        items.Add(item);
                        break;
                }
                i++;
            }
            //对号入座给数组赋值
            return items;
            //输出
        }
        public static Array_Monster GameMonsterLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0;
            Array_Monster monsters = new Array_Monster();
            Monster monster = new Monster();
            Attributes attributes = new Attributes();
            Array_DropItem dropItems = new Array_DropItem();
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "monster_id":
                        monster = new Monster();
                        attributes = new Attributes();
                        dropItems = new Array_DropItem();
                        monster.ID = item_value[i];
                        break;
                    case "monster_name":
                        monster.Name = item_value[i];
                        break;
                    case "monster_hp":
                        attributes.HP = int.Parse(item_value[i]);
                        break;
                    case "monster_power":
                        attributes.Power = int.Parse(item_value[i]);
                        break;
                    case "monster_defense":
                        attributes.Defense = int.Parse(item_value[i]);
                        break;
                    case "monster_agile":
                        attributes.Agile = int.Parse(item_value[i]);
                        break;
                    case "monster_precise":
                        attributes.Precise = int.Parse(item_value[i]);
                        monster.Attributes = attributes;
                        break;
                    case "monster_dropExp":
                        monster.Exp = int.Parse(item_value[i]);
                        break;
                    case "monster_dropMoney":
                        monster.Money = int.Parse(item_value[i]);
                        break;
                    case "monster_spoilItem":
                        dropItems.Add(GetDropItem(item_value[i]));
                        break;
                    case "monster_spoilItem_end":
                        dropItems.Add(GetDropItem(item_value[i]));
                        monster.DropItems = dropItems;
                        monsters.Add(monster);
                        break;
                }
                i++;
            }
            return monsters;
        }
        public static Array_Instance GameInstanceLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            Array_Instance instances = new Array_Instance();
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0;
            Instance instance = new Instance();
            Array_Monster monsters = new Array_Monster();
            //定义输出变量
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "instance_id":
                        instance = new Instance();
                        monsters = new Array_Monster();
                        instance.ID = item_value[i];
                        break;
                    case "instance_name":
                        instance.Name = item_value[i];
                        break;
                    case "instance_info":
                        instance.Info = item_value[i];
                        break;
                    case "instance_PP":
                        instance.PP = int.Parse(item_value[i]);
                        break;
                    case "instance_monsterOut_total":
                        instance.MonsterAppendTotal = int.Parse(item_value[i]);
                        break;
                    case "instance_monster":
                        monsters.Add(new Monster(item_value[i]));
                        break;
                    case "instance_monster_end":
                        monsters.Add(new Monster(item_value[i]));
                        instance.AppendMonster = monsters;
                        instances.Add(instance);
                        break;
                }
                i++;
            }
            //对号入座给数组赋值
            return instances;
            //输出
        }
        public static Tuple<int[], int[]> GameLevelLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            int game_level_total = data_input.Item1;
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0, j = 0;
            int[] game_level = new int[game_level_total];
            int[] game_level_Exp = new int[game_level_total];
            //定义输出变量
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "level":
                        game_level[j] = int.Parse(item_value[i]);
                        break;
                    case "levelExp":
                        game_level_Exp[j] = int.Parse(item_value[i]);
                        j++;
                        break;
                }
                i++;
            }
            //对号入座给数组赋值
            Tuple<int[], int[]> result = new Tuple<int[], int[]>(game_level, game_level_Exp);
            return result;
            //输出
        }
        public static Array_Commodity GameShopLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0;
            Array_Commodity commodities = new Array_Commodity();
            Commodity commodity = null;
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "commodity_id":
                        commodity = new Commodity(item_value[i]);
                        break;
                    case "commodity_prize":
                        commodity.Prize = int.Parse(item_value[i]);
                        commodities.Add(commodity);
                        break;
                }
                i++;
            }
            return commodities;

        }
        public static Array_Place GamePlaceLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0;
            Array_Place places = new Array_Place();
            Place place = new Place();
            Array_Instance instances = new Array_Instance();
            Array_NPC npcs = new Array_NPC();
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "place_id":
                        place = new Place();
                        instances = new Array_Instance();
                        npcs = new Array_NPC();
                        place.ID = item_value[i];
                        break;
                    case "place_npc":
                        npcs.Add(new NPC(item_value[i]));
                        break;
                    case "place_npc_end":
                        npcs.Add(new NPC(item_value[i]));
                        place.NPCs = npcs;
                        break;
                    case "place_instance":
                        instances.Add(new Instance(item_value[i], InstanceState.System));
                        break;
                    case "place_instance_end":
                        instances.Add(new Instance(item_value[i], InstanceState.System));
                        place.Instances = instances;
                        break;
                    case "place_name":
                        place.Name = item_value[i];
                        places.Add(place);
                        break;
                }
                i++;
            }
            return places;
            //输出
        }
        public static Array_NPC GameNpcLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0;
            Array_NPC npcs = new Array_NPC();
            NPC npc = new NPC();
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "npc_id":
                        npc = new NPC();
                        npc.ID = item_value[i];
                        break;
                    case "npc_name":
                        npc.Name = item_value[i];
                        npcs.Add(npc);
                        break;
                }
                i++;
            }
            return npcs;
        }
        public static Tuple<string[], string[], string[], string[], string[], string[,], string[,], Tuple<int[], string[,], string[,], int[], int>> GameMissionLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            int game_mission_total = data_input.Item1;
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0, j = 0;
            string[] game_mission_numberic = new string[game_mission_total];
            string[] game_mission_name = new string[game_mission_total];
            string[] game_mission_info = new string[game_mission_total];
            string[] game_mission_relation = new string[game_mission_total];
            string[] game_mission_relation_value = new string[game_mission_total];
            string[,] game_mission_requipment = new string[game_mission_total, 5];
            string[,] game_mission_requipment_value = new string[game_mission_total, 5];
            int[] game_mission_requipment_total = new int[game_mission_total];
            string[,] game_mission_reward = new string[game_mission_total, 5];
            string[,] game_mission_reward_value = new string[game_mission_total, 5];
            int[] game_mission_reward_total = new int[game_mission_total];
            //定义输出变量
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "mission_id":
                        game_mission_numberic[j] = item_value[i];
                        break;
                    case "mission_name":
                        game_mission_name[j] = item_value[i];
                        break;
                    case "mission_info":
                        game_mission_info[j] = item_value[i];
                        break;
                    case "mission_relation_item":
                        game_mission_relation[j] = item_value[i];
                        break;
                    case "mission_relation_value":
                        game_mission_relation_value[j] = item_value[i];
                        break;
                    case "mission_requipment_item_1":
                        game_mission_requipment[j, 0] = item_value[i];
                        break;
                    case "mission_requipment_item_2":
                        game_mission_requipment[j, 1] = item_value[i];
                        break;
                    case "mission_requipment_item_3":
                        game_mission_requipment[j, 2] = item_value[i];
                        break;
                    case "mission_requipment_item_4":
                        game_mission_requipment[j, 3] = item_value[i];
                        break;
                    case "mission_requipment_item_5":
                        game_mission_requipment[j, 4] = item_value[i];
                        break;
                    case "mission_requipment_value_1":
                        game_mission_requipment_value[j, 0] = item_value[i];
                        break;
                    case "mission_requipment_value_2":
                        game_mission_requipment_value[j, 1] = item_value[i];
                        break;
                    case "mission_requipment_value_3":
                        game_mission_requipment_value[j, 2] = item_value[i];
                        break;
                    case "mission_requipment_value_4":
                        game_mission_requipment_value[j, 3] = item_value[i];
                        break;
                    case "mission_requipment_value_5":
                        game_mission_requipment_value[j, 4] = item_value[i];
                        break;
                    case "mission_requipment_total":
                        game_mission_requipment_total[j] = int.Parse(item_value[i]);
                        break;
                    case "mission_reward_item_1":
                        game_mission_reward[j, 0] = item_value[i];
                        break;
                    case "mission_reward_item_2":
                        game_mission_reward[j, 1] = item_value[i];
                        break;
                    case "mission_reward_item_3":
                        game_mission_reward[j, 2] = item_value[i];
                        break;
                    case "mission_reward_item_4":
                        game_mission_reward[j, 3] = item_value[i];
                        break;
                    case "mission_reward_item_5":
                        game_mission_reward[j, 4] = item_value[i];
                        break;
                    case "mission_reward_value_1":
                        game_mission_reward_value[j, 0] = item_value[i];
                        break;
                    case "mission_reward_value_2":
                        game_mission_reward_value[j, 1] = item_value[i];
                        break;
                    case "mission_reward_value_3":
                        game_mission_reward_value[j, 2] = item_value[i];
                        break;
                    case "mission_reward_value_4":
                        game_mission_reward_value[j, 3] = item_value[i];
                        break;
                    case "mission_reward_value_5":
                        game_mission_reward_value[j, 4] = item_value[i];
                        break;
                    case "mission_reward_total":
                        game_mission_reward_total[j] = int.Parse(item_value[i]);
                        break;
                }
                i++;
            }
            //对号入座给数组赋值
            Tuple<int[], string[,], string[,], int[], int> TRest = new Tuple<int[], string[,], string[,], int[], int>(game_mission_requipment_total, game_mission_reward, game_mission_reward_value, game_mission_reward_total, game_mission_total);
            Tuple<string[], string[], string[], string[], string[], string[,], string[,], Tuple<int[], string[,], string[,], int[], int>> result = new Tuple<string[], string[], string[], string[], string[], string[,], string[,], Tuple<int[], string[,], string[,], int[], int>>(game_mission_numberic, game_mission_name, game_mission_info, game_mission_relation, game_mission_relation_value, game_mission_requipment, game_mission_requipment_value, TRest);
            return result;
            //输出
        }
        public static Array_Player GamePlayerLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0;
            Array_Player players = new Array_Player();
            Player player = new Player();
            Array_Equipment equipments = new Array_Equipment();
            TalentPoints talentPoints = new TalentPoints();
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "player_name":
                        player = new Player();
                        talentPoints = new TalentPoints();
                        player.Name = item_value[i];
                        break;
                    case "player_profession":
                        player.Profession = item_value[i];
                        break;
                    case "player_exp":
                        player.Exp = int.Parse(item_value[i]);
                        break;
                    case "player_money":
                        player.Money = int.Parse(item_value[i]);
                        break;
                    case "player_pp":
                        player.PP = int.Parse(item_value[i]);
                        break;
                    case "player_hp":
                        player.HP = int.Parse(item_value[i]);
                        break;
                    case "player_hp_talent":
                        talentPoints.HP = int.Parse(item_value[i]);
                        break;
                    case "player_power_talent":
                        talentPoints.Power = int.Parse(item_value[i]);
                        break;
                    case "player_defense_talent":
                        talentPoints.Defense = int.Parse(item_value[i]);
                        break;
                    case "player_agile_talent":
                        talentPoints.Agile = int.Parse(item_value[i]);
                        break;
                    case "player_precise_talent":
                        talentPoints.Precise = int.Parse(item_value[i]);
                        break;
                    case "player_remain_talent":
                        player.RemainTalentPoints = int.Parse(item_value[i]);
                        player.TalentPoints = talentPoints;
                        players.Add(player);
                        break;
                }
                i++;
            }
            return players;
        }
        private static Additive GetAdditive(string input)
        {
            string key = input.Substring(0, 1);
            string value = input.Substring(2);
            if (input.Substring(0, 1) == "U")
            {
                key = input.Substring(0, 4);
                value = input.Substring(5);
            }
            return new Additive(key, value);
        }
        private static DropItem GetDropItem(string input)
        {
            string item = input.Substring(0, 5);
            float risk = float.Parse(input.Substring(6));
            return new DropItem(item, risk);
        }
    }
    public class PlayerDataRead
    {
        public static Array_Item PlayerItemLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0;
            //定义输出变量
            Array_Item items = new Array_Item();
            string id = "";
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "item_id":
                        id = item_value[i];
                        break;
                    case "item_number":
                        items.Add(new Item(id, int.Parse(item_value[i])));
                        break;
                }
                i++;
            }
            return items;
        }
        public static Array_Equipment PlayerEquipmentLoad(string path)
        {
            var data_input = ReadFiles.ItemRead(path);
            string[] item_tybe = data_input.Item2;
            string[] item_value = data_input.Item3;
            int i = 0;
            Array_Equipment equipments = new Array_Equipment();
            foreach (string tem in item_tybe)
            {
                switch (tem)
                {
                    case "equipment_id":
                        equipments.SetEquipment(new Equipment(item_value[i]));
                        break;
                }
                i++;
            }
            return equipments;
        }
    }
    public class GameDataWrite
    {
        public static void GamePlayerSave(Array_Player players, string path)
        {
            string[] output = new string[players.GetTotal() * 13];
            int i = 0;
            foreach (Player tem in players.GetArray())
            {
                output[i * 13 + 0] = "[" + tem.Name + "]";
                output[i * 13 + 1] = "player_name=" + tem.Name;
                output[i * 13 + 2] = "player_profession=" + tem.Profession;
                output[i * 13 + 3] = "player_exp=" + tem.Exp;
                output[i * 13 + 4] = "player_money=" + tem.Money;
                output[i * 13 + 5] = "player_pp=" + tem.PP;
                output[i * 13 + 6] = "player_hp=" + tem.HP;
                output[i * 13 + 7] = "player_hp_talent=" + tem.TalentPoints.HP;
                output[i * 13 + 8] = "player_power_talent=" + tem.TalentPoints.Power;
                output[i * 13 + 9] = "player_defense_talent=" + tem.TalentPoints.Defense;
                output[i * 13 + 10] = "player_agile_talent=" + tem.TalentPoints.Agile;
                output[i * 13 + 11] = "player_precise_talent=" + tem.TalentPoints.Precise;
                output[i * 13 + 12] = "player_remain_talent=" + tem.RemainTalentPoints;
                i++;
            }
            WriteFiles.Write(output, path);
        }
    }
    public class PlayerDataWrite
    {
        public static void PlayerItemSave(Array_Item items, string path)
        {
            string[] output = new string[items.GetTotal() * 3];
            int i = 0;
            foreach (Item tem in items.GetArray())
            {
                output[i * 3 + 0] = "[" + tem.ID + "]";
                output[i * 3 + 1] = "item_id=" + tem.ID;
                output[i * 3 + 2] = "item_number=" + tem.Number;
                i++;
            }
            WriteFiles.Write(output, path);
        }
        public static void PlayerEquipmentSave(Array_Equipment equipments, string path)
        {
            string[] output = new string[equipments.GetTotal() * 2];
            int i = 0;
            foreach (Equipment tem in equipments.GetArray())
            {
                if (tem != null)
                {
                    output[i * 2 + 0] = "[" + tem.ID + "]";
                    output[i * 2 + 1] = "equipment_id=" + tem.ID;
                    i++;
                }
            }
            WriteFiles.Write(output, path);
        }
    }
}
