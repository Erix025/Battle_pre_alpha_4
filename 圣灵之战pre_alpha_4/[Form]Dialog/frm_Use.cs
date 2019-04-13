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
using 圣灵之战pre_alpha_4.FinalValue;

namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    public partial class frm_Use : Form
    {
        public frm_Use(int index)
        {
            InitializeComponent();
            this.index = index;
            item = PlayerValue.Items.GetItem(index);
        }
        readonly int index;
        readonly Item item;
        private void But_Canel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void Frm_Use_Load(object sender, EventArgs e)
        {
            Text = "使用[" + item.Name + "]";
            icnc_Main.SetMax(item.Number);
        }
        private void Icnc_Main_NumberChanged(object sender, EventArgs e)
        {
            string result = "共计：";
            foreach(Additive tem in item.Additives.GetArray())
            {
                if(tem.Key.Substring(0,1) == "U")
                {
                    result += "  " + FinalValue.AdditiveName.GetAdditiveName(tem.Key.Substring(2)) + Function.GetValueSymbol(icnc_Main.Number * int.Parse(tem.Value));
                }
            }
            lab_PreView.Text = result;
        }


        private void But_Confirm_Click(object sender, EventArgs e)
        {
            foreach(Additive tem in item.Additives.GetArray())
            {
                if (tem.Key.Substring(0, 1) == "U")
                {
                    int value = int.Parse(tem.Value) * icnc_Main.Number;
                    switch (tem.Key.Substring(2))
                    {
                        case "HP":
                            PlayerValue.Player.AddHp(value);
                            break;
                        case "PP":
                            PlayerValue.Player.AddPP(value);
                            break;
                    }
                }
            }
            PlayerValue.Items.Reduce(index, icnc_Main.Number);
            Dispose();
        }
    }
}
