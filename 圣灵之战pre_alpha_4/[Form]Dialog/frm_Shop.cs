using System;
using System.Windows.Forms;
using 圣灵之战pre_alpha_4.Variable;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    public partial class frm_Shop : Form
    {
        Commodity commodity;
        public frm_Shop()
        {
            InitializeComponent();
        }

        private void frm_Shop_Load(object sender, EventArgs e)
        {
            lab_PlayerMoney.Text = "当前拥有金钱：" + PlayerValue.Player.Money.ToString() + "$";
            foreach (Commodity tem in GameValue.Commodities.GetArray())
            {
                lst_CommodityName.Items.Add(tem.Name);
                lst_CommodityPrize.Items.Add(tem.Prize);
            }
        }
        private void lst_commodityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_CommodityName.SelectedIndex != -1 &&
                lst_CommodityName.SelectedIndex != lst_CommodityPrize.SelectedIndex)
            {
                lst_CommodityPrize.SelectedIndex = lst_CommodityName.SelectedIndex;
            }
            commodity = GameValue.Commodities.GetArray()[lst_CommodityName.SelectedIndex];
            lab_CommodityInfo.Text = commodity.Info;
            if (commodity.Prize > PlayerValue.Player.Money)
            {
                lab_PreView.Text = "您太穷了，请赚够钱再来。";
                but_Buy.Enabled = false;
            }
            else
            {
                icnc_Main.SetMax( PlayerValue.Player.Money / commodity.Prize);
                icnc_Main.Enabled = true;
                but_Buy.Enabled = true;
            }
        }

        private void lst_CommodityPrize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_CommodityPrize.SelectedIndex != -1 &&
                lst_CommodityName.SelectedIndex != lst_CommodityPrize.SelectedIndex)
            {
                lst_CommodityName.SelectedIndex = lst_CommodityPrize.SelectedIndex;
            }
        }

        private void but_Canel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void but_Buy_Click(object sender, EventArgs e)
        {
            PlayerValue.Player.Money -= icnc_Main.Number * commodity.Prize;
            PlayerValue.Items.Add(new Item(commodity.ID, icnc_Main.Number));
            Dispose();
        }
        private void Icnc_Main_NumberChanged(object sender, EventArgs e)
        {
            lab_PreView.Text = "共计：" + icnc_Main.Number * commodity.Prize + "$";
        }
    }
}
