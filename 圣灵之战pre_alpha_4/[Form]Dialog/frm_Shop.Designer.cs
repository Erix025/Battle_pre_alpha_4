using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class Frm_Shop
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
            this.lst_CommodityName = new System.Windows.Forms.ListBox();
            this.lst_CommodityPrize = new System.Windows.Forms.ListBox();
            this.lab_PlayerMoney = new System.Windows.Forms.Label();
            this.lab_PreView = new System.Windows.Forms.Label();
            this.lab_CommodityInfo = new System.Windows.Forms.Label();
            this.but_Canel = new System.Windows.Forms.Button();
            this.but_Buy = new System.Windows.Forms.Button();
            this.icnc_Main = new Index_Contorl_Library.IC_NumberChangeBox();
            this.SuspendLayout();
            // 
            // lst_CommodityName
            // 
            this.lst_CommodityName.Font = new System.Drawing.Font("宋体", 12F);
            this.lst_CommodityName.FormattingEnabled = true;
            this.lst_CommodityName.ItemHeight = 16;
            this.lst_CommodityName.Location = new System.Drawing.Point(12, 22);
            this.lst_CommodityName.Name = "lst_CommodityName";
            this.lst_CommodityName.Size = new System.Drawing.Size(206, 372);
            this.lst_CommodityName.TabIndex = 0;
            this.lst_CommodityName.SelectedIndexChanged += new System.EventHandler(this.Lst_commodityName_SelectedIndexChanged);
            // 
            // lst_CommodityPrize
            // 
            this.lst_CommodityPrize.Font = new System.Drawing.Font("宋体", 12F);
            this.lst_CommodityPrize.FormattingEnabled = true;
            this.lst_CommodityPrize.ItemHeight = 16;
            this.lst_CommodityPrize.Location = new System.Drawing.Point(224, 22);
            this.lst_CommodityPrize.Name = "lst_CommodityPrize";
            this.lst_CommodityPrize.Size = new System.Drawing.Size(63, 372);
            this.lst_CommodityPrize.TabIndex = 1;
            this.lst_CommodityPrize.SelectedIndexChanged += new System.EventHandler(this.Lst_CommodityPrize_SelectedIndexChanged);
            // 
            // lab_PlayerMoney
            // 
            this.lab_PlayerMoney.AutoSize = true;
            this.lab_PlayerMoney.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PlayerMoney.Location = new System.Drawing.Point(298, 177);
            this.lab_PlayerMoney.Name = "lab_PlayerMoney";
            this.lab_PlayerMoney.Size = new System.Drawing.Size(122, 23);
            this.lab_PlayerMoney.TabIndex = 2;
            this.lab_PlayerMoney.Text = "当前拥有金钱：";
            // 
            // lab_PreView
            // 
            this.lab_PreView.AutoSize = true;
            this.lab_PreView.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_PreView.Location = new System.Drawing.Point(300, 290);
            this.lab_PreView.Name = "lab_PreView";
            this.lab_PreView.Size = new System.Drawing.Size(0, 16);
            this.lab_PreView.TabIndex = 6;
            // 
            // lab_CommodityInfo
            // 
            this.lab_CommodityInfo.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_CommodityInfo.Location = new System.Drawing.Point(300, 22);
            this.lab_CommodityInfo.Name = "lab_CommodityInfo";
            this.lab_CommodityInfo.Size = new System.Drawing.Size(259, 155);
            this.lab_CommodityInfo.TabIndex = 7;
            // 
            // but_Canel
            // 
            this.but_Canel.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Canel.Location = new System.Drawing.Point(461, 333);
            this.but_Canel.Name = "but_Canel";
            this.but_Canel.Size = new System.Drawing.Size(75, 35);
            this.but_Canel.TabIndex = 8;
            this.but_Canel.Text = "取消";
            this.but_Canel.UseVisualStyleBackColor = true;
            this.but_Canel.Click += new System.EventHandler(this.But_Canel_Click);
            // 
            // but_Buy
            // 
            this.but_Buy.Enabled = false;
            this.but_Buy.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Buy.Location = new System.Drawing.Point(322, 333);
            this.but_Buy.Name = "but_Buy";
            this.but_Buy.Size = new System.Drawing.Size(75, 35);
            this.but_Buy.TabIndex = 9;
            this.but_Buy.Text = "购买";
            this.but_Buy.UseVisualStyleBackColor = true;
            this.but_Buy.Click += new System.EventHandler(this.But_Buy_Click);
            // 
            // icnc_Main
            // 
            this.icnc_Main.Enabled = false;
            this.icnc_Main.Font = new System.Drawing.Font("宋体", 12F);
            this.icnc_Main.Location = new System.Drawing.Point(294, 204);
            this.icnc_Main.Margin = new System.Windows.Forms.Padding(4);
            this.icnc_Main.Name = "icnc_Main";
            this.icnc_Main.Number = 1;
            this.icnc_Main.Size = new System.Drawing.Size(291, 71);
            this.icnc_Main.TabIndex = 10;
            this.icnc_Main.NumberChanged += new Index_Contorl_Library.IC_NumberChangeBox.NumberChangedHandler(this.Icnc_Main_NumberChanged);
            // 
            // frm_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 403);
            this.ControlBox = false;
            this.Controls.Add(this.icnc_Main);
            this.Controls.Add(this.but_Buy);
            this.Controls.Add(this.but_Canel);
            this.Controls.Add(this.lab_CommodityInfo);
            this.Controls.Add(this.lab_PreView);
            this.Controls.Add(this.lab_PlayerMoney);
            this.Controls.Add(this.lst_CommodityPrize);
            this.Controls.Add(this.lst_CommodityName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Shop";
            this.Text = "商店";
            this.Load += new System.EventHandler(this.Frm_Shop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private ListBox lst_CommodityName;
        private ListBox lst_CommodityPrize;
        private Label lab_PlayerMoney;
        private Label lab_PreView;
        private Label lab_CommodityInfo;
        private Button but_Canel;
        private Button but_Buy;
        private Index_Contorl_Library.IC_NumberChangeBox icnc_Main;
    }
}