using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_CreatePlayer
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.cbx_PlayerPrefession = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.but_Confirm = new System.Windows.Forms.Button();
            this.but_Canel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("宋体", 12F);
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "角色名";
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_PlayerName.Location = new System.Drawing.Point(74, 4);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.Size = new System.Drawing.Size(126, 26);
            this.txt_PlayerName.TabIndex = 1;
            this.txt_PlayerName.TextChanged += new System.EventHandler(this.txt_PlayerName_TextChanged);
            // 
            // cbx_PlayerPrefession
            // 
            this.cbx_PlayerPrefession.Font = new System.Drawing.Font("宋体", 12F);
            this.cbx_PlayerPrefession.FormattingEnabled = true;
            this.cbx_PlayerPrefession.Items.AddRange(new object[] {
            "战士"});
            this.cbx_PlayerPrefession.Location = new System.Drawing.Point(74, 36);
            this.cbx_PlayerPrefession.Name = "cbx_PlayerPrefession";
            this.cbx_PlayerPrefession.Size = new System.Drawing.Size(126, 24);
            this.cbx_PlayerPrefession.TabIndex = 2;
            this.cbx_PlayerPrefession.SelectedIndexChanged += new System.EventHandler(this.cbx_PlayerPrefession_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("宋体", 12F);
            this.Label2.Location = new System.Drawing.Point(20, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "职业";
            // 
            // but_Confirm
            // 
            this.but_Confirm.Enabled = false;
            this.but_Confirm.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Confirm.Location = new System.Drawing.Point(206, 5);
            this.but_Confirm.Name = "but_Confirm";
            this.but_Confirm.Size = new System.Drawing.Size(87, 25);
            this.but_Confirm.TabIndex = 3;
            this.but_Confirm.Text = "创建角色";
            this.but_Confirm.UseVisualStyleBackColor = true;
            this.but_Confirm.Click += new System.EventHandler(this.but_Confirm_Click);
            // 
            // but_Canel
            // 
            this.but_Canel.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Canel.Location = new System.Drawing.Point(206, 36);
            this.but_Canel.Name = "but_Canel";
            this.but_Canel.Size = new System.Drawing.Size(87, 25);
            this.but_Canel.TabIndex = 4;
            this.but_Canel.Text = "取消";
            this.but_Canel.UseVisualStyleBackColor = true;
            this.but_Canel.Click += new System.EventHandler(this.but_Canel_Click);
            // 
            // frm_CreatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 68);
            this.ControlBox = false;
            this.Controls.Add(this.but_Canel);
            this.Controls.Add(this.but_Confirm);
            this.Controls.Add(this.cbx_PlayerPrefession);
            this.Controls.Add(this.txt_PlayerName);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_CreatePlayer";
            this.Text = "创建角色";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion;
        private Label Label1;
    private TextBox txt_PlayerName;
        private ComboBox cbx_PlayerPrefession;
        private Label Label2;
        private Button but_Confirm;
        private Button but_Canel;
    };
}