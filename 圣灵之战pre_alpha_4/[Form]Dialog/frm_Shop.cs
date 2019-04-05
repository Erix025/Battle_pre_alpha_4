using System;
using System.Windows.Forms;
using 圣灵之战pre_alpha_4.Variable;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    public partial class frm_Shop : Form
    {
        int max_number = 0;
        int number = 0;
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
        private void NumberChange()//修正数量
        {
            but_Reduce.Enabled = true;
            but_Add.Enabled = true;
            if (number == 1)
            {
                but_Reduce.Enabled = false;
            }
            if (number == max_number)
            {
                but_Add.Enabled = false;
            }
            if (number < 1)
            {
                number = 1;
                NumberChange();
            }
            if (number > max_number)
            {
                number = max_number;
                NumberChange();
            }
            txt_Number.Text = number.ToString();
            lab_PreView.Text = "共计：" + number * commodity.Prize + "$";
        }

        private void but_Reduce_Click(object sender, EventArgs e)
        {
            number--;
            NumberChange();
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            number++;
            NumberChange();
        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {
            try
            {
                number = int.Parse(txt_Number.Text);
            }
            catch
            {
                if (txt_Number.Text != "")
                {
                    MessageBox.Show("请输入正确的数字");
                }
            }
            NumberChange();
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
            }
            else
            {
                number = 1;
                max_number = PlayerValue.Player.Money / commodity.Prize;
                but_Add.Enabled = true;
                txt_Number.Enabled = true;
                but_Buy.Enabled = true;
                NumberChange();
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
            PlayerValue.Player.Money -= number * commodity.Prize;
            PlayerValue.Items.Add(new Item(commodity.ID, number));
            Dispose();
        }
    }
}
