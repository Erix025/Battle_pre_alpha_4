using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 圣灵之战pre_alpha_4.Variable;

namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    public partial class frm_Cook : Form
    {
        int item_index;
        Item item;
        Item after_item;
        const int prize = 2;
        public frm_Cook(int index)
        {
            item_index = index;
            item = PlayerValue.Items.GetItem(index);
            InitializeComponent();
        }
        public void Icnc_Main_NumberChanged(object sender, EventArgs e)
        {
            after_item = new Item(item.Additives.GetAdditive("C").Value, icnc_Main.Number);
            lab_Preview.Text = "共计：" + after_item.Name + " x " + icnc_Main.Number + "\n" + 
                "消耗：" + item.Name + " x " + icnc_Main.Number + "\n" + 
                "金钱 " + icnc_Main.Number * prize + "$";
        }

        private void Frm_Cook_Load(object sender, EventArgs e)
        {
            Text = "烹饪[" + item.Name + "]";
            int money_max = PlayerValue.Player.Money / prize;
            if (money_max >= item.Number)
            {
                icnc_Main.SetMax(item.Number);
            }
            else
            {
                if (money_max < 1)
                {
                    but_Confirm.Enabled = false;
                    icnc_Main.Enabled = false;
                    lab_Preview.Text = "您的金钱不足！";
                }
                else
                {
                    icnc_Main.SetMax(money_max);
                }
            }
        }

        private void But_Canel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void But_Confirm_Click(object sender, EventArgs e)
        {
            PlayerValue.Items.Add(after_item.ID, after_item.Number);
            PlayerValue.Items.Reduce(item_index, icnc_Main.Number);
            PlayerValue.Player.Money -= icnc_Main.Number * prize;
            Dispose();

        }
    }
}
