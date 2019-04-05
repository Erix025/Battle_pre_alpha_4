using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4
{
    partial class frm_Login
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
            this.lst_PlayerName = new System.Windows.Forms.ListBox();
            this.lab_PlayerAttribute = new System.Windows.Forms.Label();
            this.but_Start = new System.Windows.Forms.Button();
            this.but_DelPlayer = new System.Windows.Forms.Button();
            this.but_AddPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_PlayerName
            // 
            this.lst_PlayerName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lst_PlayerName.FormattingEnabled = true;
            this.lst_PlayerName.ItemHeight = 16;
            this.lst_PlayerName.Location = new System.Drawing.Point(12, 12);
            this.lst_PlayerName.Name = "lst_PlayerName";
            this.lst_PlayerName.Size = new System.Drawing.Size(132, 276);
            this.lst_PlayerName.TabIndex = 0;
            this.lst_PlayerName.SelectedIndexChanged += new System.EventHandler(this.lst_PlayerName_SelectedIndexChanged);
            // 
            // lab_PlayerAttribute
            // 
            this.lab_PlayerAttribute.AutoSize = true;
            this.lab_PlayerAttribute.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_PlayerAttribute.Location = new System.Drawing.Point(150, 12);
            this.lab_PlayerAttribute.Name = "lab_PlayerAttribute";
            this.lab_PlayerAttribute.Size = new System.Drawing.Size(0, 16);
            this.lab_PlayerAttribute.TabIndex = 1;
            // 
            // but_Start
            // 
            this.but_Start.Enabled = false;
            this.but_Start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_Start.Location = new System.Drawing.Point(12, 294);
            this.but_Start.Name = "but_Start";
            this.but_Start.Size = new System.Drawing.Size(85, 35);
            this.but_Start.TabIndex = 2;
            this.but_Start.Text = "进入游戏";
            this.but_Start.UseVisualStyleBackColor = true;
            this.but_Start.Click += new System.EventHandler(this.but_Start_Click);
            // 
            // but_DelPlayer
            // 
            this.but_DelPlayer.Enabled = false;
            this.but_DelPlayer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_DelPlayer.Location = new System.Drawing.Point(212, 294);
            this.but_DelPlayer.Name = "but_DelPlayer";
            this.but_DelPlayer.Size = new System.Drawing.Size(85, 35);
            this.but_DelPlayer.TabIndex = 2;
            this.but_DelPlayer.Text = "删除角色";
            this.but_DelPlayer.UseVisualStyleBackColor = true;
            this.but_DelPlayer.Click += new System.EventHandler(this.but_DelPlayer_Click);
            // 
            // but_AddPlayer
            // 
            this.but_AddPlayer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_AddPlayer.Location = new System.Drawing.Point(103, 294);
            this.but_AddPlayer.Name = "but_AddPlayer";
            this.but_AddPlayer.Size = new System.Drawing.Size(103, 35);
            this.but_AddPlayer.TabIndex = 2;
            this.but_AddPlayer.Text = "创建新角色";
            this.but_AddPlayer.UseVisualStyleBackColor = true;
            this.but_AddPlayer.Click += new System.EventHandler(this.but_AddPlayer_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 341);
            this.Controls.Add(this.but_DelPlayer);
            this.Controls.Add(this.but_AddPlayer);
            this.Controls.Add(this.but_Start);
            this.Controls.Add(this.lab_PlayerAttribute);
            this.Controls.Add(this.lst_PlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.Text = "选择角色";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

       }

        #endregion;
        private ListBox lst_PlayerName;
        private Label lab_PlayerAttribute;
        private Button but_Start;
        private Button but_DelPlayer;
        private Button but_AddPlayer;
    }
}