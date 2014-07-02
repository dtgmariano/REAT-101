namespace Virtual_Keypad
{
    partial class Form1
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
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.btGenerateKeypad = new System.Windows.Forms.Button();
            this.tbSentence = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(12, 12);
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(54, 20);
            this.nudRows.TabIndex = 0;
            this.nudRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(72, 12);
            this.nudColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(54, 20);
            this.nudColumns.TabIndex = 2;
            this.nudColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btGenerateKeypad
            // 
            this.btGenerateKeypad.Location = new System.Drawing.Point(118, 35);
            this.btGenerateKeypad.Name = "btGenerateKeypad";
            this.btGenerateKeypad.Size = new System.Drawing.Size(117, 23);
            this.btGenerateKeypad.TabIndex = 3;
            this.btGenerateKeypad.Text = "Generate Keypad";
            this.btGenerateKeypad.UseVisualStyleBackColor = true;
            this.btGenerateKeypad.Click += new System.EventHandler(this.btGenerateKeypad_Click);
            // 
            // tbSentence
            // 
            this.tbSentence.Location = new System.Drawing.Point(12, 38);
            this.tbSentence.Name = "tbSentence";
            this.tbSentence.Size = new System.Drawing.Size(100, 20);
            this.tbSentence.TabIndex = 4;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 64);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(317, 227);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 435);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.tbSentence);
            this.Controls.Add(this.btGenerateKeypad);
            this.Controls.Add(this.nudColumns);
            this.Controls.Add(this.nudRows);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Button btGenerateKeypad;
        private System.Windows.Forms.TextBox tbSentence;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

