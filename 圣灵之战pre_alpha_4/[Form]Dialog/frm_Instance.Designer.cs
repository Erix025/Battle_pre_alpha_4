using System.Windows.Forms;
namespace 圣灵之战pre_alpha_4._Form_Dialog
{
    partial class frm_Instance
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
            this.lab_InstanceName = new System.Windows.Forms.Label();
            this.lab_InstanceInfo = new System.Windows.Forms.Label();
            this.but_DekaronInstance = new System.Windows.Forms.Button();
            this.but_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //;
            //lab_InstanceName;
            //;
            this.lab_InstanceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab_InstanceName.Font = new System.Drawing.Font("宋体", 24.0f);
            this.lab_InstanceName.Location = new System.Drawing.Point(15, 9);
            this.lab_InstanceName.Name = "lab_InstanceName";
            this.lab_InstanceName.Size = new System.Drawing.Size(352, 33);
            this.lab_InstanceName.TabIndex = 0;
            this.lab_InstanceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //;
            //lab_InstanceInfo;
            //;
            this.lab_InstanceInfo.Location = new System.Drawing.Point(12, 60);
            this.lab_InstanceInfo.Name = "lab_InstanceInfo";
            this.lab_InstanceInfo.Size = new System.Drawing.Size(355, 219);
            this.lab_InstanceInfo.TabIndex = 1;
            //;
            //but_DekaronInstance;
            //;
            this.but_DekaronInstance.Location = new System.Drawing.Point(43, 297);
            this.but_DekaronInstance.Name = "but_DekaronInstance";
            this.but_DekaronInstance.Size = new System.Drawing.Size(80, 38);
            this.but_DekaronInstance.TabIndex = 3;
            this.but_DekaronInstance.Text = "挑战副本";
            this.but_DekaronInstance.UseVisualStyleBackColor = true;
            //;
            //but_Back;
            //;
            this.but_Back.Location = new System.Drawing.Point(248, 297);
            this.but_Back.Name = "but_Back";
            this.but_Back.Size = new System.Drawing.Size(80, 38);
            this.but_Back.TabIndex = 3;
            this.but_Back.Text = "返回";
            this.but_Back.UseVisualStyleBackColor = true;
            //;
            //frm_Instance;
            //;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8.0f, 16.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 347);
            this.ControlBox = false;
            this.Controls.Add(this.lab_InstanceInfo);
            this.Controls.Add(this.but_Back);
            this.Controls.Add(this.but_DekaronInstance);
            this.Controls.Add(this.lab_InstanceName);
            this.Font = new System.Drawing.Font("宋体", 12.0f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Instance";
            this.Text = "[]副本";
            this.ResumeLayout(false);
        }

        #endregion
        private Label lab_InstanceName;
        private Label lab_InstanceInfo;
        private Button but_DekaronInstance;
        private Button but_Back;
    }
}