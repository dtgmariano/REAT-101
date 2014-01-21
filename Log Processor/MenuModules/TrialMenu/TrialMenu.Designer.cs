namespace Log_Processor
{
    partial class TrialMenu
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.processTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsTSMI,
            this.processTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsTSMI
            // 
            this.settingsTSMI.Name = "settingsTSMI";
            this.settingsTSMI.Size = new System.Drawing.Size(76, 20);
            this.settingsTSMI.Text = "Configurar";
            this.settingsTSMI.Click += new System.EventHandler(this.settingsTSMI_Click);
            // 
            // processTSMI
            // 
            this.processTSMI.Enabled = false;
            this.processTSMI.Name = "processTSMI";
            this.processTSMI.Size = new System.Drawing.Size(69, 20);
            this.processTSMI.Text = "Processar";
            this.processTSMI.Click += new System.EventHandler(this.processTSMI_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(12, 27);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(486, 409);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // TrialMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 448);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrialMenu";
            this.Text = "TrialMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processTSMI;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.ToolStripMenuItem settingsTSMI;
    }
}