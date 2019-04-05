using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_Mission
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
            this.rad_MainMission = new System.Windows.Forms.RadioButton();
            this.rad_SideMission = new System.Windows.Forms.RadioButton();
            this.rad_DailyMission = new System.Windows.Forms.RadioButton();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.gb_1.SuspendLayout();
            this.SuspendLayout();
            //;
            //rad_MainMission;
            //;
            this.rad_MainMission.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_MainMission.AutoSize = true;
            this.rad_MainMission.Location = new System.Drawing.Point(6, 15);
            this.rad_MainMission.Name = "rad_MainMission";
            this.rad_MainMission.Size = new System.Drawing.Size(82, 26);
            this.rad_MainMission.TabIndex = 0;
            this.rad_MainMission.TabStop = true;
            this.rad_MainMission.Text = "主线任务";
            this.rad_MainMission.UseVisualStyleBackColor = true;
            //;
            //rad_SideMission;
            //;
            this.rad_SideMission.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_SideMission.AutoSize = true;
            this.rad_SideMission.Location = new System.Drawing.Point(94, 15);
            this.rad_SideMission.Name = "rad_SideMission";
            this.rad_SideMission.Size = new System.Drawing.Size(82, 26);
            this.rad_SideMission.TabIndex = 0;
            this.rad_SideMission.TabStop = true;
            this.rad_SideMission.Text = "支线任务";
            this.rad_SideMission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rad_SideMission.UseVisualStyleBackColor = true;
            //;
            //rad_DailyMission;
            //;
            this.rad_DailyMission.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_DailyMission.AutoSize = true;
            this.rad_DailyMission.Location = new System.Drawing.Point(180, 15);
            this.rad_DailyMission.Name = "rad_DailyMission";
            this.rad_DailyMission.Size = new System.Drawing.Size(82, 26);
            this.rad_DailyMission.TabIndex = 0;
            this.rad_DailyMission.TabStop = true;
            this.rad_DailyMission.Text = "每日任务";
            this.rad_DailyMission.UseVisualStyleBackColor = true;
            //;
            //gb_1;
            //;
            this.gb_1.Controls.Add(this.rad_DailyMission);
            this.gb_1.Controls.Add(this.rad_SideMission);
            this.gb_1.Controls.Add(this.rad_MainMission);
            this.gb_1.Location = new System.Drawing.Point(12, 12);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(268, 47);
            this.gb_1.TabIndex = 1;
            this.gb_1.TabStop = false;
            //;
            //CheckedListBox1;
            //;
            this.CheckedListBox1.FormattingEnabled = true;
            this.CheckedListBox1.Items.AddRange(new object[] { "1", "11", "111" });
            this.CheckedListBox1.Location = new System.Drawing.Point(13, 66);
            this.CheckedListBox1.Name = "CheckedListBox1";
            this.CheckedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CheckedListBox1.Size = new System.Drawing.Size(260, 256);
            this.CheckedListBox1.TabIndex = 2;
            //;
            //frm_Mission;
            //;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8.0f, 16.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 347);
            this.ControlBox = false;
            this.Controls.Add(this.CheckedListBox1);
            this.Controls.Add(this.gb_1);
            this.Font = new System.Drawing.Font("宋体", 12.0f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Mission";
            this.Text = "任务";
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            this.ResumeLayout(false);
            
        }

        #endregion
        private RadioButton rad_MainMission;
        private RadioButton rad_SideMission;
        private RadioButton rad_DailyMission;
        private GroupBox gb_1;
        private CheckedListBox CheckedListBox1;
    }
}