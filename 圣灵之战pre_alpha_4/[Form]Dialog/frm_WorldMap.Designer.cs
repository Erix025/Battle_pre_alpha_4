using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_WorldMap
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
            this.lst_PlaceName = new System.Windows.Forms.ListBox();
            this.lab_PlaceInfo = new System.Windows.Forms.Label();
            this.but_Go = new System.Windows.Forms.Button();
            this.but_Canel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //;
            //lst_PlaceName;
            //;
            this.lst_PlaceName.FormattingEnabled = true;
            this.lst_PlaceName.ItemHeight = 16;
            this.lst_PlaceName.Location = new System.Drawing.Point(0, 0);
            this.lst_PlaceName.Margin = new System.Windows.Forms.Padding(4);
            this.lst_PlaceName.Name = "lst_PlaceName";
            this.lst_PlaceName.Size = new System.Drawing.Size(218, 516);
            this.lst_PlaceName.TabIndex = 0;
            //;
            //lab_PlaceInfo;
            //;
            this.lab_PlaceInfo.Location = new System.Drawing.Point(225, 9);
            this.lab_PlaceInfo.Name = "lab_PlaceInfo";
            this.lab_PlaceInfo.Size = new System.Drawing.Size(349, 427);
            this.lab_PlaceInfo.TabIndex = 1;
            //;
            //but_Go;
            //;
            this.but_Go.Enabled = false;
            this.but_Go.Location = new System.Drawing.Point(277, 462);
            this.but_Go.Name = "but_Go";
            this.but_Go.Size = new System.Drawing.Size(75, 38);
            this.but_Go.TabIndex = 3;
            this.but_Go.Text = "前往";
            this.but_Go.UseVisualStyleBackColor = true;
            //;
            //but_Canel;
            //;
            this.but_Canel.Location = new System.Drawing.Point(478, 462);
            this.but_Canel.Name = "but_Canel";
            this.but_Canel.Size = new System.Drawing.Size(75, 38);
            this.but_Canel.TabIndex = 3;
            this.but_Canel.Text = "取消";
            this.but_Canel.UseVisualStyleBackColor = true;
            //;
            //frm_WorldMap;
            //;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8.0f, 16.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 521);
            this.ControlBox = false;
            this.Controls.Add(this.but_Canel);
            this.Controls.Add(this.but_Go);
            this.Controls.Add(this.lab_PlaceInfo);
            this.Controls.Add(this.lst_PlaceName);
            this.Font = new System.Drawing.Font("宋体", 12.0f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_WorldMap";
            this.Text = "世界地图";
            this.ResumeLayout(false);
        }

        #endregion 
        private ListBox lst_PlaceName;
        private Label lab_PlaceInfo;
        private Button but_Go;
        private Button but_Canel;
    }
}