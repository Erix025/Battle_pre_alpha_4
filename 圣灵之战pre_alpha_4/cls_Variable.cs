using System;
using 圣灵之战pre_alpha_4.FinalValue;
using 圣灵之战pre_alpha_4.Interface;
namespace 圣灵之战pre_alpha_4
{
    namespace Variable
    {
        //Single Class
        public class Item
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Number { get; set; }
            public string Info { get; set; }
            public int Prize { get; set; }
            public Array_Additive Additives { get; set; }
            public Item(string i_id, string i_name, string i_info, int i_prize,
                                Array_Additive i_addibutes)
            {
                ID = i_id;
                Name = i_name;
                Number = -1;
                Info = i_info;
                Prize = i_prize;
                Additives = i_addibutes;
            }
            public Item(string i_id, int i_number)
            {
                //查询物品
                Item tem_item = null;
                foreach (Item tem in GameValue.Items.GetArray())
                {
                    if (i_id == tem.ID)
                    {
                        tem_item = tem;
                        break;
                    }
                }
                //属性赋值
                Number = i_number;
                ID = i_id;
                Name = tem_item.Name;
                Info = tem_item.Info;
                Prize = tem_item.Prize;
                Additives = tem_item.Additives;
            }
            public Item()
            {
            }
        }
        public class Additive
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public Additive(string i_key, string i_value)
            {
                Key = i_key;
                Value = i_value;
            }
        }
        public class Player
        {
            public string Name { get; set; }
            public string Profession { get; set; }
            public int Money { get; set; }
            public int Exp { get; set; }
            public int PP { get; set; }
            public int HP { get; set; }
            public int PP_Max { get; set; }
            public Array_Equipment Equipments { get; set; }
            public TalentPoints TalentPoints { get; set; }
            public int RemainTalentPoints { get; set; }
            public int GetAttribute(AttributeValue Tybe)
            {
                return Equipments.GetAdditiveTotal(Tybe)
                    + TalentPoints.GetTalentPoints(Tybe) * GetLv();
            }
            public int GetLv()
            {
                int i = 0;
                foreach (int tem_exp in GameValue.Levels.Exp)
                {
                    if (Exp < tem_exp)
                    {
                        break;
                    }
                    i++;
                }
                return GameValue.Levels.Number[i];
            }
            public int GetExpMax()
            {
                foreach (int tem_exp in GameValue.Levels.Exp)
                {
                    if (Exp < tem_exp)
                    {
                        return tem_exp;
                    }
                }
                return 0;
            }
            public void AddHp(int number)
            {
                if (HP + number > GetAttribute(AttributeValue.HP))
                {
                    HP = GetAttribute(AttributeValue.HP);
                }
                else
                {
                    HP += number;
                }
            }
            public void AddPP(int number)
            {
                if (PP + number > PP_Max)
                {
                    PP = PP_Max;
                }
                else
                {
                    PP += number;
                }
            }
            public Player()
            {
                PP_Max = 50;
            }
        }
        public class TalentPoints
        {
            public int HP { get; set; }
            public int Power { get; set; }
            public int Defense { get; set; }
            public int Agile { get; set; }
            public int Precise { get; set; }
            public int GetTalentPoints(AttributeValue Tybe)
            {
                switch (Tybe)
                {
                    case AttributeValue.HP:
                        return HP;
                    case AttributeValue.Power:
                        return Power;
                    case AttributeValue.Defense:
                        return Defense;
                    case AttributeValue.Agile:
                        return Agile;
                    case AttributeValue.Precise:
                        return Precise;
                }
                return 0;
            }
        }
        public class Equipment
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public Array_Additive Additives { get; set; }
            public int GetAdditive(AttributeValue tybe)
            {
                foreach (Additive tem in Additives.GetArray())
                {
                    if (tem.Key == "U-" + AttributeName.GetAttributeKey(tybe))
                    {
                        return int.Parse(tem.Value);
                    }
                }
                return 0;
            }
            public Equipment(string ID)
            {
                Item tem_Item = null;
                foreach (Item tem in GameValue.Items.GetArray())
                {
                    if (tem.ID == ID)
                    {
                        tem_Item = tem;
                        break;
                    }
                }
                Name = tem_Item.Name;
                Additives = tem_Item.Additives;
                this.ID = ID;
            }
        }
        public class Monster
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public Attributes Attributes { get; set; }
            public int Exp { get; set; }
            public int Money { get; set; }
            public Array_DropItem DropItems { get; set; }
            public Monster(string i_ID, string i_Name, Attributes i_Attributes, int i_Exp, int i_Money)
            {
                ID = i_ID;
                Name = i_Name;
                Attributes = i_Attributes;
                Exp = i_Exp;
                Money = i_Money;
            }
            public Monster(string i_ID)
            {
                Monster tem_Monster = null;
                foreach (Monster tem in GameValue.Monsters.GetArray())
                {
                    if (tem.ID == i_ID)
                    {
                        tem_Monster = tem;
                        break;
                    }
                }
                ID = i_ID;
                Name = tem_Monster.Name;
                Attributes = tem_Monster.Attributes;
                Exp = tem_Monster.Exp;
                Money = tem_Monster.Money;
                DropItems = tem_Monster.DropItems;
            }
            public Monster() { }
            public Array_Item GetKilledDropItems()
            {
                Random random = new Random();
                //TODO:战利品核算
                return null;
            }
            public int GetKilledExp()
            {
                //TODO:经验核算
                return 0;
            }
            public int GetKilledMoney()
            {
                //TODO:金钱核算
                return 0;
            }
        }
        public class DropItem
        {
            public Item Item { get; set; }
            public float Risk { get; set; }
            public DropItem(string in_ID, float in_Risk)
            {
                Item = new Item(in_ID, 1);
                Risk = in_Risk;
            }
        }
        public class Instance
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public Array_Monster AppendMonster { get; set; }
            public InstanceState State { get; set; }
            public int MonsterAppendTotal { get; set; }
            public string Info { get; set; }
            public int PP { get; set; }
            public Instance(string i_ID, string i_Name, Array_Monster i_AppendMonster,
                                        string i_Info, int i_PP, int i_MonsterAppendTotal)
            {
                ID = i_ID;
                Name = i_Name;
                AppendMonster = i_AppendMonster;
                State = InstanceState.System;
                MonsterAppendTotal = i_MonsterAppendTotal;
                Info = i_Info;
                PP = i_PP;
            }
            public Instance(string i_ID, InstanceState i_State)
            {
                //查找元素
                Instance tem_instance = null;
                foreach (Instance tem in GameValue.Instances.GetArray())
                {
                    if (i_ID == tem.ID)
                    {
                        tem_instance = tem;
                        break;
                    }
                }
                //属性赋值
                ID = i_ID;
                Name = tem_instance.Name;
                AppendMonster = tem_instance.AppendMonster;
                State = i_State;
                MonsterAppendTotal = tem_instance.MonsterAppendTotal;
                Info = tem_instance.Info;
                PP = tem_instance.PP;
            }
            public Instance() { }
        }
        public class Commodity
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Info { get; set; }
            public int Prize { get; set; }
            public Commodity(string i_ID)
            {
                Item tem_Item = null;
                foreach (Item tem in GameValue.Items.GetArray())
                {
                    if (tem.ID == i_ID)
                    {
                        tem_Item = tem;
                    }
                }
                ID = i_ID;
                Name = tem_Item.Name;
                Info = tem_Item.Info;
            }
        }
        public class Place
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public Array_Instance Instances { get; set; }
            public Array_NPC NPCs { get; set; }
            public Place(string i_ID, string i_Name, Array_Instance i_Instances, Array_NPC i_NPCs)
            {
                ID = i_ID;
                Name = i_Name;
                Instances = i_Instances;
                NPCs = i_NPCs;
            }
            public Place(string i_ID)
            {
                Place tem_place = null;
                foreach (Place tem in GameValue.Places.GetArray())
                {
                    if (tem.ID == i_ID)
                    {
                        tem_place = tem;
                        break;
                    }
                }
                ID = i_ID;
                Name = tem_place.Name;
                Instances = tem_place.Instances;
                NPCs = tem_place.NPCs;
            }
            public Place() { }
        }
        public class NPC
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public NPC(string i_ID, string i_Name)
            {
                ID = i_ID;
                Name = i_Name;
            }
            public NPC(string i_ID)
            {
                NPC tem_NPC = null;
                foreach (NPC tem in GameValue.NPCs.GetArray())
                {
                    if (tem.ID == i_ID)
                    {
                        tem_NPC = tem;
                        break;
                    }
                }
                ID = i_ID;
                Name = tem_NPC.Name;
            }
            public NPC() { }
        }
        public class Mission
        {
            //TODO:任务
            public string ID { get; set; }
            public string Name { get; set; }
            public string Info { get; set; }
            public Array_Requirement Requirements { get; set; }
            public Array_Reward Rewards { get; set; }
            public Mission()
            {

            }
        }
        public class Requirement
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }
        public class Reward
        {
            public Item Item { get; set; }
            public RewardTybe Tybe { get; set; }
            public int Value { get; set; }
            public Reward(RewardTybe i_tybe, string i_ID, int i_value)
            {
                Tybe = i_tybe;
                Item = new Item(i_ID, i_value);
                Value = -1;
            }
            public Reward(RewardTybe i_tybe, int i_value)
            {
                Tybe = i_tybe;
                Value = i_value;
            }
        }
        //Array Class
        public class Array_Additive : IArray
        {

            private int Total;
            private Additive[] addibutes;
            public Array_Additive()     //初始化
            {
                Total = 0;
                addibutes = new Additive[0];
            }
            public void Add(Additive in_Additive)//添加元素
            {
                //扩充数组
                Additive[] tem = addibutes;
                Total++;
                addibutes = new Additive[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    addibutes[i] = tem[i];
                }
                //添加元素
                addibutes[Total - 1] = in_Additive;
            }
            public void Delete(int index)//删除元素
            {
                //删除元素
                addibutes[index] = null;
                //重排元素
                for (int i = index; i < Total; i++)
                {
                    addibutes[i] = addibutes[i + 1];
                }
                //降低数组下界
                Additive[] tem = addibutes;
                Total--;
                addibutes = new Additive[Total];
                for (int i = 0; i < Total; i++)
                {
                    addibutes[i] = tem[i];
                }
            }
            public Additive GetAdditive(int index)//读取元素
            {
                return addibutes[index];
            }
            public Additive[] GetArray()
            {
                return addibutes;
            }
            public int GetTotal()
            {
                return Total;
            }
        }
        public class Array_Item : IArray
        {
            private int Total;
            private Item[] items;
            public Array_Item()
            {
                Total = 0;
                items = new Item[0];
            }
            public void Add(Item i_item)
            {
                //扩充数组
                Item[] tem = items;
                Total++;
                items = new Item[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    items[i] = tem[i];
                }
                //添加元素
                items[Total - 1] = i_item;
            }
            public void Add(string i_ID, int i_number)
            {
                int i = 0;
                foreach (Item tem in items)
                {
                    if (tem.ID == i_ID)
                    {
                        tem.Number = tem.Number + i_number;
                        items[i] = tem;
                        return;
                    }
                    i++;
                }
                Add(new Item(i_ID, i_number));
            }
            public void SetItem(Item i_item, int index)
            {
                items[index] = i_item;
            }
            public void Delete(int index)
            {
                //删除元素
                items[index] = null;
                //重排元素
                for (int i = index; i + i < Total; i++)
                {
                    items[i] = items[i + 1];
                }
                //降低数组下界
                Item[] tem = items;
                Total--;
                items = new Item[Total];
                for (int i = 0; i < Total; i++)
                {
                    items[i] = tem[i];
                }
            }
            public void Reduce(int index, int number)
            {
                if (number <= items[index].Number)
                {
                    if (number == items[index].Number)
                    {
                        Delete(index);
                    }
                    else
                    {
                        items[index].Number -= number;
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            public Item GetItem(int index)
            {
                return items[index];
            }
            public Item[] GetArray()
            {
                return items;
            }
            public int GetTotal()
            {
                return Total;
            }
            public void ItemSort()
            {
                int[] ids = new int[Total];
                Item[] tem_items = items;
                int i = 0;
                foreach (Item tem in items)
                {
                    ids[i] = int.Parse(tem.ID.Substring(1));
                    i++;
                }
                ids = DataEdit.DataEdit.Sort(ids);
                i = 0;
                foreach (int tem in ids)
                {
                    foreach (Item tem_item in tem_items)
                    {
                        if (int.Parse(tem_item.ID.Substring(1)) == tem)
                        {
                            items[i] = tem_item;
                            break;
                        }
                    }
                    i++;
                }
            }
        }
        public class Array_Equipment
        {
            private Equipment[] Equipments = new Equipment[10];
            private int Total = 0;
            public void SetEquipment(Equipment equipment)
            {
                string tem = equipment.Additives.GetAdditive(0).Value;
                int index = int.Parse(tem.Substring(tem.Length - 1, 1));
                if (Equipments[index] == null)
                {
                    Total++;
                }
                Equipments[index] = equipment;
            }
            public void DeleteEquipment(int index)
            {
                Equipments[index] = null;
                Total--;
            }
            public Equipment GetEquipment(int index)
            {
                return Equipments[index];
            }
            public int GetAdditiveTotal(AttributeValue Tybe)
            {
                int total = 0;
                foreach (Equipment tem_equip in Equipments)
                {
                    if (tem_equip != null)
                    {
                        foreach (Additive tem_add in tem_equip.Additives.GetArray())
                        {
                            if (tem_add.Key == "U-" + AttributeName.GetAttributeKey(Tybe))
                            {
                                total += int.Parse(tem_add.Value);
                            }
                        }
                    }
                }
                return total;
            }
            public int GetTotal()
            {
                return Total;
            }
            public Equipment[] GetArray()
            {
                return Equipments;
            }
        }
        public class Levels
        {
            public int[] Number { get; set; }
            public int[] Exp { get; set; }
            public Levels(int[] Numbers, int[] Exps)
            {
                Number = Numbers;
                Exp = Exps;
            }
        }
        public class Attributes
        {
            public int HP { get; set; }
            public int Power { get; set; }
            public int Defense { get; set; }
            public int Agile { get; set; }
            public int Precise { get; set; }
        }
        public class Array_DropItem : IArray
        {
            private DropItem[] dropItems;
            private int Total;
            public Array_DropItem()
            {
                Total = 0;
                dropItems = new DropItem[0];
            }
            public void Add(DropItem in_dropItem)
            {
                //扩充数组

                DropItem[] tem = dropItems;
                Total++;
                dropItems = new DropItem[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    dropItems[i] = tem[i];
                }
                //添加元素
                dropItems[Total - 1] = in_dropItem;
            }
            public void Delete(int index)
            {
                //删除元素
                dropItems[index] = null;
                //重排元素
                for (int i = index; i + 1 < Total; i++)
                {
                    dropItems[i] = dropItems[i + 1];
                }
                //降低数组下界
                DropItem[] tem = dropItems;
                Total--;
                dropItems = new DropItem[Total];
                for (int i = 0; i < Total; i++)
                {
                    dropItems[i] = tem[i];
                }
            }
            public int GetTotal()
            {
                return Total;
            }
            public DropItem[] GetArray()
            {
                return dropItems;
            }
        }
        public class Array_Monster : IArray
        {
            private Monster[] monsters;
            private int Total;
            public Array_Monster()
            {
                Total = 0;
                monsters = new Monster[0];
            }
            public void Add(Monster in_Monster)
            {
                //扩充数组

                Monster[] tem = monsters;
                Total++;
                monsters = new Monster[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    monsters[i] = tem[i];
                }
                //添加元素
                monsters[Total - 1] = in_Monster;
            }
            public void Delete(int index)
            {
                //删除元素
                monsters[index] = null;
                //重排元素
                for (int i = index; i + 1 < Total; i++)
                {
                    monsters[i] = monsters[i + 1];
                }
                //降低数组下界
                Monster[] tem = monsters;
                Total--;
                monsters = new Monster[Total];
                for (int i = 0; i < Total; i++)
                {
                    monsters[i] = tem[i];
                }
            }
            public int GetTotal()
            {
                return Total;
            }
            public Monster[] GetArray()
            {
                return monsters;
            }
        }
        public class Array_Instance : IArray
        {
            private Instance[] instances;
            private int Total;
            public Array_Instance()
            {
                Total = 0;
                instances = new Instance[0];
            }
            public void Add(Instance in_Instance)
            {
                //扩充数组

                Instance[] tem = instances;
                Total++;
                instances = new Instance[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    instances[i] = tem[i];
                }
                //添加元素
                instances[Total - 1] = in_Instance;
            }
            public void Delete(int index)
            {
                //删除元素
                instances[index] = null;
                //重排元素
                for (int i = index; i + 1 < Total; i++)
                {
                    instances[i] = instances[i + 1];
                }
                //降低数组下界
                Instance[] tem = instances;
                Total--;
                instances = new Instance[Total];
                for (int i = 0; i < Total; i++)
                {
                    instances[i] = tem[i];
                }
            }
            public int GetTotal()
            {
                return Total;
            }
            public Instance[] GetArray()
            {
                return instances;
            }
        }
        public class Array_Commodity : IArray
        {
            private Commodity[] commodities;
            private int Total;
            public Array_Commodity()
            {
                Total = 0;
                commodities = new Commodity[0];
            }
            public void Add(Commodity in_Commodity)
            {
                //扩充数组
                Commodity[] tem = commodities;
                Total++;
                commodities = new Commodity[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    commodities[i] = tem[i];
                }
                //添加元素
                commodities[Total - 1] = in_Commodity;
            }
            public void Delete(int index)
            {
                //删除元素
                commodities[index] = null;
                //重排元素
                for (int i = index; i + 1 < Total; i++)
                {
                    commodities[i] = commodities[i + 1];
                }
                //降低数组下界
                Commodity[] tem = commodities;
                Total--;
                commodities = new Commodity[Total];
                for (int i = 0; i < Total; i++)
                {
                    commodities[i] = tem[i];
                }
            }
            public int GetTotal()
            {
                return Total;
            }
            public Commodity[] GetArray()
            {
                return commodities;
            }
        }
        public class Array_NPC : IArray
        {
            private NPC[] NPCs;
            private int Total;
            public Array_NPC()
            {
                Total = 0;
                NPCs = new NPC[0];
            }
            public void Add(NPC in_NPC)
            {
                //扩充数组
                NPC[] tem = NPCs;
                Total++;
                NPCs = new NPC[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    NPCs[i] = tem[i];
                }
                //添加元素
                NPCs[Total - 1] = in_NPC;
            }
            public void Delete(int index)
            {
                //删除元素
                NPCs[index] = null;
                //重排元素
                for (int i = index; i + 1 < Total; i++)
                {
                    NPCs[i] = NPCs[i + 1];
                }
                //降低数组下界
                NPC[] tem = NPCs;
                Total--;
                NPCs = new NPC[Total];
                for (int i = 0; i < Total; i++)
                {
                    NPCs[i] = tem[i];
                }
            }
            public int GetTotal()
            {
                return Total;
            }
            public NPC[] GetArray()
            {
                return NPCs;
            }
        }
        public class Array_Place : IArray
        {
            private int Total;
            private Place[] places;
            public Array_Place()
            {
                Total = 0;
                places = new Place[0];
            }
            public void Add(Place in_Place)
            {
                //扩充数组
                Place[] tem = places;
                Total++;
                places = new Place[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    places[i] = tem[i];
                }
                //添加元素
                places[Total - 1] = in_Place;
            }
            public void Delete(int index)
            {
                //删除元素
                places[index] = null;
                //重排元素
                for (int i = index; i + 1 < Total; i++)
                {
                    places[i] = places[i + 1];
                }
                //降低数组下界
                Place[] tem = places;
                Total--;
                places = new Place[Total];
                for (int i = 0; i < Total; i++)
                {
                    places[i] = tem[i];
                }
            }
            public int GetTotal()
            {
                return Total;
            }
            public Place[] GetArray()
            {
                return places;
            }
        }
        public class Array_Reward
        {
            private Reward[] rewards;
            private int Total;
            public Array_Reward()
            {
                rewards = new Reward[0];
                Total = 0;
            }
            public void Add(Reward in_Reward)
            {
                //扩充数组
                Reward[] tem = rewards;
                Total++;
                rewards = new Reward[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    rewards[i] = tem[i];
                }
                //添加元素
                rewards[Total - 1] = in_Reward;
            }
            public void Delete(int index)
            {
                //删除元素
                rewards[index] = null;
                //重排元素
                for (int i = index; i + 1 < Total; i++)
                {
                    rewards[i] = rewards[i + 1];
                }
                //降低数组下界
                Reward[] tem = rewards;
                Total--;
                rewards = new Reward[Total];
                for (int i = 0; i < Total; i++)
                {
                    rewards[i] = tem[i];
                }
            }
            public int GetTotal()
            {
                return Total;
            }
            public Reward[] GetArray()
            {
                return rewards;
            }
        }
        public class Array_Requirement
        {
            private Requirement[] requirements;
            private int Total;
            public Array_Requirement()
            {
                requirements = new Requirement[0];
                Total = 0;
            }
            public void Add(Requirement in_Requirement)
            {
                //扩充数组
                Requirement[] tem = requirements;
                Total++;
                requirements = new Requirement[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    requirements[i] = tem[i];
                }
                //添加元素
                requirements[Total - 1] = in_Requirement;
            }
            public void Delete(int index)
            {
                //删除元素
                requirements[index] = null;
                //重排元素
                for (int i = index; i + 1 < Total; i++)
                {
                    requirements[i] = requirements[i + 1];
                }
                //降低数组下界
                Requirement[] tem = requirements;
                Total--;
                requirements = new Requirement[Total];
                for (int i = 0; i < Total; i++)
                {
                    requirements[i] = tem[i];
                }
            }
            public int GetTotal()
            {
                return Total;
            }
            public Requirement[] GetArray()
            {
                return requirements;
            }
        }
        public class Array_Player : IArray
        {
            private Player[] players;
            private int Total;
            public Array_Player()
            {
                players = new Player[0];
                Total = 0;
            }
            public void Add(Player in_Player)
            {
                //扩充数组
                Player[] tem = players;
                Total++;
                players = new Player[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    players[i] = tem[i];
                }
                //添加元素
                players[Total - 1] = in_Player;
            }
            public void Delete(int index)
            {
                //删除元素
                players[index] = null;
                //重排元素
                for (int i = index; i + 1 < Total - 1; i++)
                {
                    players[i] = players[i + 1];
                }
                //降低数组下界
                Player[] tem = players;
                Total--;
                players = new Player[Total];
                for (int i = 0; i < Total; i++)
                {
                    players[i] = tem[i];
                }
            }
            public int GetTotal()
            {
                return Total;
            }
            public Player[] GetArray()
            {
                return players;

            }
        }
    }
}