using System;
using System.Windows.Forms;
using 圣灵之战pre_alpha_4.Variable;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    public partial class frm_Sell : Form
    {
        public frm_Sell(int index)
        {
            InitializeComponent();
            this.index = index;
            item = PlayerValue.Items.GetItem(index);
        }
        readonly int index;
        Item item;
        private void Frm_Sell_Load(object sender, EventArgs e)
        {
            Text = "出售[" + item.Name + "]";
            icnc_Main.SetMax(item.Number);
        }
        private void Icnc_Main_NumberChanged(object sender, EventArgs e)
        {
            lab_PreView.Text = "共计：" + item.Prize * icnc_Main.Number + "$";
        }

        private void But_Canel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void But_Confirm_Click(object sender, EventArgs e)
        {
            PlayerValue.Items.Reduce(index, icnc_Main.Number);
            PlayerValue.Player.Money += icnc_Main.Number * item.Prize;
            Dispose();
        }
    }
}
