using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using 圣灵之战pre_alpha_4.Variable;
using 圣灵之战pre_alpha_4._Form_Dialog;

namespace 圣灵之战pre_alpha_4
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            GameValue.GamePlayersDataLoad();
            GameValue.GameDataLoad();
            foreach(Player tem in GameValue.Players)
            {
                lst_PlayerName.Items.Add(tem.Name);
            }
        }

        private void lst_PlayerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_PlayerName.SelectedIndex != -1)
            {
                Player player = GameValue.Players[lst_PlayerName.SelectedIndex];
                lab_PlayerAttribute.Text = player.Name + "\r\n" + "Lv. " + player.GetLv();
                but_Start.Enabled = true;
                but_DelPlayer.Enabled = true;
            }
        }
        private void but_AddPlayer_Click(object sender, EventArgs e)
        {
            frm_CreatePlayer frm_CreatePlayer = new frm_CreatePlayer();
            frm_CreatePlayer.ShowDialog(this);
            ReFresh();
        }

        private void but_DelPlayer_Click(object sender, EventArgs e)
        {
            PlayerValue.PlayerDelete(lst_PlayerName.SelectedIndex);
            ReFresh();
        }
        private void ReFresh()
        {
            lst_PlayerName.Items.Clear();
            lab_PlayerAttribute.Text = "";
            foreach(Player tem in GameValue.Players)
            {
                lst_PlayerName.Items.Add(tem.Name);
            }
            but_Start.Enabled = false;
            but_DelPlayer.Enabled = false;
        }

        private void but_Start_Click(object sender, EventArgs e)
        {
            PlayerValue.PlayerDataLoad(GameValue.Players[lst_PlayerName.SelectedIndex].Name);
            frm_Main frm_Main = new frm_Main();
            frm_Main.Show();
            Dispose(false);
        }
    }
}
