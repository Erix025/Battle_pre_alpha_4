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
    public partial class frm_CreatePlayer : Form
    {
        public frm_CreatePlayer()
        {
            InitializeComponent();
        }

        private void txt_PlayerName_TextChanged(object sender, EventArgs e)
        {
            ChangedCheck();
        }

        private void cbx_PlayerPrefession_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedCheck();
        }
        private void ChangedCheck()
        {
            if(txt_PlayerName.Text!="" && cbx_PlayerPrefession.Text != "")
            {
                but_Confirm.Enabled = true;
            }
            else
            {
                but_Confirm.Enabled = false;
            }
        }

        private void but_Confirm_Click(object sender, EventArgs e)
        {
            foreach(Player tem in GameValue.Players.GetArray())
            {
                if(tem.Name == txt_PlayerName.Text)
                {
                    MessageBox.Show("【错误】无法创建角色"+"\r\n"+"已存在名为【" + tem.Name + "】的角色");
                    return;
                }
            }
            PlayerValue.PlayerCreate(txt_PlayerName.Text, cbx_PlayerPrefession.Text);
            Dispose();
        }

        private void but_Canel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
