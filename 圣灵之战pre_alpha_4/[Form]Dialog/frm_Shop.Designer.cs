using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_Shop
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
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.but_Reduce = new System.Windows.Forms.Button();
            this.but_Add = new System.Windows.Forms.Button();
            this.lab_PreView = new System.Windows.Forms.Label();
            this.lab_CommodityInfo = new System.Windows.Forms.Label();
            this.but_Canel = new System.Windows.Forms.Button();
            this.but_Buy = new System.Windows.Forms.Button();
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
            this.lst_CommodityName.SelectedIndexChanged += new System.EventHandler(this.lst_commodityName_SelectedIndexChanged);
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
            this.lst_CommodityPrize.SelectedIndexChanged += new System.EventHandler(this.lst_CommodityPrize_SelectedIndexChanged);
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
            // txt_Number
            // 
            this.txt_Number.Enabled = false;
            this.txt_Number.Font = new System.Drawing.Font("宋体", 24F);
            this.txt_Number.Location = new System.Drawing.Point(374, 206);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(100, 44);
            this.txt_Number.TabIndex = 3;
            this.txt_Number.TextChanged += new System.EventHandler(this.txt_Number_TextChanged);
            // 
            // but_Reduce
            // 
            this.but_Reduce.Enabled = false;
            this.but_Reduce.Font = new System.Drawing.Font("宋体", 18F);
            this.but_Reduce.Location = new System.Drawing.Point(317, 210);
            this.but_Reduce.Name = "but_Reduce";
            this.but_Reduce.Size = new System.Drawing.Size(51, 37);
            this.but_Reduce.TabIndex = 4;
            this.but_Reduce.Text = "←";
            this.but_Reduce.UseVisualStyleBackColor = true;
            this.but_Reduce.Click += new System.EventHandler(this.but_Reduce_Click);
            // 
            // but_Add
            // 
            this.but_Add.Enabled = false;
            this.but_Add.Font = new System.Drawing.Font("宋体", 18F);
            this.but_Add.Location = new System.Drawing.Point(480, 210);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(51, 37);
            this.but_Add.TabIndex = 5;
            this.but_Add.Text = "→";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // lab_PreView
            // 
            this.lab_PreView.AutoSize = true;
            this.lab_PreView.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_PreView.Location = new System.Drawing.Point(300, 260);
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
            this.but_Canel.Location = new System.Drawing.Point(456, 307);
            this.but_Canel.Name = "but_Canel";
            this.but_Canel.Size = new System.Drawing.Size(75, 35);
            this.but_Canel.TabIndex = 8;
            this.but_Canel.Text = "取消";
            this.but_Canel.UseVisualStyleBackColor = true;
            this.but_Canel.Click += new System.EventHandler(this.but_Canel_Click);
            // 
            // but_Buy
            // 
            this.but_Buy.Enabled = false;
            this.but_Buy.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Buy.Location = new System.Drawing.Point(317, 307);
            this.but_Buy.Name = "but_Buy";
            this.but_Buy.Size = new System.Drawing.Size(75, 35);
            this.but_Buy.TabIndex = 9;
            this.but_Buy.Text = "购买";
            this.but_Buy.UseVisualStyleBackColor = true;
            this.but_Buy.Click += new System.EventHandler(this.but_Buy_Click);
            // 
            // frm_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 403);
            this.ControlBox = false;
            this.Controls.Add(this.but_Buy);
            this.Controls.Add(this.but_Canel);
            this.Controls.Add(this.lab_CommodityInfo);
            this.Controls.Add(this.lab_PreView);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.but_Reduce);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.lab_PlayerMoney);
            this.Controls.Add(this.lst_CommodityPrize);
            this.Controls.Add(this.lst_CommodityName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Shop";
            this.Text = "商店";
            this.Load += new System.EventHandler(this.frm_Shop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lst_CommodityName;
        private ListBox lst_CommodityPrize;
        private Label lab_PlayerMoney;
        private TextBox txt_Number;
        private Button but_Reduce;
        private Button but_Add;
        private Label lab_PreView;
        private Label lab_CommodityInfo;
        private Button but_Canel;
        private Button but_Buy;
    }
}