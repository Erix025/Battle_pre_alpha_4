using System.Windows.Forms;
using Index_Contorl_Library;
namespace 圣灵之战pre_alpha_4
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.m_Main = new System.Windows.Forms.MenuStrip();
            this.m_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Back = new System.Windows.Forms.ToolStripMenuItem();
            this.m_DebugExit = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tot_Player_Attribute = new System.Windows.Forms.ToolTip(this.components);
            this.gb_Attribute = new System.Windows.Forms.GroupBox();
            this.but_PlayerPrecise_Add = new System.Windows.Forms.Button();
            this.but_PlayerAgile_Add = new System.Windows.Forms.Button();
            this.but_PlayerDefense_Add = new System.Windows.Forms.Button();
            this.but_PlayerPower_Add = new System.Windows.Forms.Button();
            this.but_Player_HP_Add = new System.Windows.Forms.Button();
            this.lab_PlayerTalentPoints = new System.Windows.Forms.Label();
            this.lab_TalentPoints = new System.Windows.Forms.Label();
            this.lab_PlayerLv = new System.Windows.Forms.Label();
            this.lab_Precise = new System.Windows.Forms.Label();
            this.lab_Money = new System.Windows.Forms.Label();
            this.lab_Player_Hp = new System.Windows.Forms.Label();
            this.lab_Player_PP = new System.Windows.Forms.Label();
            this.lab_PlayerPrecise = new System.Windows.Forms.Label();
            this.lab_PP = new System.Windows.Forms.Label();
            this.lab_PlayerAgile = new System.Windows.Forms.Label();
            this.lab_Agile = new System.Windows.Forms.Label();
            this.lab_Defense = new System.Windows.Forms.Label();
            this.lab_PlayerDefense = new System.Windows.Forms.Label();
            this.lab_PlayerPower = new System.Windows.Forms.Label();
            this.lab_Power = new System.Windows.Forms.Label();
            this.lab_PlayerName = new System.Windows.Forms.Label();
            this.lab_HP = new System.Windows.Forms.Label();
            this.lab_PlayerExp = new System.Windows.Forms.Label();
            this.lab_PlayerMoney = new System.Windows.Forms.Label();
            this.lab_PlayerProfession = new System.Windows.Forms.Label();
            this.gb_Equipment = new System.Windows.Forms.GroupBox();
            this.but_TakeOffEquipment = new System.Windows.Forms.Button();
            this.lab_EquipmentInfo = new System.Windows.Forms.Label();
            this.rad_Equipment_10 = new System.Windows.Forms.RadioButton();
            this.rad_Equipment_9 = new System.Windows.Forms.RadioButton();
            this.rad_Equipment_7 = new System.Windows.Forms.RadioButton();
            this.rad_Equipment_8 = new System.Windows.Forms.RadioButton();
            this.rad_Equipment_6 = new System.Windows.Forms.RadioButton();
            this.rad_Equipment_5 = new System.Windows.Forms.RadioButton();
            this.rad_Equipment_3 = new System.Windows.Forms.RadioButton();
            this.rad_Equipment_4 = new System.Windows.Forms.RadioButton();
            this.rad_Equipment_2 = new System.Windows.Forms.RadioButton();
            this.rad_Equipment_1 = new System.Windows.Forms.RadioButton();
            this.gb_PlayerBag = new System.Windows.Forms.GroupBox();
            this.but_UsefulButton_4 = new System.Windows.Forms.Button();
            this.but_UsefulButton_3 = new System.Windows.Forms.Button();
            this.but_UsefulButton_2 = new System.Windows.Forms.Button();
            this.but_UsefulButton_1 = new System.Windows.Forms.Button();
            this.but_Shop = new System.Windows.Forms.Button();
            this.lab_BagItemsInfo = new System.Windows.Forms.Label();
            this.lst_PlayerBagCount = new System.Windows.Forms.ListBox();
            this.lst_PlayerBag = new System.Windows.Forms.ListBox();
            this.gb_Place = new System.Windows.Forms.GroupBox();
            this.lab_PlaceName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.gb_NPC = new System.Windows.Forms.GroupBox();
            this.lst_NPC = new System.Windows.Forms.ListBox();
            this.but_Other_2 = new System.Windows.Forms.Button();
            this.but_Other_1 = new System.Windows.Forms.Button();
            this.but_Talking = new System.Windows.Forms.Button();
            this.gb_Dialogs = new System.Windows.Forms.GroupBox();
            this.but_Mission = new System.Windows.Forms.Button();
            this.but_WorldMap = new System.Windows.Forms.Button();
            this.gb_Instance = new System.Windows.Forms.GroupBox();
            this.but_DekaronInstance = new System.Windows.Forms.Button();
            this.lst_InstanceState = new System.Windows.Forms.ListBox();
            this.lst_InstanceName = new System.Windows.Forms.ListBox();
            this.m_Main.SuspendLayout();
            this.gb_Attribute.SuspendLayout();
            this.gb_Equipment.SuspendLayout();
            this.gb_PlayerBag.SuspendLayout();
            this.gb_Place.SuspendLayout();
            this.gb_NPC.SuspendLayout();
            this.gb_Dialogs.SuspendLayout();
            this.gb_Instance.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // m_Main
            // 
            this.m_Main.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.m_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_Help,
            this.m_Back,
            this.m_DebugExit,
            this.m_Exit});
            this.m_Main.Location = new System.Drawing.Point(0, 0);
            this.m_Main.Name = "m_Main";
            this.m_Main.Size = new System.Drawing.Size(1904, 36);
            this.m_Main.TabIndex = 0;
            this.m_Main.Text = "MenuStrip1";
            // 
            // m_Help
            // 
            this.m_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_Update});
            this.m_Help.Name = "m_Help";
            this.m_Help.Size = new System.Drawing.Size(56, 32);
            this.m_Help.Text = "帮助";
            // 
            // m_Update
            // 
            this.m_Update.Name = "m_Update";
            this.m_Update.Size = new System.Drawing.Size(148, 32);
            this.m_Update.Text = "更新内容";
            // 
            // m_Back
            // 
            this.m_Back.Name = "m_Back";
            this.m_Back.Size = new System.Drawing.Size(120, 32);
            this.m_Back.Text = "返回标题画面";
            // 
            // m_DebugExit
            // 
            this.m_DebugExit.Name = "m_DebugExit";
            this.m_DebugExit.Size = new System.Drawing.Size(88, 32);
            this.m_DebugExit.Text = "调试退出";
            this.m_DebugExit.Click += new System.EventHandler(this.DebugExit_Click);
            // 
            // m_Exit
            // 
            this.m_Exit.Name = "m_Exit";
            this.m_Exit.Size = new System.Drawing.Size(136, 32);
            this.m_Exit.Text = "保存并退出游戏";
            // 
            // gb_Attribute
            // 
            this.gb_Attribute.Controls.Add(this.but_PlayerPrecise_Add);
            this.gb_Attribute.Controls.Add(this.but_PlayerAgile_Add);
            this.gb_Attribute.Controls.Add(this.but_PlayerDefense_Add);
            this.gb_Attribute.Controls.Add(this.but_PlayerPower_Add);
            this.gb_Attribute.Controls.Add(this.but_Player_HP_Add);
            this.gb_Attribute.Controls.Add(this.lab_PlayerTalentPoints);
            this.gb_Attribute.Controls.Add(this.lab_TalentPoints);
            this.gb_Attribute.Controls.Add(this.lab_PlayerLv);
            this.gb_Attribute.Controls.Add(this.lab_Precise);
            this.gb_Attribute.Controls.Add(this.lab_Money);
            this.gb_Attribute.Controls.Add(this.lab_Player_Hp);
            this.gb_Attribute.Controls.Add(this.lab_Player_PP);
            this.gb_Attribute.Controls.Add(this.lab_PlayerPrecise);
            this.gb_Attribute.Controls.Add(this.lab_PP);
            this.gb_Attribute.Controls.Add(this.lab_PlayerAgile);
            this.gb_Attribute.Controls.Add(this.lab_Agile);
            this.gb_Attribute.Controls.Add(this.lab_Defense);
            this.gb_Attribute.Controls.Add(this.lab_PlayerDefense);
            this.gb_Attribute.Controls.Add(this.lab_PlayerPower);
            this.gb_Attribute.Controls.Add(this.lab_Power);
            this.gb_Attribute.Controls.Add(this.lab_PlayerName);
            this.gb_Attribute.Controls.Add(this.lab_HP);
            this.gb_Attribute.Controls.Add(this.lab_PlayerExp);
            this.gb_Attribute.Controls.Add(this.lab_PlayerMoney);
            this.gb_Attribute.Controls.Add(this.lab_PlayerProfession);
            this.gb_Attribute.Location = new System.Drawing.Point(12, 39);
            this.gb_Attribute.Name = "gb_Attribute";
            this.gb_Attribute.Size = new System.Drawing.Size(298, 455);
            this.gb_Attribute.TabIndex = 1;
            this.gb_Attribute.TabStop = false;
            this.gb_Attribute.Text = "属性";
            // 
            // but_PlayerPrecise_Add
            // 
            this.but_PlayerPrecise_Add.Location = new System.Drawing.Point(239, 364);
            this.but_PlayerPrecise_Add.Name = "but_PlayerPrecise_Add";
            this.but_PlayerPrecise_Add.Size = new System.Drawing.Size(25, 23);
            this.but_PlayerPrecise_Add.TabIndex = 26;
            this.but_PlayerPrecise_Add.Text = "+";
            this.but_PlayerPrecise_Add.UseVisualStyleBackColor = true;
            this.but_PlayerPrecise_Add.Click += new System.EventHandler(this.But_PlayerPrecise_Add_Click);
            // 
            // but_PlayerAgile_Add
            // 
            this.but_PlayerAgile_Add.Location = new System.Drawing.Point(239, 326);
            this.but_PlayerAgile_Add.Name = "but_PlayerAgile_Add";
            this.but_PlayerAgile_Add.Size = new System.Drawing.Size(25, 23);
            this.but_PlayerAgile_Add.TabIndex = 26;
            this.but_PlayerAgile_Add.Text = "+";
            this.but_PlayerAgile_Add.UseVisualStyleBackColor = true;
            this.but_PlayerAgile_Add.Click += new System.EventHandler(this.But_PlayerAgile_Add_Click);
            // 
            // but_PlayerDefense_Add
            // 
            this.but_PlayerDefense_Add.Location = new System.Drawing.Point(239, 287);
            this.but_PlayerDefense_Add.Name = "but_PlayerDefense_Add";
            this.but_PlayerDefense_Add.Size = new System.Drawing.Size(25, 23);
            this.but_PlayerDefense_Add.TabIndex = 26;
            this.but_PlayerDefense_Add.Text = "+";
            this.but_PlayerDefense_Add.UseVisualStyleBackColor = true;
            this.but_PlayerDefense_Add.Click += new System.EventHandler(this.But_PlayerDefense_Add_Click);
            // 
            // but_PlayerPower_Add
            // 
            this.but_PlayerPower_Add.Location = new System.Drawing.Point(239, 246);
            this.but_PlayerPower_Add.Name = "but_PlayerPower_Add";
            this.but_PlayerPower_Add.Size = new System.Drawing.Size(25, 23);
            this.but_PlayerPower_Add.TabIndex = 26;
            this.but_PlayerPower_Add.Text = "+";
            this.but_PlayerPower_Add.UseVisualStyleBackColor = true;
            this.but_PlayerPower_Add.Click += new System.EventHandler(this.But_PlayerPower_Add_Click);
            // 
            // but_Player_HP_Add
            // 
            this.but_Player_HP_Add.Location = new System.Drawing.Point(239, 201);
            this.but_Player_HP_Add.Name = "but_Player_HP_Add";
            this.but_Player_HP_Add.Size = new System.Drawing.Size(25, 23);
            this.but_Player_HP_Add.TabIndex = 26;
            this.but_Player_HP_Add.Text = "+";
            this.but_Player_HP_Add.UseVisualStyleBackColor = true;
            this.but_Player_HP_Add.Click += new System.EventHandler(this.But_Player_HP_Add_Click);
            // 
            // lab_PlayerTalentPoints
            // 
            this.lab_PlayerTalentPoints.AutoSize = true;
            this.lab_PlayerTalentPoints.Location = new System.Drawing.Point(104, 402);
            this.lab_PlayerTalentPoints.Name = "lab_PlayerTalentPoints";
            this.lab_PlayerTalentPoints.Size = new System.Drawing.Size(64, 16);
            this.lab_PlayerTalentPoints.TabIndex = 25;
            this.lab_PlayerTalentPoints.Text = "Label17";
            // 
            // lab_TalentPoints
            // 
            this.lab_TalentPoints.AutoSize = true;
            this.lab_TalentPoints.Location = new System.Drawing.Point(33, 402);
            this.lab_TalentPoints.Name = "lab_TalentPoints";
            this.lab_TalentPoints.Size = new System.Drawing.Size(72, 16);
            this.lab_TalentPoints.TabIndex = 24;
            this.lab_TalentPoints.Text = "天赋点：";
            // 
            // lab_PlayerLv
            // 
            this.lab_PlayerLv.AutoSize = true;
            this.lab_PlayerLv.Location = new System.Drawing.Point(33, 85);
            this.lab_PlayerLv.Name = "lab_PlayerLv";
            this.lab_PlayerLv.Size = new System.Drawing.Size(40, 16);
            this.lab_PlayerLv.TabIndex = 1;
            this.lab_PlayerLv.Text = "Lv.1";
            // 
            // lab_Precise
            // 
            this.lab_Precise.AutoSize = true;
            this.lab_Precise.Location = new System.Drawing.Point(33, 367);
            this.lab_Precise.Name = "lab_Precise";
            this.lab_Precise.Size = new System.Drawing.Size(56, 16);
            this.lab_Precise.TabIndex = 2;
            this.lab_Precise.Text = "精准：";
            // 
            // lab_Money
            // 
            this.lab_Money.AutoSize = true;
            this.lab_Money.Location = new System.Drawing.Point(33, 126);
            this.lab_Money.Name = "lab_Money";
            this.lab_Money.Size = new System.Drawing.Size(56, 16);
            this.lab_Money.TabIndex = 23;
            this.lab_Money.Text = "金钱：";
            // 
            // lab_Player_Hp
            // 
            this.lab_Player_Hp.AutoSize = true;
            this.lab_Player_Hp.Location = new System.Drawing.Point(104, 208);
            this.lab_Player_Hp.Name = "lab_Player_Hp";
            this.lab_Player_Hp.Size = new System.Drawing.Size(56, 16);
            this.lab_Player_Hp.TabIndex = 12;
            this.lab_Player_Hp.Text = "Label9";
            // 
            // lab_Player_PP
            // 
            this.lab_Player_PP.AutoSize = true;
            this.lab_Player_PP.Location = new System.Drawing.Point(104, 164);
            this.lab_Player_PP.Name = "lab_Player_PP";
            this.lab_Player_PP.Size = new System.Drawing.Size(56, 16);
            this.lab_Player_PP.TabIndex = 11;
            this.lab_Player_PP.Text = "Label8";
            // 
            // lab_PlayerPrecise
            // 
            this.lab_PlayerPrecise.AutoSize = true;
            this.lab_PlayerPrecise.Location = new System.Drawing.Point(104, 367);
            this.lab_PlayerPrecise.Name = "lab_PlayerPrecise";
            this.lab_PlayerPrecise.Size = new System.Drawing.Size(64, 16);
            this.lab_PlayerPrecise.TabIndex = 20;
            this.lab_PlayerPrecise.Text = "Label17";
            // 
            // lab_PP
            // 
            this.lab_PP.AutoSize = true;
            this.lab_PP.Location = new System.Drawing.Point(33, 164);
            this.lab_PP.Name = "lab_PP";
            this.lab_PP.Size = new System.Drawing.Size(56, 16);
            this.lab_PP.TabIndex = 10;
            this.lab_PP.Text = "体力：";
            // 
            // lab_PlayerAgile
            // 
            this.lab_PlayerAgile.AutoSize = true;
            this.lab_PlayerAgile.Location = new System.Drawing.Point(104, 329);
            this.lab_PlayerAgile.Name = "lab_PlayerAgile";
            this.lab_PlayerAgile.Size = new System.Drawing.Size(64, 16);
            this.lab_PlayerAgile.TabIndex = 19;
            this.lab_PlayerAgile.Text = "Label16";
            // 
            // lab_Agile
            // 
            this.lab_Agile.AutoSize = true;
            this.lab_Agile.Location = new System.Drawing.Point(33, 329);
            this.lab_Agile.Name = "lab_Agile";
            this.lab_Agile.Size = new System.Drawing.Size(56, 16);
            this.lab_Agile.TabIndex = 18;
            this.lab_Agile.Text = "敏捷：";
            // 
            // lab_Defense
            // 
            this.lab_Defense.AutoSize = true;
            this.lab_Defense.Location = new System.Drawing.Point(33, 290);
            this.lab_Defense.Name = "lab_Defense";
            this.lab_Defense.Size = new System.Drawing.Size(56, 16);
            this.lab_Defense.TabIndex = 16;
            this.lab_Defense.Text = "防御：";
            // 
            // lab_PlayerDefense
            // 
            this.lab_PlayerDefense.AutoSize = true;
            this.lab_PlayerDefense.Location = new System.Drawing.Point(104, 290);
            this.lab_PlayerDefense.Name = "lab_PlayerDefense";
            this.lab_PlayerDefense.Size = new System.Drawing.Size(64, 16);
            this.lab_PlayerDefense.TabIndex = 17;
            this.lab_PlayerDefense.Text = "Label14";
            // 
            // lab_PlayerPower
            // 
            this.lab_PlayerPower.AutoSize = true;
            this.lab_PlayerPower.Location = new System.Drawing.Point(104, 249);
            this.lab_PlayerPower.Name = "lab_PlayerPower";
            this.lab_PlayerPower.Size = new System.Drawing.Size(64, 16);
            this.lab_PlayerPower.TabIndex = 15;
            this.lab_PlayerPower.Text = "Label12";
            // 
            // lab_Power
            // 
            this.lab_Power.AutoSize = true;
            this.lab_Power.Location = new System.Drawing.Point(33, 249);
            this.lab_Power.Name = "lab_Power";
            this.lab_Power.Size = new System.Drawing.Size(56, 16);
            this.lab_Power.TabIndex = 14;
            this.lab_Power.Text = "力量：";
            // 
            // lab_PlayerName
            // 
            this.lab_PlayerName.AutoSize = true;
            this.lab_PlayerName.Font = new System.Drawing.Font("宋体", 24F);
            this.lab_PlayerName.Location = new System.Drawing.Point(30, 30);
            this.lab_PlayerName.Name = "lab_PlayerName";
            this.lab_PlayerName.Size = new System.Drawing.Size(127, 33);
            this.lab_PlayerName.TabIndex = 0;
            this.lab_PlayerName.Text = "Eric025";
            // 
            // lab_HP
            // 
            this.lab_HP.AutoSize = true;
            this.lab_HP.Location = new System.Drawing.Point(33, 208);
            this.lab_HP.Name = "lab_HP";
            this.lab_HP.Size = new System.Drawing.Size(56, 16);
            this.lab_HP.TabIndex = 13;
            this.lab_HP.Text = "生命：";
            // 
            // lab_PlayerExp
            // 
            this.lab_PlayerExp.AutoSize = true;
            this.lab_PlayerExp.Location = new System.Drawing.Point(104, 85);
            this.lab_PlayerExp.Name = "lab_PlayerExp";
            this.lab_PlayerExp.Size = new System.Drawing.Size(160, 16);
            this.lab_PlayerExp.TabIndex = 7;
            this.lab_PlayerExp.Text = "499999 / 500000 Exp";
            // 
            // lab_PlayerMoney
            // 
            this.lab_PlayerMoney.AutoSize = true;
            this.lab_PlayerMoney.Location = new System.Drawing.Point(104, 126);
            this.lab_PlayerMoney.Name = "lab_PlayerMoney";
            this.lab_PlayerMoney.Size = new System.Drawing.Size(56, 16);
            this.lab_PlayerMoney.TabIndex = 9;
            this.lab_PlayerMoney.Text = "Label1";
            // 
            // lab_PlayerProfession
            // 
            this.lab_PlayerProfession.AutoSize = true;
            this.lab_PlayerProfession.Location = new System.Drawing.Point(204, 30);
            this.lab_PlayerProfession.Name = "lab_PlayerProfession";
            this.lab_PlayerProfession.Size = new System.Drawing.Size(40, 16);
            this.lab_PlayerProfession.TabIndex = 8;
            this.lab_PlayerProfession.Text = "战士";
            // 
            // gb_Equipment
            // 
            this.gb_Equipment.Controls.Add(this.but_TakeOffEquipment);
            this.gb_Equipment.Controls.Add(this.lab_EquipmentInfo);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_10);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_9);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_7);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_8);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_6);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_5);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_3);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_4);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_2);
            this.gb_Equipment.Controls.Add(this.rad_Equipment_1);
            this.gb_Equipment.Location = new System.Drawing.Point(12, 500);
            this.gb_Equipment.Name = "gb_Equipment";
            this.gb_Equipment.Size = new System.Drawing.Size(389, 488);
            this.gb_Equipment.TabIndex = 2;
            this.gb_Equipment.TabStop = false;
            this.gb_Equipment.Text = "装备栏";
            // 
            // but_TakeOffEquipment
            // 
            this.but_TakeOffEquipment.Location = new System.Drawing.Point(257, 437);
            this.but_TakeOffEquipment.Name = "but_TakeOffEquipment";
            this.but_TakeOffEquipment.Size = new System.Drawing.Size(91, 31);
            this.but_TakeOffEquipment.TabIndex = 2;
            this.but_TakeOffEquipment.Text = "卸下装备";
            this.but_TakeOffEquipment.UseCompatibleTextRendering = true;
            this.but_TakeOffEquipment.UseVisualStyleBackColor = true;
            this.but_TakeOffEquipment.Visible = false;
            this.but_TakeOffEquipment.Click += new System.EventHandler(this.But_TakeOffEquipment_Click);
            // 
            // lab_EquipmentInfo
            // 
            this.lab_EquipmentInfo.AutoSize = true;
            this.lab_EquipmentInfo.Location = new System.Drawing.Point(267, 22);
            this.lab_EquipmentInfo.Name = "lab_EquipmentInfo";
            this.lab_EquipmentInfo.Size = new System.Drawing.Size(0, 16);
            this.lab_EquipmentInfo.TabIndex = 1;
            // 
            // rad_Equipment_10
            // 
            this.rad_Equipment_10.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_10.AutoSize = true;
            this.rad_Equipment_10.Location = new System.Drawing.Point(151, 426);
            this.rad_Equipment_10.Name = "rad_Equipment_10";
            this.rad_Equipment_10.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_10.TabIndex = 0;
            this.rad_Equipment_10.Text = "主武器:\r\n未装备";
            this.rad_Equipment_10.UseVisualStyleBackColor = true;
            this.rad_Equipment_10.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // rad_Equipment_9
            // 
            this.rad_Equipment_9.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_9.AutoSize = true;
            this.rad_Equipment_9.Location = new System.Drawing.Point(3, 426);
            this.rad_Equipment_9.Name = "rad_Equipment_9";
            this.rad_Equipment_9.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_9.TabIndex = 0;
            this.rad_Equipment_9.Text = "主武器:\r\n未装备";
            this.rad_Equipment_9.UseVisualStyleBackColor = true;
            this.rad_Equipment_9.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // rad_Equipment_7
            // 
            this.rad_Equipment_7.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_7.AutoSize = true;
            this.rad_Equipment_7.Location = new System.Drawing.Point(3, 325);
            this.rad_Equipment_7.Name = "rad_Equipment_7";
            this.rad_Equipment_7.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_7.TabIndex = 0;
            this.rad_Equipment_7.Text = "主武器:\r\n未装备";
            this.rad_Equipment_7.UseVisualStyleBackColor = true;
            this.rad_Equipment_7.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // rad_Equipment_8
            // 
            this.rad_Equipment_8.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_8.AutoSize = true;
            this.rad_Equipment_8.Location = new System.Drawing.Point(151, 325);
            this.rad_Equipment_8.Name = "rad_Equipment_8";
            this.rad_Equipment_8.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_8.TabIndex = 0;
            this.rad_Equipment_8.Text = "主武器:\r\n未装备";
            this.rad_Equipment_8.UseVisualStyleBackColor = true;
            this.rad_Equipment_8.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // rad_Equipment_6
            // 
            this.rad_Equipment_6.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_6.AutoSize = true;
            this.rad_Equipment_6.Location = new System.Drawing.Point(151, 224);
            this.rad_Equipment_6.Name = "rad_Equipment_6";
            this.rad_Equipment_6.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_6.TabIndex = 0;
            this.rad_Equipment_6.Text = "主武器:\r\n未装备";
            this.rad_Equipment_6.UseVisualStyleBackColor = true;
            this.rad_Equipment_6.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // rad_Equipment_5
            // 
            this.rad_Equipment_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_5.AutoSize = true;
            this.rad_Equipment_5.Location = new System.Drawing.Point(3, 224);
            this.rad_Equipment_5.Name = "rad_Equipment_5";
            this.rad_Equipment_5.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_5.TabIndex = 0;
            this.rad_Equipment_5.Text = "主武器:\r\n未装备";
            this.rad_Equipment_5.UseVisualStyleBackColor = true;
            this.rad_Equipment_5.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // rad_Equipment_3
            // 
            this.rad_Equipment_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_3.AutoSize = true;
            this.rad_Equipment_3.Location = new System.Drawing.Point(3, 123);
            this.rad_Equipment_3.Name = "rad_Equipment_3";
            this.rad_Equipment_3.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_3.TabIndex = 0;
            this.rad_Equipment_3.Text = "主武器:\r\n未装备";
            this.rad_Equipment_3.UseVisualStyleBackColor = true;
            this.rad_Equipment_3.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // rad_Equipment_4
            // 
            this.rad_Equipment_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_4.AutoSize = true;
            this.rad_Equipment_4.Location = new System.Drawing.Point(151, 123);
            this.rad_Equipment_4.Name = "rad_Equipment_4";
            this.rad_Equipment_4.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_4.TabIndex = 0;
            this.rad_Equipment_4.Text = "主武器:\r\n未装备";
            this.rad_Equipment_4.UseVisualStyleBackColor = true;
            this.rad_Equipment_4.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // rad_Equipment_2
            // 
            this.rad_Equipment_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_2.AutoSize = true;
            this.rad_Equipment_2.Location = new System.Drawing.Point(151, 22);
            this.rad_Equipment_2.Name = "rad_Equipment_2";
            this.rad_Equipment_2.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_2.TabIndex = 0;
            this.rad_Equipment_2.Text = "主武器:\r\n未装备";
            this.rad_Equipment_2.UseVisualStyleBackColor = true;
            this.rad_Equipment_2.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // rad_Equipment_1
            // 
            this.rad_Equipment_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_Equipment_1.AutoSize = true;
            this.rad_Equipment_1.Location = new System.Drawing.Point(3, 22);
            this.rad_Equipment_1.Name = "rad_Equipment_1";
            this.rad_Equipment_1.Size = new System.Drawing.Size(74, 42);
            this.rad_Equipment_1.TabIndex = 0;
            this.rad_Equipment_1.Text = "主武器:\r\n未装备";
            this.rad_Equipment_1.UseVisualStyleBackColor = true;
            this.rad_Equipment_1.CheckedChanged += new System.EventHandler(this.Rad_Equipments_Click);
            // 
            // gb_PlayerBag
            // 
            this.gb_PlayerBag.Controls.Add(this.but_UsefulButton_4);
            this.gb_PlayerBag.Controls.Add(this.but_UsefulButton_3);
            this.gb_PlayerBag.Controls.Add(this.but_UsefulButton_2);
            this.gb_PlayerBag.Controls.Add(this.but_UsefulButton_1);
            this.gb_PlayerBag.Controls.Add(this.but_Shop);
            this.gb_PlayerBag.Controls.Add(this.lab_BagItemsInfo);
            this.gb_PlayerBag.Controls.Add(this.lst_PlayerBagCount);
            this.gb_PlayerBag.Controls.Add(this.lst_PlayerBag);
            this.gb_PlayerBag.Location = new System.Drawing.Point(316, 40);
            this.gb_PlayerBag.Name = "gb_PlayerBag";
            this.gb_PlayerBag.Size = new System.Drawing.Size(308, 454);
            this.gb_PlayerBag.TabIndex = 3;
            this.gb_PlayerBag.TabStop = false;
            this.gb_PlayerBag.Text = "背包";
            // 
            // but_UsefulButton_4
            // 
            this.but_UsefulButton_4.Location = new System.Drawing.Point(229, 206);
            this.but_UsefulButton_4.Name = "but_UsefulButton_4";
            this.but_UsefulButton_4.Size = new System.Drawing.Size(64, 28);
            this.but_UsefulButton_4.TabIndex = 6;
            this.but_UsefulButton_4.UseVisualStyleBackColor = true;
            this.but_UsefulButton_4.Visible = false;
            this.but_UsefulButton_4.Click += new System.EventHandler(this.But_UsefulButton_Click);
            // 
            // but_UsefulButton_3
            // 
            this.but_UsefulButton_3.Location = new System.Drawing.Point(229, 160);
            this.but_UsefulButton_3.Name = "but_UsefulButton_3";
            this.but_UsefulButton_3.Size = new System.Drawing.Size(64, 28);
            this.but_UsefulButton_3.TabIndex = 6;
            this.but_UsefulButton_3.UseVisualStyleBackColor = true;
            this.but_UsefulButton_3.Visible = false;
            this.but_UsefulButton_3.Click += new System.EventHandler(this.But_UsefulButton_Click);
            // 
            // but_UsefulButton_2
            // 
            this.but_UsefulButton_2.Location = new System.Drawing.Point(229, 114);
            this.but_UsefulButton_2.Name = "but_UsefulButton_2";
            this.but_UsefulButton_2.Size = new System.Drawing.Size(64, 28);
            this.but_UsefulButton_2.TabIndex = 6;
            this.but_UsefulButton_2.UseVisualStyleBackColor = true;
            this.but_UsefulButton_2.Visible = false;
            this.but_UsefulButton_2.Click += new System.EventHandler(this.But_UsefulButton_Click);
            // 
            // but_UsefulButton_1
            // 
            this.but_UsefulButton_1.Location = new System.Drawing.Point(229, 68);
            this.but_UsefulButton_1.Name = "but_UsefulButton_1";
            this.but_UsefulButton_1.Size = new System.Drawing.Size(64, 28);
            this.but_UsefulButton_1.TabIndex = 6;
            this.but_UsefulButton_1.UseVisualStyleBackColor = true;
            this.but_UsefulButton_1.Visible = false;
            this.but_UsefulButton_1.Click += new System.EventHandler(this.But_UsefulButton_Click);
            // 
            // but_Shop
            // 
            this.but_Shop.Location = new System.Drawing.Point(229, 22);
            this.but_Shop.Name = "but_Shop";
            this.but_Shop.Size = new System.Drawing.Size(64, 28);
            this.but_Shop.TabIndex = 6;
            this.but_Shop.Text = "商城";
            this.but_Shop.UseVisualStyleBackColor = true;
            this.but_Shop.Click += new System.EventHandler(this.But_Shop_Click);
            // 
            // lab_BagItemsInfo
            // 
            this.lab_BagItemsInfo.Location = new System.Drawing.Point(6, 317);
            this.lab_BagItemsInfo.Name = "lab_BagItemsInfo";
            this.lab_BagItemsInfo.Size = new System.Drawing.Size(296, 121);
            this.lab_BagItemsInfo.TabIndex = 2;
            // 
            // lst_PlayerBagCount
            // 
            this.lst_PlayerBagCount.FormattingEnabled = true;
            this.lst_PlayerBagCount.ItemHeight = 16;
            this.lst_PlayerBagCount.Location = new System.Drawing.Point(179, 22);
            this.lst_PlayerBagCount.Name = "lst_PlayerBagCount";
            this.lst_PlayerBagCount.Size = new System.Drawing.Size(40, 292);
            this.lst_PlayerBagCount.TabIndex = 1;
            this.lst_PlayerBagCount.SelectedIndexChanged += new System.EventHandler(this.Lst_PlayerBagCount_SelectedIndexChanged);
            // 
            // lst_PlayerBag
            // 
            this.lst_PlayerBag.FormattingEnabled = true;
            this.lst_PlayerBag.ItemHeight = 16;
            this.lst_PlayerBag.Location = new System.Drawing.Point(3, 22);
            this.lst_PlayerBag.Name = "lst_PlayerBag";
            this.lst_PlayerBag.Size = new System.Drawing.Size(177, 292);
            this.lst_PlayerBag.TabIndex = 0;
            this.lst_PlayerBag.SelectedIndexChanged += new System.EventHandler(this.Lst_PlayerBag_SelectedIndexChanged);
            // 
            // gb_Place
            // 
            this.gb_Place.Controls.Add(this.lab_PlaceName);
            this.gb_Place.Controls.Add(this.Label1);
            this.gb_Place.Location = new System.Drawing.Point(818, 40);
            this.gb_Place.Name = "gb_Place";
            this.gb_Place.Size = new System.Drawing.Size(268, 142);
            this.gb_Place.TabIndex = 4;
            this.gb_Place.TabStop = false;
            // 
            // lab_PlaceName
            // 
            this.lab_PlaceName.Font = new System.Drawing.Font("楷体", 32F);
            this.lab_PlaceName.Location = new System.Drawing.Point(6, 84);
            this.lab_PlaceName.Name = "lab_PlaceName";
            this.lab_PlaceName.Size = new System.Drawing.Size(256, 43);
            this.lab_PlaceName.TabIndex = 1;
            this.lab_PlaceName.Text = "月之城";
            this.lab_PlaceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("楷体", 26F);
            this.Label1.Location = new System.Drawing.Point(59, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(159, 35);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "当前场景";
            // 
            // gb_NPC
            // 
            this.gb_NPC.Controls.Add(this.lst_NPC);
            this.gb_NPC.Controls.Add(this.but_Other_2);
            this.gb_NPC.Controls.Add(this.but_Other_1);
            this.gb_NPC.Controls.Add(this.but_Talking);
            this.gb_NPC.Location = new System.Drawing.Point(630, 188);
            this.gb_NPC.Name = "gb_NPC";
            this.gb_NPC.Size = new System.Drawing.Size(245, 306);
            this.gb_NPC.TabIndex = 5;
            this.gb_NPC.TabStop = false;
            this.gb_NPC.Text = "NPC";
            // 
            // lst_NPC
            // 
            this.lst_NPC.FormattingEnabled = true;
            this.lst_NPC.ItemHeight = 16;
            this.lst_NPC.Location = new System.Drawing.Point(3, 22);
            this.lst_NPC.Name = "lst_NPC";
            this.lst_NPC.Size = new System.Drawing.Size(157, 276);
            this.lst_NPC.TabIndex = 0;
            // 
            // but_Other_2
            // 
            this.but_Other_2.Location = new System.Drawing.Point(169, 117);
            this.but_Other_2.Name = "but_Other_2";
            this.but_Other_2.Size = new System.Drawing.Size(64, 28);
            this.but_Other_2.TabIndex = 6;
            this.but_Other_2.UseVisualStyleBackColor = true;
            this.but_Other_2.Visible = false;
            // 
            // but_Other_1
            // 
            this.but_Other_1.Location = new System.Drawing.Point(169, 68);
            this.but_Other_1.Name = "but_Other_1";
            this.but_Other_1.Size = new System.Drawing.Size(64, 28);
            this.but_Other_1.TabIndex = 6;
            this.but_Other_1.UseVisualStyleBackColor = true;
            this.but_Other_1.Visible = false;
            // 
            // but_Talking
            // 
            this.but_Talking.Location = new System.Drawing.Point(169, 21);
            this.but_Talking.Name = "but_Talking";
            this.but_Talking.Size = new System.Drawing.Size(64, 28);
            this.but_Talking.TabIndex = 6;
            this.but_Talking.Text = "交谈";
            this.but_Talking.UseVisualStyleBackColor = true;
            this.but_Talking.Visible = false;
            // 
            // gb_Dialogs
            // 
            this.gb_Dialogs.Controls.Add(this.but_Mission);
            this.gb_Dialogs.Controls.Add(this.but_WorldMap);
            this.gb_Dialogs.Location = new System.Drawing.Point(1770, 36);
            this.gb_Dialogs.Name = "gb_Dialogs";
            this.gb_Dialogs.Size = new System.Drawing.Size(134, 966);
            this.gb_Dialogs.TabIndex = 6;
            this.gb_Dialogs.TabStop = false;
            // 
            // but_Mission
            // 
            this.but_Mission.Location = new System.Drawing.Point(6, 74);
            this.but_Mission.Name = "but_Mission";
            this.but_Mission.Size = new System.Drawing.Size(122, 52);
            this.but_Mission.TabIndex = 0;
            this.but_Mission.Text = "任务";
            this.but_Mission.UseVisualStyleBackColor = true;
            // 
            // but_WorldMap
            // 
            this.but_WorldMap.Location = new System.Drawing.Point(6, 16);
            this.but_WorldMap.Name = "but_WorldMap";
            this.but_WorldMap.Size = new System.Drawing.Size(122, 52);
            this.but_WorldMap.TabIndex = 0;
            this.but_WorldMap.Text = "世界地图";
            this.but_WorldMap.UseVisualStyleBackColor = true;
            // 
            // gb_Instance
            // 
            this.gb_Instance.Controls.Add(this.but_DekaronInstance);
            this.gb_Instance.Controls.Add(this.lst_InstanceState);
            this.gb_Instance.Controls.Add(this.lst_InstanceName);
            this.gb_Instance.Location = new System.Drawing.Point(889, 188);
            this.gb_Instance.Name = "gb_Instance";
            this.gb_Instance.Size = new System.Drawing.Size(226, 306);
            this.gb_Instance.TabIndex = 7;
            this.gb_Instance.TabStop = false;
            this.gb_Instance.Text = "副本";
            // 
            // but_DekaronInstance
            // 
            this.but_DekaronInstance.Location = new System.Drawing.Point(15, 249);
            this.but_DekaronInstance.Name = "but_DekaronInstance";
            this.but_DekaronInstance.Size = new System.Drawing.Size(81, 41);
            this.but_DekaronInstance.TabIndex = 2;
            this.but_DekaronInstance.Text = "挑战副本";
            this.but_DekaronInstance.UseVisualStyleBackColor = true;
            this.but_DekaronInstance.Visible = false;
            // 
            // lst_InstanceState
            // 
            this.lst_InstanceState.FormattingEnabled = true;
            this.lst_InstanceState.ItemHeight = 16;
            this.lst_InstanceState.Location = new System.Drawing.Point(146, 21);
            this.lst_InstanceState.Name = "lst_InstanceState";
            this.lst_InstanceState.Size = new System.Drawing.Size(72, 212);
            this.lst_InstanceState.TabIndex = 1;
            // 
            // lst_InstanceName
            // 
            this.lst_InstanceName.FormattingEnabled = true;
            this.lst_InstanceName.ItemHeight = 16;
            this.lst_InstanceName.Location = new System.Drawing.Point(6, 21);
            this.lst_InstanceName.Name = "lst_InstanceName";
            this.lst_InstanceName.Size = new System.Drawing.Size(141, 212);
            this.lst_InstanceName.TabIndex = 0;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1000);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Instance);
            this.Controls.Add(this.gb_Dialogs);
            this.Controls.Add(this.gb_NPC);
            this.Controls.Add(this.gb_Place);
            this.Controls.Add(this.gb_PlayerBag);
            this.Controls.Add(this.gb_Equipment);
            this.Controls.Add(this.gb_Attribute);
            this.Controls.Add(this.m_Main);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.m_Main;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "圣灵之战pre_Alpha_4";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.m_Main.ResumeLayout(false);
            this.m_Main.PerformLayout();
            this.gb_Attribute.ResumeLayout(false);
            this.gb_Attribute.PerformLayout();
            this.gb_Equipment.ResumeLayout(false);
            this.gb_Equipment.PerformLayout();
            this.gb_PlayerBag.ResumeLayout(false);
            this.gb_Place.ResumeLayout(false);
            this.gb_Place.PerformLayout();
            this.gb_NPC.ResumeLayout(false);
            this.gb_Dialogs.ResumeLayout(false);
            this.gb_Instance.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private MenuStrip m_Main;
        private ToolStripMenuItem m_Help;
        private ToolStripMenuItem m_Update;
        private ToolStripMenuItem m_Back;
        private ToolTip tot_Player_Attribute;
        private GroupBox gb_Attribute;
        private Button but_PlayerPrecise_Add;
        private Button but_PlayerAgile_Add;
        private Button but_PlayerDefense_Add;
        private Button but_PlayerPower_Add;
        private Button but_Player_HP_Add;
        private Label lab_PlayerTalentPoints;
        private Label lab_TalentPoints;
        private Label lab_Precise;
        private Label lab_PlayerLv;
        private Label lab_Money;
        private Label lab_Player_Hp;
        private Label lab_Player_PP;
        private Label lab_PlayerPrecise;
        private Label lab_PP;
        private Label lab_PlayerAgile;
        private Label lab_Agile;
        private Label lab_Defense;
        private Label lab_PlayerDefense;
        private Label lab_PlayerPower;
        private Label lab_Power;
        private Label lab_PlayerName;
        private Label lab_HP;
        private Label lab_PlayerExp;
        private Label lab_PlayerMoney;
        private Label lab_PlayerProfession;
        private GroupBox gb_Equipment;
        private RadioButton rad_Equipment_1;
        private RadioButton rad_Equipment_10;
        private RadioButton rad_Equipment_9;
        private RadioButton rad_Equipment_7;
        private RadioButton rad_Equipment_8;
        private RadioButton rad_Equipment_6;
        private RadioButton rad_Equipment_5;
        private RadioButton rad_Equipment_3;
        private RadioButton rad_Equipment_4;
        private RadioButton rad_Equipment_2;
        private Label lab_EquipmentInfo;
        private Button but_TakeOffEquipment;
        private GroupBox gb_PlayerBag;
        private ListBox lst_PlayerBagCount;
        private ListBox lst_PlayerBag;
        private Label lab_BagItemsInfo;
        private Button but_Shop;
        private Button but_UsefulButton_3;
        private Button but_UsefulButton_2;
        private Button but_UsefulButton_1;
        private Button but_UsefulButton_4;
        private GroupBox gb_Place;
        private Label lab_PlaceName;
        private Label Label1;
        private GroupBox gb_NPC;
        private ListBox lst_NPC;
        private Button but_Other_2;
        private Button but_Other_1;
        private Button but_Talking;
        private ToolStripMenuItem m_DebugExit;
        private GroupBox gb_Dialogs;
        private Button but_WorldMap;
        private GroupBox gb_Instance;
        private Button but_DekaronInstance;
        private ListBox lst_InstanceState;
        private ListBox lst_InstanceName;
        private ToolStripMenuItem m_Exit;
        private Button but_Mission;
    }
}