using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_Fighting
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
            this.gb_PlayerAttribute = new System.Windows.Forms.GroupBox();
            this.pro_PlayerHitPoints = new System.Windows.Forms.ProgressBar();
            this.lab_PlayerHitPoints = new System.Windows.Forms.Label();
            this.lab_PlayerName = new System.Windows.Forms.Label();
            this.txt_thisssage = new System.Windows.Forms.TextBox();
            this.gb_MonsterAttribute = new System.Windows.Forms.GroupBox();
            this.pro_MonsterHitPoints = new System.Windows.Forms.ProgressBar();
            this.lab_MonsterHitPoints = new System.Windows.Forms.Label();
            this.lab_MonsterName = new System.Windows.Forms.Label();
            this.gb_PlayerSkill = new System.Windows.Forms.GroupBox();
            this.but_Skill_4 = new System.Windows.Forms.Button();
            this.but_Skill_2 = new System.Windows.Forms.Button();
            this.but_TelentSkill = new System.Windows.Forms.Button();
            this.but_Skill_3 = new System.Windows.Forms.Button();
            this.but_Skill_1 = new System.Windows.Forms.Button();
            this.but_ATK = new System.Windows.Forms.Button();
            this.gb_Useful = new System.Windows.Forms.GroupBox();
            this.but_ReTreat = new System.Windows.Forms.Button();
            this.but_Items = new System.Windows.Forms.Button();
            this.but_Back = new System.Windows.Forms.Button();
            this.gb_PlayerAttribute.SuspendLayout();
            this.gb_MonsterAttribute.SuspendLayout();
            this.gb_PlayerSkill.SuspendLayout();
            this.gb_Useful.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_PlayerAttribute
            // 
            this.gb_PlayerAttribute.Controls.Add(this.pro_PlayerHitPoints);
            this.gb_PlayerAttribute.Controls.Add(this.lab_PlayerHitPoints);
            this.gb_PlayerAttribute.Controls.Add(this.lab_PlayerName);
            this.gb_PlayerAttribute.Location = new System.Drawing.Point(12, 12);
            this.gb_PlayerAttribute.Name = "gb_PlayerAttribute";
            this.gb_PlayerAttribute.Size = new System.Drawing.Size(254, 147);
            this.gb_PlayerAttribute.TabIndex = 0;
            this.gb_PlayerAttribute.TabStop = false;
            this.gb_PlayerAttribute.Text = "玩家属性";
            // 
            // pro_PlayerHitPoints
            // 
            this.pro_PlayerHitPoints.Location = new System.Drawing.Point(18, 99);
            this.pro_PlayerHitPoints.Name = "pro_PlayerHitPoints";
            this.pro_PlayerHitPoints.Size = new System.Drawing.Size(210, 23);
            this.pro_PlayerHitPoints.TabIndex = 2;
            // 
            // lab_PlayerHitPoints
            // 
            this.lab_PlayerHitPoints.AutoSize = true;
            this.lab_PlayerHitPoints.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PlayerHitPoints.Location = new System.Drawing.Point(12, 63);
            this.lab_PlayerHitPoints.Name = "lab_PlayerHitPoints";
            this.lab_PlayerHitPoints.Size = new System.Drawing.Size(53, 33);
            this.lab_PlayerHitPoints.TabIndex = 1;
            this.lab_PlayerHitPoints.Text = "HP:";
            // 
            // lab_PlayerName
            // 
            this.lab_PlayerName.AutoSize = true;
            this.lab_PlayerName.Font = new System.Drawing.Font("宋体", 26F);
            this.lab_PlayerName.Location = new System.Drawing.Point(12, 22);
            this.lab_PlayerName.Name = "lab_PlayerName";
            this.lab_PlayerName.Size = new System.Drawing.Size(141, 35);
            this.lab_PlayerName.TabIndex = 0;
            this.lab_PlayerName.Text = "Eric025";
            // 
            // txt_thisssage
            // 
            this.txt_thisssage.Location = new System.Drawing.Point(272, 12);
            this.txt_thisssage.Multiline = true;
            this.txt_thisssage.Name = "txt_thisssage";
            this.txt_thisssage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_thisssage.Size = new System.Drawing.Size(244, 352);
            this.txt_thisssage.TabIndex = 1;
            // 
            // gb_MonsterAttribute
            // 
            this.gb_MonsterAttribute.Controls.Add(this.pro_MonsterHitPoints);
            this.gb_MonsterAttribute.Controls.Add(this.lab_MonsterHitPoints);
            this.gb_MonsterAttribute.Controls.Add(this.lab_MonsterName);
            this.gb_MonsterAttribute.Location = new System.Drawing.Point(522, 12);
            this.gb_MonsterAttribute.Name = "gb_MonsterAttribute";
            this.gb_MonsterAttribute.Size = new System.Drawing.Size(254, 147);
            this.gb_MonsterAttribute.TabIndex = 0;
            this.gb_MonsterAttribute.TabStop = false;
            this.gb_MonsterAttribute.Text = "玩家属性";
            // 
            // pro_MonsterHitPoints
            // 
            this.pro_MonsterHitPoints.Location = new System.Drawing.Point(18, 99);
            this.pro_MonsterHitPoints.Name = "pro_MonsterHitPoints";
            this.pro_MonsterHitPoints.Size = new System.Drawing.Size(210, 23);
            this.pro_MonsterHitPoints.TabIndex = 2;
            // 
            // lab_MonsterHitPoints
            // 
            this.lab_MonsterHitPoints.AutoSize = true;
            this.lab_MonsterHitPoints.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MonsterHitPoints.Location = new System.Drawing.Point(12, 63);
            this.lab_MonsterHitPoints.Name = "lab_MonsterHitPoints";
            this.lab_MonsterHitPoints.Size = new System.Drawing.Size(53, 33);
            this.lab_MonsterHitPoints.TabIndex = 1;
            this.lab_MonsterHitPoints.Text = "HP:";
            // 
            // lab_MonsterName
            // 
            this.lab_MonsterName.AutoSize = true;
            this.lab_MonsterName.Font = new System.Drawing.Font("宋体", 26F);
            this.lab_MonsterName.Location = new System.Drawing.Point(12, 22);
            this.lab_MonsterName.Name = "lab_MonsterName";
            this.lab_MonsterName.Size = new System.Drawing.Size(141, 35);
            this.lab_MonsterName.TabIndex = 0;
            this.lab_MonsterName.Text = "Eric025";
            // 
            // gb_PlayerSkill
            // 
            this.gb_PlayerSkill.Controls.Add(this.but_Skill_4);
            this.gb_PlayerSkill.Controls.Add(this.but_Skill_2);
            this.gb_PlayerSkill.Controls.Add(this.but_TelentSkill);
            this.gb_PlayerSkill.Controls.Add(this.but_Skill_3);
            this.gb_PlayerSkill.Controls.Add(this.but_Skill_1);
            this.gb_PlayerSkill.Controls.Add(this.but_ATK);
            this.gb_PlayerSkill.Location = new System.Drawing.Point(12, 165);
            this.gb_PlayerSkill.Name = "gb_PlayerSkill";
            this.gb_PlayerSkill.Size = new System.Drawing.Size(254, 199);
            this.gb_PlayerSkill.TabIndex = 2;
            this.gb_PlayerSkill.TabStop = false;
            this.gb_PlayerSkill.Text = "玩家技能";
            // 
            // but_Skill_4
            // 
            this.but_Skill_4.Location = new System.Drawing.Point(139, 144);
            this.but_Skill_4.Name = "but_Skill_4";
            this.but_Skill_4.Size = new System.Drawing.Size(89, 39);
            this.but_Skill_4.TabIndex = 3;
            this.but_Skill_4.UseVisualStyleBackColor = true;
            // 
            // but_Skill_2
            // 
            this.but_Skill_2.Location = new System.Drawing.Point(139, 90);
            this.but_Skill_2.Name = "but_Skill_2";
            this.but_Skill_2.Size = new System.Drawing.Size(89, 39);
            this.but_Skill_2.TabIndex = 3;
            this.but_Skill_2.UseVisualStyleBackColor = true;
            // 
            // but_TelentSkill
            // 
            this.but_TelentSkill.Location = new System.Drawing.Point(139, 34);
            this.but_TelentSkill.Name = "but_TelentSkill";
            this.but_TelentSkill.Size = new System.Drawing.Size(89, 39);
            this.but_TelentSkill.TabIndex = 3;
            this.but_TelentSkill.Text = "天赋技能";
            this.but_TelentSkill.UseVisualStyleBackColor = true;
            // 
            // but_Skill_3
            // 
            this.but_Skill_3.Location = new System.Drawing.Point(18, 144);
            this.but_Skill_3.Name = "but_Skill_3";
            this.but_Skill_3.Size = new System.Drawing.Size(89, 39);
            this.but_Skill_3.TabIndex = 3;
            this.but_Skill_3.UseVisualStyleBackColor = true;
            // 
            // but_Skill_1
            // 
            this.but_Skill_1.Location = new System.Drawing.Point(18, 90);
            this.but_Skill_1.Name = "but_Skill_1";
            this.but_Skill_1.Size = new System.Drawing.Size(89, 39);
            this.but_Skill_1.TabIndex = 3;
            this.but_Skill_1.UseVisualStyleBackColor = true;
            // 
            // but_ATK
            // 
            this.but_ATK.Location = new System.Drawing.Point(18, 34);
            this.but_ATK.Name = "but_ATK";
            this.but_ATK.Size = new System.Drawing.Size(89, 39);
            this.but_ATK.TabIndex = 3;
            this.but_ATK.Text = "物理攻击";
            this.but_ATK.UseVisualStyleBackColor = true;
            // 
            // gb_Useful
            // 
            this.gb_Useful.Controls.Add(this.but_ReTreat);
            this.gb_Useful.Controls.Add(this.but_Items);
            this.gb_Useful.Location = new System.Drawing.Point(522, 165);
            this.gb_Useful.Name = "gb_Useful";
            this.gb_Useful.Size = new System.Drawing.Size(254, 140);
            this.gb_Useful.TabIndex = 2;
            this.gb_Useful.TabStop = false;
            this.gb_Useful.Text = "功能（未开发）";
            // 
            // but_ReTreat
            // 
            this.but_ReTreat.Location = new System.Drawing.Point(139, 34);
            this.but_ReTreat.Name = "but_ReTreat";
            this.but_ReTreat.Size = new System.Drawing.Size(89, 39);
            this.but_ReTreat.TabIndex = 3;
            this.but_ReTreat.Text = "撤退";
            this.but_ReTreat.UseVisualStyleBackColor = true;
            // 
            // but_Items
            // 
            this.but_Items.Location = new System.Drawing.Point(18, 34);
            this.but_Items.Name = "but_Items";
            this.but_Items.Size = new System.Drawing.Size(89, 39);
            this.but_Items.TabIndex = 3;
            this.but_Items.Text = "物品";
            this.but_Items.UseVisualStyleBackColor = true;
            // 
            // but_Back
            // 
            this.but_Back.Location = new System.Drawing.Point(601, 323);
            this.but_Back.Name = "but_Back";
            this.but_Back.Size = new System.Drawing.Size(89, 39);
            this.but_Back.TabIndex = 3;
            this.but_Back.Text = "返回";
            this.but_Back.UseVisualStyleBackColor = true;
            this.but_Back.Visible = false;
            // 
            // frm_Fighting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 374);
            this.ControlBox = false;
            this.Controls.Add(this.but_Back);
            this.Controls.Add(this.gb_Useful);
            this.Controls.Add(this.gb_PlayerSkill);
            this.Controls.Add(this.txt_thisssage);
            this.Controls.Add(this.gb_MonsterAttribute);
            this.Controls.Add(this.gb_PlayerAttribute);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Fighting";
            this.Text = "与[]的战斗";
            this.gb_PlayerAttribute.ResumeLayout(false);
            this.gb_PlayerAttribute.PerformLayout();
            this.gb_MonsterAttribute.ResumeLayout(false);
            this.gb_MonsterAttribute.PerformLayout();
            this.gb_PlayerSkill.ResumeLayout(false);
            this.gb_Useful.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion;
        private GroupBox gb_PlayerAttribute;
        private ProgressBar pro_PlayerHitPoints;
        private Label lab_PlayerHitPoints;
        private Label lab_PlayerName;
        private TextBox txt_thisssage;
        private GroupBox gb_MonsterAttribute;
        private ProgressBar pro_MonsterHitPoints;
        private Label lab_MonsterHitPoints;
        private Label lab_MonsterName;
        private GroupBox gb_PlayerSkill;
        private Button but_Skill_4;
        private Button but_Skill_2;
        private Button but_TelentSkill;
        private Button but_Skill_3;
        private Button but_Skill_1;
        private Button but_ATK;
        private GroupBox gb_Useful;
        private Button but_ReTreat;
        private Button but_Items;
        private Button but_Back;
    }
}