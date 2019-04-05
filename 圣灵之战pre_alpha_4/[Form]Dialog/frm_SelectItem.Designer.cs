using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_SelectItem
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
            this.lst_Item = new System.Windows.Forms.ListBox();
            this.but_Confirm = new System.Windows.Forms.Button();
            this.lst_ItemCount = new System.Windows.Forms.ListBox();
            this.lab_ItemInfo = new System.Windows.Forms.Label();
            this.but_Canel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //;
            //lst_Item;
            //;
            this.lst_Item.FormattingEnabled = true;
            this.lst_Item.ItemHeight = 16;
            this.lst_Item.Location = new System.Drawing.Point(12, 12);
            this.lst_Item.Name = "lst_Item";
            this.lst_Item.Size = new System.Drawing.Size(177, 324);
            this.lst_Item.TabIndex = 0;
            //;
            //but_Confirm;
            //;
            this.but_Confirm.Enabled = false;
            this.but_Confirm.Location = new System.Drawing.Point(232, 302);
            this.but_Confirm.Name = "but_Confirm";
            this.but_Confirm.Size = new System.Drawing.Size(75, 34);
            this.but_Confirm.TabIndex = 1;
            this.but_Confirm.Text = "确认";
            this.but_Confirm.UseVisualStyleBackColor = true;
            //;
            //lst_ItemCount;
            //;
            this.lst_ItemCount.FormattingEnabled = true;
            this.lst_ItemCount.ItemHeight = 16;
            this.lst_ItemCount.Location = new System.Drawing.Point(188, 12);
            this.lst_ItemCount.Name = "lst_ItemCount";
            this.lst_ItemCount.Size = new System.Drawing.Size(38, 324);
            this.lst_ItemCount.TabIndex = 2;
            //;
            //lab_ItemInfo;
            //;
            this.lab_ItemInfo.Location = new System.Drawing.Point(232, 12);
            this.lab_ItemInfo.Name = "lab_ItemInfo";
            this.lab_ItemInfo.Size = new System.Drawing.Size(228, 149);
            this.lab_ItemInfo.TabIndex = 3;
            //;
            //but_Canel;
            //;
            this.but_Canel.Location = new System.Drawing.Point(385, 302);
            this.but_Canel.Name = "but_Canel";
            this.but_Canel.Size = new System.Drawing.Size(75, 34);
            this.but_Canel.TabIndex = 1;
            this.but_Canel.Text = "取消";
            this.but_Canel.UseVisualStyleBackColor = true;
            //;
            //frm_SelectItems;
            //;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8.0f, 16.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 350);
            this.ControlBox = false;
            this.Controls.Add(this.lab_ItemInfo);
            this.Controls.Add(this.lst_ItemCount);
            this.Controls.Add(this.but_Canel);
            this.Controls.Add(this.but_Confirm);
            this.Controls.Add(this.lst_Item);
            this.Font = new System.Drawing.Font("宋体", 12.0f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_SelectItems";
            this.Text = "选择物品";
            this.ResumeLayout(false);
            
        }

        #endregion
        private ListBox lst_Item;
        private Button but_Confirm;
        private ListBox lst_ItemCount;
        private Label lab_ItemInfo;
        private Button but_Canel;
    }
}