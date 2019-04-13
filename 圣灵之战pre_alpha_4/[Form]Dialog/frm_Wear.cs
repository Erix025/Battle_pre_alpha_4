using System;
using System.Windows.Forms;
using 圣灵之战pre_alpha_4.Variable;
using 圣灵之战pre_alpha_4.FinalValue;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    public partial class frm_Wear : Form
    {
        public frm_Wear(int index)
        {
            InitializeComponent();
            this.index = index;
            equipment = new Equipment(PlayerValue.Items.GetItem(index).ID);
            tybe = equipment.Tybe;
        }
        readonly int index;
        readonly Equipment equipment;
        readonly EquipmentTybe tybe;
        private void Frm_Wear_Load(object sender, EventArgs e)
        { 
            Equipment primary_equipment = PlayerValue.Player.Equipments.GetEquipment(tybe);
            string tem_str;
            if (primary_equipment != null)
            {
                tem_str = primary_equipment.Name + "\n";
                for (int i = 0; i < 6; i++)
                {
                    AttributeValue value = AttributeName.GetAttributeValue(i);
                    if (primary_equipment.GetAdditive(value) != 0)
                    {
                        tem_str += AttributeName.GetAttributeName(value) + Function.GetValueSymbol(primary_equipment.GetAdditive(value)) + "\n";
                    }
                }
            }
            else
            {
                tem_str = "未装备";
            }
            lab_PrimaryEquipment.Text = tem_str;
            tem_str = equipment.Name + "\n";
            for(int i=0; i < 6; i++)
            {
                var value = AttributeName.GetAttributeValue(i);
                if(equipment.GetAdditive(value) != 0)
                {
                    tem_str += AttributeName.GetAttributeName(value) + Function.GetValueSymbol(equipment.GetAdditive(value)) + "\n";
                }
            }
            lab_NowEquipment.Text = tem_str;
        }

        private void But_Canel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void But_Confirm_Click(object sender, EventArgs e)
        {
            if (PlayerValue.Player.Equipments.GetEquipment(tybe) != null)
            {
                PlayerValue.Items.Add(PlayerValue.Player.Equipments.GetEquipment(tybe).ID, 1);
                PlayerValue.Player.Equipments.DeleteEquipment(tybe);
            }
            PlayerValue.Player.Equipments.SetEquipment(equipment);
            PlayerValue.Items.Reduce(index, 1);
            Dispose();
        }
    }
}
