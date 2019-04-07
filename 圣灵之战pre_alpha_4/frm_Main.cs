using System;
using System.Windows.Forms;
using 圣灵之战pre_alpha_4._Form_Dialog;
using 圣灵之战pre_alpha_4.FinalValue;
using 圣灵之战pre_alpha_4.Variable;

namespace 圣灵之战pre_alpha_4
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private RadioButton[] rad_Equipments;
        private void PlayerDataReFresh()
        {
            Player player = PlayerValue.Player;
            lab_PlayerName.Text = player.Name;
            lab_PlayerProfession.Text = player.Profession;
            lab_PlayerLv.Text = "Lv." + player.GetLv().ToString();
            lab_PlayerExp.Text = player.Exp.ToString() + " / " + player.GetExpMax().ToString() + " Exp";
            lab_PlayerMoney.Text = player.Money.ToString();
            lab_Player_PP.Text = player.PP.ToString() + " / " + player.PP_Max.ToString();
            lab_Player_Hp.Text = player.HP.ToString() + " / " + player.GetAttribute(FinalValue.AttributeValue.HP).ToString();
            lab_PlayerPower.Text = player.GetAttribute(FinalValue.AttributeValue.Power).ToString();
            lab_PlayerDefense.Text = player.GetAttribute(FinalValue.AttributeValue.Defense).ToString();
            lab_PlayerAgile.Text = player.GetAttribute(FinalValue.AttributeValue.Agile).ToString();
            lab_PlayerPrecise.Text = player.GetAttribute(FinalValue.AttributeValue.Precise).ToString();
            lab_PlayerTalentPoints.Text = player.RemainTalentPoints.ToString();
            tot_Player_Attribute.SetToolTip(lab_Player_Hp, player.TalentPoints.HP.ToString() + "x" +
                player.GetLv() + "+" + player.Equipments.GetAdditiveTotal(FinalValue.AttributeValue.HP));
            tot_Player_Attribute.SetToolTip(lab_PlayerPower, player.TalentPoints.Power.ToString() + "x" +
                player.GetLv() + "+" + player.Equipments.GetAdditiveTotal(FinalValue.AttributeValue.Power));
            tot_Player_Attribute.SetToolTip(lab_PlayerDefense, player.TalentPoints.Defense.ToString() + "x" +
                player.GetLv() + "+" + player.Equipments.GetAdditiveTotal(FinalValue.AttributeValue.Defense));
            tot_Player_Attribute.SetToolTip(lab_PlayerAgile, player.TalentPoints.Agile.ToString() + "x" +
                player.GetLv() + "+" + player.Equipments.GetAdditiveTotal(FinalValue.AttributeValue.Agile));
            tot_Player_Attribute.SetToolTip(lab_PlayerPrecise, player.TalentPoints.Precise.ToString() + "x" +
                player.GetLv() + "+" + player.Equipments.GetAdditiveTotal(FinalValue.AttributeValue.Precise));
        }
        private void PlayerEquipmentReFresh()
        {
            Player player = PlayerValue.Player;
            int index = 0;
            foreach (Equipment tem in player.Equipments.GetArray())
            {
                if (tem != null)
                {
                    rad_Equipments[index].Text = EquipmentName.Text[index] + "：" + "\r\n" +
                    player.Equipments.GetEquipment(index).Name;
                }
                else
                {
                    rad_Equipments[index].Text = EquipmentName.Text[index] + "：" + "\r\n" + "未装备";
                }
                index++;
            }
        }
        private void PlayerBagReFresh()
        {
            lst_PlayerBag.Items.Clear();
            lst_PlayerBagCount.Items.Clear();
            foreach (Item tem in PlayerValue.Items.GetArray())
            {
                lst_PlayerBag.Items.Add(tem.Name);
                lst_PlayerBagCount.Items.Add(tem.Number);
            }
            PlayerBagItemButtonReFresh(-1);
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            rad_Equipments = new RadioButton[] {rad_Equipment_1,rad_Equipment_2,rad_Equipment_3
                ,rad_Equipment_4,rad_Equipment_5,rad_Equipment_6,rad_Equipment_7,rad_Equipment_8,
                rad_Equipment_9,rad_Equipment_10};
            PlayerDataReFresh();
            PlayerEquipmentReFresh();
            PlayerBagReFresh();
        }

        private void DebugExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AttributeTalentPointAdd(AttributeValue attributeValue)
        {
            Player player = PlayerValue.Player;
            if (player.RemainTalentPoints != 0)
            {
                switch (attributeValue)
                {
                    case AttributeValue.HP:
                        if (player.GetAttribute(AttributeValue.HP) != 0)
                        {
                            float percent = player.HP / player.GetAttribute(AttributeValue.HP);
                            player.TalentPoints.HP++;
                            player.HP = (int)(player.GetAttribute(AttributeValue.HP) * percent);
                        }
                        else
                        {
                            player.TalentPoints.HP++;
                            player.HP = player.GetAttribute(AttributeValue.HP);
                        }
                        break;
                    case AttributeValue.Power:
                        player.TalentPoints.Power++;
                        break;
                    case AttributeValue.Defense:
                        player.TalentPoints.Defense++;
                        break;
                    case AttributeValue.Agile:
                        player.TalentPoints.Agile++;
                        break;
                    case AttributeValue.Precise:
                        player.TalentPoints.Precise++;
                        break;
                }
                player.RemainTalentPoints--;
                PlayerDataReFresh();
            }
            else
            {
                MessageBox.Show("天赋点不足，无法添加天赋点");
            }
        }
        private void PlayerBagItemButtonReFresh(int index)   //显示功能按钮
        {
            //按钮重置
            but_UsefulButton_1.Visible = false;
            but_UsefulButton_2.Visible = false;
            but_UsefulButton_3.Visible = false;
            but_UsefulButton_4.Visible = false;
            //查找tybe
            if (index != -1)
            {
                string tybe = "";
                foreach (Additive tem in PlayerValue.Items.GetItem(index).Additives.GetArray())
                {
                    if (tem.Key == "T")
                    {
                        tybe = tem.Value;
                        break;
                    }
                }
                switch (tybe)   //显示按钮
                {
                    case "i":
                        but_UsefulButton_1.Text = "出售";
                        but_UsefulButton_1.Visible = true;
                        break;
                    case "rf":
                        but_UsefulButton_1.Text = "出售";
                        but_UsefulButton_1.Visible = true;
                        but_UsefulButton_2.Text = "烹饪";
                        but_UsefulButton_2.Visible = true;
                        break;
                    case "ui":
                        but_UsefulButton_1.Text = "出售";
                        but_UsefulButton_1.Visible = true;
                        but_UsefulButton_2.Text = "使用";
                        but_UsefulButton_2.Visible = true;
                        break;
                    case "e0":
                    case "e1":
                    case "e2":
                    case "e3":
                    case "e4":
                    case "e5":
                    case "e6":
                    case "e7":
                    case "e8":
                    case "e9":
                        but_UsefulButton_1.Text = "出售";
                        but_UsefulButton_1.Visible = true;
                        but_UsefulButton_2.Text = "装备";
                        but_UsefulButton_2.Visible = true;
                        break;
                }
            }
        }
        private void But_Player_HP_Add_Click(object sender, EventArgs e)
        {
            AttributeTalentPointAdd(AttributeValue.HP);
        }
        private void But_PlayerPower_Add_Click(object sender, EventArgs e)
        {
            AttributeTalentPointAdd(AttributeValue.Power);
        }
        private void But_PlayerDefense_Add_Click(object sender, EventArgs e)
        {
            AttributeTalentPointAdd(AttributeValue.Defense);
        }
        private void But_PlayerAgile_Add_Click(object sender, EventArgs e)
        {
            AttributeTalentPointAdd(AttributeValue.Agile);
        }
        private void But_PlayerPrecise_Add_Click(object sender, EventArgs e)
        {
            AttributeTalentPointAdd(AttributeValue.Precise);
        }

        private void But_TakeOffEquipment_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (RadioButton tem in rad_Equipments)
            {
                if (tem.Checked)
                {
                    break;
                }
                index++;
            }
            PlayerValue.Items.Add(new Item(PlayerValue.Player.Equipments.GetEquipment(index).ID, 1));
            PlayerValue.Player.Equipments.DeleteEquipment(index);
            PlayerEquipmentReFresh();
            rad_Equipments[index].Checked = false;
            PlayerBagReFresh();
        }
        private void Rad_Equipments_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (RadioButton tem in rad_Equipments)
            {
                if (tem == sender)
                {
                    break;
                }
                index++;
            }
            if (rad_Equipments[index].Checked)
            {
                if (PlayerValue.Player.Equipments.GetEquipment(index) == null)
                {
                    but_TakeOffEquipment.Visible = false;
                    lab_EquipmentInfo.Text = EquipmentName.Text[index] +
                        "\r\n" + "未装备";
                }
                else
                {
                    but_TakeOffEquipment.Visible = true;
                    lab_EquipmentInfo.Text =
                        EquipmentName.Text[index] +
                        "\r\n" + PlayerValue.Player.Equipments.GetEquipment(index).Name + "\r\n" +
                        EquipmentInfoSet(AttributeValue.HP, index) + EquipmentInfoSet(AttributeValue.Power, index) +
                        EquipmentInfoSet(AttributeValue.Defense, index) + EquipmentInfoSet(AttributeValue.Agile, index) +
                        EquipmentInfoSet(AttributeValue.Precise, index);
                }
            }
            else
            {
                lab_EquipmentInfo.Text = "";
                but_TakeOffEquipment.Visible = false;
            }
        }
        private string EquipmentInfoSet(AttributeValue tybe, int index)
        {
            int tem = PlayerValue.Player.Equipments.GetArray()[index].GetAdditive(tybe);
            if (tem != 0)
            {
                if (tem > 0)
                {
                    return AttributeName.GetAttributeName(tybe) + "+" + tem.ToString() + "\r\n";
                }
                else
                {
                    return AttributeName.GetAttributeName(tybe) + tem.ToString() + "\r\n";
                }
            }
            else
            {
                return "";
            }
        }

        private void Lst_PlayerBag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_PlayerBag.SelectedIndex != -1 )
            {
                if (lst_PlayerBag.SelectedIndex != lst_PlayerBagCount.SelectedIndex)
                {
                    lst_PlayerBagCount.SelectedIndex = lst_PlayerBag.SelectedIndex;
                }
                PlayerBagItemButtonReFresh(lst_PlayerBag.SelectedIndex);
            }
        }

        private void Lst_PlayerBagCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_PlayerBagCount.SelectedIndex != -1 && lst_PlayerBag.SelectedIndex != lst_PlayerBagCount.SelectedIndex)
            {
                lst_PlayerBag.SelectedIndex = lst_PlayerBagCount.SelectedIndex;
            }

        }

        private void But_Shop_Click(object sender, EventArgs e)
        {
            //商城界面
            Frm_Shop frm_Shop = new Frm_Shop();
            frm_Shop.ShowDialog();
            PlayerDataReFresh();
            PlayerBagReFresh();
        }
        private void But_UsefulButton_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)//判断,调用对话框
            {
                case "出售":
                    frm_Sell frm_Sell = new frm_Sell(lst_PlayerBag.SelectedIndex);
                    frm_Sell.ShowDialog();
                    PlayerDataReFresh();
                    PlayerBagReFresh();
                    break;
                case "使用":
                    frm_Use frm_Use = new frm_Use(lst_PlayerBag.SelectedIndex);
                    frm_Use.ShowDialog();
                    PlayerDataReFresh();
                    PlayerBagReFresh();
                    break;
                case "烹饪":
                    break;
                case "装备":
                    break;
            }
        }
    }
}
