using System;
using System.Collections.Generic;
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
            public EquipmentTybe Tybe { get; set; }
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
                Tybe = EquipmentName.GetEquipmentTybe(Additives.GetAdditive(0).Value);
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
            public List<DropItem> DropItems { get; set; }
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
                foreach (Monster tem in GameValue.Monsters)
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
            public List<Monster> AppendMonster { get; set; }
            public InstanceState State { get; set; }
            public int MonsterAppendTotal { get; set; }
            public string Info { get; set; }
            public int PP { get; set; }
            public Instance(string i_ID, string i_Name, List<Monster> i_AppendMonster,
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
                foreach (Instance tem in GameValue.Instances)
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
            public List<Instance> Instances { get; set; }
            public List<NPC> NPCs { get; set; }
            public Place(string i_ID, string i_Name, List<Instance> i_Instances, List<NPC> i_NPCs)
            {
                ID = i_ID;
                Name = i_Name;
                Instances = i_Instances;
                NPCs = i_NPCs;
            }
            public Place(string i_ID)
            {
                Place tem_place = null;
                foreach (Place tem in GameValue.Places)
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
                foreach (NPC tem in GameValue.NPCs)
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
            public List<Requirement> Requirements { get; set; }
            public List<Reward> Rewards { get; set; }
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
            private Additive[] additives;
            public Array_Additive()     //初始化
            {
                Total = 0;
                additives = new Additive[0];
            }
            public void Add(Additive in_Additive)//添加元素
            {
                //扩充数组
                Additive[] tem = additives;
                Total++;
                additives = new Additive[Total];
                for (int i = 0; i < Total - 1; i++)
                {
                    additives[i] = tem[i];
                }
                //添加元素
                additives[Total - 1] = in_Additive;
            }
            public void Delete(int index)//删除元素
            {
                //删除元素
                additives[index] = null;
                //重排元素
                for (int i = index; i < Total; i++)
                {
                    additives[i] = additives[i + 1];
                }
                //降低数组下界
                Additive[] tem = additives;
                Total--;
                additives = new Additive[Total];
                for (int i = 0; i < Total; i++)
                {
                    additives[i] = tem[i];
                }
            }
            public Additive GetAdditive(int index)//读取元素
            {
                return additives[index];
            }
            public Additive GetAdditive(string key)
            {
                foreach(Additive tem in additives)
                {
                    if (tem.Key == key)
                    {
                        return tem;
                    }
                }
                throw new Exception("无法找到对象");
            }
            public Additive[] GetArray()
            {
                return additives;
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
                        tem.Number += i_number;
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
            private readonly Equipment[] Equipments = new Equipment[10];
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
            public void DeleteEquipment(EquipmentTybe tybe)
            {
                Equipments[EquipmentName.GetEquipmentIndex(tybe)] = null;
                Total--;
            }
            public Equipment GetEquipment(EquipmentTybe tybe)
            {
                return Equipments[EquipmentName.GetEquipmentIndex(tybe)];
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
    }
}