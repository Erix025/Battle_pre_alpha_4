using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_Sell
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
            this.but_Add = new System.Windows.Forms.Button();
            this.but_Reduce = new System.Windows.Forms.Button();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.lab_PreView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //;
            //but_Confirm;
            //;
            this.but_Confirm.Font = new System.Drawing.Font("宋体", 12.0f);
            this.but_Confirm.Location = new System.Drawing.Point(29, 115);
            this.but_Confirm.Name = "but_Confirm";
            this.but_Confirm.Size = new System.Drawing.Size(75, 35);
            this.but_Confirm.TabIndex = 19;
            this.but_Confirm.Text = "确认";
            this.but_Confirm.UseVisualStyleBackColor = true;
            //;
            //but_Canel;
            //;
            this.but_Canel.Font = new System.Drawing.Font("宋体", 12.0f);
            this.but_Canel.Location = new System.Drawing.Point(131, 115);
            this.but_Canel.Name = "but_Canel";
            this.but_Canel.Size = new System.Drawing.Size(75, 35);
            this.but_Canel.TabIndex = 18;
            this.but_Canel.Text = "取消";
            this.but_Canel.UseVisualStyleBackColor = true;
            //;
            //but_Add;
            //;
            this.but_Add.Font = new System.Drawing.Font("宋体", 18.0f);
            this.but_Add.Location = new System.Drawing.Point(173, 16);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(51, 37);
            this.but_Add.TabIndex = 17;
            this.but_Add.Text = "→";
            this.but_Add.UseVisualStyleBackColor = true;
            //;
            //but_Reduce;
            //;
            this.but_Reduce.Font = new System.Drawing.Font("宋体", 18.0f);
            this.but_Reduce.Location = new System.Drawing.Point(10, 16);
            this.but_Reduce.Name = "but_Reduce";
            this.but_Reduce.Size = new System.Drawing.Size(51, 37);
            this.but_Reduce.TabIndex = 16;
            this.but_Reduce.Text = "←";
            this.but_Reduce.UseVisualStyleBackColor = true;
            //;
            //txt_Number;
            //;
            this.txt_Number.Font = new System.Drawing.Font("宋体", 24.0f);
            this.txt_Number.Location = new System.Drawing.Point(67, 12);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(100, 44);
            this.txt_Number.TabIndex = 15;
            //;
            //lab_PreView;
            //;
            this.lab_PreView.AutoSize = true;
            this.lab_PreView.Font = new System.Drawing.Font("宋体", 12.0f);
            this.lab_PreView.Location = new System.Drawing.Point(26, 59);
            this.lab_PreView.Name = "lab_PreView";
            this.lab_PreView.Size = new System.Drawing.Size(0, 16);
            this.lab_PreView.TabIndex = 20;
            //;
            //frm_Sell;
            //;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 12.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 166);
            this.ControlBox = false;
            this.Controls.Add(this.lab_PreView);
            this.Controls.Add(this.but_Confirm);
            this.Controls.Add(this.but_Canel);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.but_Reduce);
            this.Controls.Add(this.txt_Number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Sell";
            this.Text = "出售[]";
            this.ResumeLayout(false);
            this.PerformLayout();
            
        }

        #endregion
        private Button but_Confirm;
        private Button but_Canel;
        private Button but_Add;
        private Button but_Reduce;
        private TextBox txt_Number;
        private Label lab_PreView;
    }
}