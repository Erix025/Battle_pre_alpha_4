using System;

namespace 圣灵之战pre_alpha_4
{
    namespace FinalValue
    {
        public enum AttributeValue
        {
            HP = 0,
            Power = 1,
            Defense = 2,
            Agile = 3,
            Precise = 4,
            PP = 5
        }
        public enum InstanceState
        {
            Unknown = -1,
            Undekaroned = 0,
            Dekaroned = 1,
            System = 64
        }
        public enum RewardTybe
        {
            Exp = 0,
            Money = 1,
            Item = 2
        }
        public enum EquipmentTybe
        {
            MainHand = 0,
            SubHand = 1,
            Head = 2,
            Body = 3,
            Legs = 4,
            Feet = 5,
            Neck = 6,
            Waist = 7,
            LeftWrist = 8,
            RightWrist = 9
        }
        public static class EquipmentName
        {
            public const string MainHand = "主武器",
            SubHand = "副武器",
            Head = "头部",
            Body = "身体",
            Legs = "腿部",
            Feet = "脚部",
            Neck = "颈部",
            Waist = "腰部",
            LeftWrist = "左手腕",
            RightWrist = "右手腕";
            public static string[] Text = new string[]{ "主武器", "副武器", "头部","身体", "腿部" ,
                "脚部" , "颈部" , "腰部", "左手腕" , "右手腕" };
            public static EquipmentTybe GetEquipmentTybe(string key)
            {
                switch (key)
                {
                    case "e0":
                        return EquipmentTybe.MainHand;
                    case "e1":
                        return EquipmentTybe.SubHand;
                    case "e2":
                        return EquipmentTybe.Head;
                    case "e3":
                        return EquipmentTybe.Body;
                    case "e4":
                        return EquipmentTybe.Legs;
                    case "e5":
                        return EquipmentTybe.Feet;
                    case "e6":
                        return EquipmentTybe.Neck;
                    case "e7":
                        return EquipmentTybe.Waist;
                    case "e8":
                        return EquipmentTybe.LeftWrist;
                    case "e9":
                        return EquipmentTybe.RightWrist;
                }
                throw new Exception("无法找到装备类型");
            }
            public static EquipmentTybe GetEquipmentTybe(int index)
            {
                switch (index)
                {
                    case 0:
                        return EquipmentTybe.MainHand;
                    case 1:
                        return EquipmentTybe.SubHand;
                    case 2:
                        return EquipmentTybe.Head;
                    case 3:
                        return EquipmentTybe.Body;
                    case 4:
                        return EquipmentTybe.Legs;
                    case 5:
                        return EquipmentTybe.Feet;
                    case 6:
                        return EquipmentTybe.Neck;
                    case 7:
                        return EquipmentTybe.Waist;
                    case 8:
                        return EquipmentTybe.LeftWrist;
                    case 9:
                        return EquipmentTybe.RightWrist;
                }
                throw new Exception("未找到对应类型");
            }
            public static int GetEquipmentIndex(EquipmentTybe tybe)
            {
                switch (tybe)
                {
                    case EquipmentTybe.MainHand:
                        return 0;
                    case EquipmentTybe.SubHand:
                        return 1;
                    case EquipmentTybe.Head:
                        return 2;
                    case EquipmentTybe.Body:
                        return 3;
                    case EquipmentTybe.Legs:
                        return 4;
                    case EquipmentTybe.Feet:
                        return 5;
                    case EquipmentTybe.Neck:
                        return 6;
                    case EquipmentTybe.Waist:
                        return 7;
                    case EquipmentTybe.LeftWrist:
                        return 8;
                    case EquipmentTybe.RightWrist:
                        return 9;
                }
                throw new Exception("无法找到该类型");
            }
        }
        public static class AttributeName
        {
            public static string GetAttributeKey(AttributeValue tybe)
            {
                switch (tybe)
                {
                    case AttributeValue.HP:
                        return "HP";
                    case AttributeValue.Power:
                        return "PW";
                    case AttributeValue.Defense:
                        return "DF";
                    case AttributeValue.Agile:
                        return "AL";
                    case AttributeValue.Precise:
                        return "PC";
                }
                return "";
            }
            public static string GetAttributeName(AttributeValue tybe)
            {
                switch (tybe)
                {
                    case AttributeValue.HP:
                        return "生命";
                    case AttributeValue.Power:
                        return "力量";
                    case AttributeValue.Defense:
                        return "防御";
                    case AttributeValue.Agile:
                        return "敏捷";
                    case AttributeValue.Precise:
                        return "精准";
                }
                return "";
            }
            public static AttributeValue GetAttributeValue(int index)
            {
                switch (index)
                {
                    case 0:
                        return AttributeValue.HP;
                    case 1:
                        return AttributeValue.Power;
                    case 2:
                        return AttributeValue.Defense;
                    case 3:
                        return AttributeValue.Agile;
                    case 4:
                        return AttributeValue.Precise;
                    case 5:
                        return AttributeValue.PP;

                }
                throw new Exception("无法找到对应类型");
            }
        }
        public static class AdditiveName
        {
            public static string GetAdditiveName(string key)
            {
                switch (key)
                {
                    case "PP":
                        return "体力";
                    case "DF":
                        return "防御";
                    case "HP":
                        return "生命";
                }
                return "";
            }
        }
        public static class Function
        {
            public static string GetValueSymbol(int value)
            {
                if (value > 0)
                {
                    return "+" + value.ToString();
                }
                else
                {
                    return value.ToString();
                }
            }
        }
    }
}
