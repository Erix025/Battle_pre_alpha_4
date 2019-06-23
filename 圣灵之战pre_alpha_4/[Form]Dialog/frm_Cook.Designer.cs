using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_Cook
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
            this.but_Confirm = new System.Windows.Forms.Button();
            this.but_Canel = new System.Windows.Forms.Button();
            this.tmr_Cooked = new System.Windows.Forms.Timer(this.components);
            this.icnc_Main = new Index_Contorl_Library.IC_NumberChangeBox();
            this.lab_Preview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_Confirm
            // 
            this.but_Confirm.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Confirm.Location = new System.Drawing.Point(31, 144);
            this.but_Confirm.Name = "but_Confirm";
            this.but_Confirm.Size = new System.Drawing.Size(75, 35);
            this.but_Confirm.TabIndex = 25;
            this.but_Confirm.Text = "确认";
            this.but_Confirm.UseVisualStyleBackColor = true;
            this.but_Confirm.Click += new System.EventHandler(this.But_Confirm_Click);
            // 
            // but_Canel
            // 
            this.but_Canel.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Canel.Location = new System.Drawing.Point(197, 144);
            this.but_Canel.Name = "but_Canel";
            this.but_Canel.Size = new System.Drawing.Size(75, 35);
            this.but_Canel.TabIndex = 24;
            this.but_Canel.Text = "取消";
            this.but_Canel.UseVisualStyleBackColor = true;
            this.but_Canel.Click += new System.EventHandler(this.But_Canel_Click);
            // 
            // tmr_Cooked
            // 
            this.tmr_Cooked.Interval = 1000;
            // 
            // icnc_Main
            // 
            this.icnc_Main.Font = new System.Drawing.Font("宋体", 12F);
            this.icnc_Main.Location = new System.Drawing.Point(13, 13);
            this.icnc_Main.Margin = new System.Windows.Forms.Padding(4);
            this.icnc_Main.Name = "icnc_Main";
            this.icnc_Main.Number = 1;
            this.icnc_Main.Size = new System.Drawing.Size(294, 73);
            this.icnc_Main.TabIndex = 26;
            this.icnc_Main.NumberChanged += new Index_Contorl_Library.IC_NumberChangeBox.NumberChangedHandler(this.Icnc_Main_NumberChanged);
            // 
            // lab_Preview
            // 
            this.lab_Preview.AutoSize = true;
            this.lab_Preview.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_Preview.Location = new System.Drawing.Point(28, 90);
            this.lab_Preview.Name = "lab_Preview";
            this.lab_Preview.Size = new System.Drawing.Size(0, 16);
            this.lab_Preview.TabIndex = 27;
            // 
            // frm_Cook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 201);
            this.ControlBox = false;
            this.Controls.Add(this.lab_Preview);
            this.Controls.Add(this.icnc_Main);
            this.Controls.Add(this.but_Confirm);
            this.Controls.Add(this.but_Canel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Cook";
            this.Text = "烹饪[]";
            this.Load += new System.EventHandler(this.Frm_Cook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button but_Confirm;
        private Button but_Canel;
        private Timer tmr_Cooked;
        private Index_Contorl_Library.IC_NumberChangeBox icnc_Main;
        private Label lab_Preview;
    }

}