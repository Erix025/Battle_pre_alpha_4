using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_Loading
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
            this.pro_Main = new System.Windows.Forms.ProgressBar();
            this.lab_Loading_In = new System.Windows.Forms.Label();
            this.tmr_LoadPlayerData = new System.Windows.Forms.Timer(this.components);
            this.tmr_AddPlayer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            //;
            //pro_Main;
            //;
            this.pro_Main.Location = new System.Drawing.Point(12, 43);
            this.pro_Main.Name = "pro_Main";
            this.pro_Main.Size = new System.Drawing.Size(260, 23);
            this.pro_Main.TabIndex = 0;
            //;
            //lab_Loading_In;
            //;
            this.lab_Loading_In.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom);
            this.lab_Loading_In.AutoSize = true;
            this.lab_Loading_In.Font = new System.Drawing.Font("宋体", 15.0f);
            this.lab_Loading_In.Location = new System.Drawing.Point(12, 9);
            this.lab_Loading_In.Name = "lab_Loading_In";
            this.lab_Loading_In.Size = new System.Drawing.Size(89, 20);
            this.lab_Loading_In.TabIndex = 1;
            this.lab_Loading_In.Text = "正在加载";
            //;
            //tmr_LoadPlayerData;
            //;
            this.tmr_LoadPlayerData.Interval = 1;
            //;
            //tmr_AddPlayer;
            //;
            this.tmr_AddPlayer.Interval = 1;
            //;
            //frm_Loading;
            //;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 12.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 78);
            this.ControlBox = false;
            this.Controls.Add(this.lab_Loading_In);
            this.Controls.Add(this.pro_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Loading";
            this.Text = "加载中...";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private ProgressBar pro_Main;
        private Label lab_Loading_In;
        private Timer tmr_LoadPlayerData;
        private Timer tmr_AddPlayer;
    }
}