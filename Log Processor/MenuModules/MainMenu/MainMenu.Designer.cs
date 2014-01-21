namespace Log_Processor
{
    partial class MainMenu
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btUsersMenu = new System.Windows.Forms.Button();
            this.btTrialMenu = new System.Windows.Forms.Button();
            this.btHelpMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btUsersMenu
            // 
            this.btUsersMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btUsersMenu.Image = global::Log_Processor.Properties.Resources._1390297236_userconfig;
            this.btUsersMenu.Location = new System.Drawing.Point(12, 12);
            this.btUsersMenu.Name = "btUsersMenu";
            this.btUsersMenu.Size = new System.Drawing.Size(64, 64);
            this.btUsersMenu.TabIndex = 1;
            this.btUsersMenu.UseVisualStyleBackColor = false;
            // 
            // btTrialMenu
            // 
            this.btTrialMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btTrialMenu.Image = global::Log_Processor.Properties.Resources._1390297248_tasks;
            this.btTrialMenu.Location = new System.Drawing.Point(82, 12);
            this.btTrialMenu.Name = "btTrialMenu";
            this.btTrialMenu.Size = new System.Drawing.Size(64, 64);
            this.btTrialMenu.TabIndex = 0;
            this.btTrialMenu.UseVisualStyleBackColor = false;
            this.btTrialMenu.Click += new System.EventHandler(this.btNewTrial_Click);
            // 
            // btHelpMenu
            // 
            this.btHelpMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btHelpMenu.Image = global::Log_Processor.Properties.Resources._1390297407_help_browser;
            this.btHelpMenu.Location = new System.Drawing.Point(152, 12);
            this.btHelpMenu.Name = "btHelpMenu";
            this.btHelpMenu.Size = new System.Drawing.Size(64, 64);
            this.btHelpMenu.TabIndex = 2;
            this.btHelpMenu.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 86);
            this.Controls.Add(this.btHelpMenu);
            this.Controls.Add(this.btUsersMenu);
            this.Controls.Add(this.btTrialMenu);
            this.Name = "Form1";
            this.Text = "Log Processor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTrialMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btUsersMenu;
        private System.Windows.Forms.Button btHelpMenu;

    }
}

