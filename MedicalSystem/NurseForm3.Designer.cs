namespace MedicalSystem
{
    partial class NurseForm3
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
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.panelmain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(689, 549);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(108, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 5;
            this.buttonX2.Text = "显示药品表";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // panelmain
            // 
            this.panelmain.Location = new System.Drawing.Point(60, 34);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(737, 485);
            this.panelmain.TabIndex = 6;
            // 
            // NurseForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1097, 607);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.buttonX2);
            this.Name = "NurseForm3";
            this.Text = "查看库存";
            this.Load += new System.EventHandler(this.NurseForm3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.Panel panelmain;
    }
}