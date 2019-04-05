using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 圣灵之战pre_alpha_4
{
    namespace FinalValue
    {
        public enum AttributeValue { 
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
            public static string[] Text =new string[]{ "主武器", "副武器", "头部","身体", "腿部" ,
                "脚部" , "颈部" , "腰部", "左手腕" , "右手腕" };
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
        }
    }
}
