namespace Log_Processor
{
    partial class TrialForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSentence = new System.Windows.Forms.ComboBox();
            this.tbUser = new System.Windows.Forms.ComboBox();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.numSection = new System.Windows.Forms.NumericUpDown();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSection)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbSentence);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbUser);
            this.groupBox2.Controls.Add(this.numTimer);
            this.groupBox2.Controls.Add(this.numSection);
            this.groupBox2.Controls.Add(this.tbID);
            this.groupBox2.Controls.Add(this.cbCategory);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 248);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trial\'s information";
            // 
            // cbSentence
            // 
            this.cbSentence.FormattingEnabled = true;
            this.cbSentence.Location = new System.Drawing.Point(126, 118);
            this.cbSentence.Name = "cbSentence";
            this.cbSentence.Size = new System.Drawing.Size(342, 33);
            this.cbSentence.TabIndex = 15;
            // 
            // tbUser
            // 
            this.tbUser.FormattingEnabled = true;
            this.tbUser.Location = new System.Drawing.Point(126, 79);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(342, 33);
            this.tbUser.TabIndex = 14;
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(126, 196);
            this.numTimer.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(100, 32);
            this.numTimer.TabIndex = 9;
            this.numTimer.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numSection
            // 
            this.numSection.Location = new System.Drawing.Point(384, 41);
            this.numSection.Name = "numSection";
            this.numSection.Size = new System.Drawing.Size(84, 32);
            this.numSection.TabIndex = 8;
            this.numSection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(126, 41);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 32);
            this.tbID.TabIndex = 7;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "..........",
            "Mouse",
            "Acelerômetro (Mão)",
            "Acelerômetro (Ombro)"});
            this.cbCategory.Location = new System.Drawing.Point(126, 157);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(342, 33);
            this.cbCategory.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Timer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Category:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Section:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sentence:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(429, 266);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(64, 64);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(359, 266);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(64, 64);
            this.btCheck.TabIndex = 6;
            this.btCheck.Text = "Start Process";
            this.btCheck.UseVisualStyleBackColor = true;
            // 
            // TrialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 343);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.groupBox2);
            this.Name = "TrialForm";
            this.Text = "Trial Settings";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSentence;
        private System.Windows.Forms.ComboBox tbUser;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.NumericUpDown numSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCheck;

    }
}