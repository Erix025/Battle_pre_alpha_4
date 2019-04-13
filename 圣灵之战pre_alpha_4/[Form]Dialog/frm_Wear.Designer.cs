using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_Wear
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
            this.lab_PrimaryEquipment = new System.Windows.Forms.Label();
            this.lab_NowEquipment = new System.Windows.Forms.Label();
            this.but_Confirm = new System.Windows.Forms.Button();
            this.but_Canel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_PrimaryEquipment
            // 
            this.lab_PrimaryEquipment.AutoSize = true;
            this.lab_PrimaryEquipment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_PrimaryEquipment.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_PrimaryEquipment.Location = new System.Drawing.Point(12, 9);
            this.lab_PrimaryEquipment.Name = "lab_PrimaryEquipment";
            this.lab_PrimaryEquipment.Size = new System.Drawing.Size(2, 18);
            this.lab_PrimaryEquipment.TabIndex = 0;
            // 
            // lab_NowEquipment
            // 
            this.lab_NowEquipment.AutoSize = true;
            this.lab_NowEquipment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_NowEquipment.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_NowEquipment.Location = new System.Drawing.Point(130, 9);
            this.lab_NowEquipment.Name = "lab_NowEquipment";
            this.lab_NowEquipment.Size = new System.Drawing.Size(2, 18);
            this.lab_NowEquipment.TabIndex = 1;
            // 
            // but_Confirm
            // 
            this.but_Confirm.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Confirm.Location = new System.Drawing.Point(12, 202);
            this.but_Confirm.Name = "but_Confirm";
            this.but_Confirm.Size = new System.Drawing.Size(75, 35);
            this.but_Confirm.TabIndex = 21;
            this.but_Confirm.Text = "确认";
            this.but_Confirm.UseVisualStyleBackColor = true;
            this.but_Confirm.Click += new System.EventHandler(this.But_Confirm_Click);
            // 
            // but_Canel
            // 
            this.but_Canel.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Canel.Location = new System.Drawing.Point(173, 202);
            this.but_Canel.Name = "but_Canel";
            this.but_Canel.Size = new System.Drawing.Size(75, 35);
            this.but_Canel.TabIndex = 20;
            this.but_Canel.Text = "取消";
            this.but_Canel.UseVisualStyleBackColor = true;
            this.but_Canel.Click += new System.EventHandler(this.But_Canel_Click);
            // 
            // frm_Wear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 249);
            this.ControlBox = false;
            this.Controls.Add(this.but_Confirm);
            this.Controls.Add(this.but_Canel);
            this.Controls.Add(this.lab_NowEquipment);
            this.Controls.Add(this.lab_PrimaryEquipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Wear";
            this.Text = "装备[]";
            this.Load += new System.EventHandler(this.Frm_Wear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lab_PrimaryEquipment;
        private Label lab_NowEquipment;
        private Button but_Confirm;
        private Button but_Canel;
    }
}