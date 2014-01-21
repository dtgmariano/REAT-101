namespace Log_Processor.MenuModules.UsersMenu
{
    partial class UsersMenu
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbUsersList = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRem = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.gbUsersList.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 358);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // gbUsersList
            // 
            this.gbUsersList.Controls.Add(this.richTextBox1);
            this.gbUsersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.gbUsersList.Location = new System.Drawing.Point(12, 12);
            this.gbUsersList.Name = "gbUsersList";
            this.gbUsersList.Size = new System.Drawing.Size(256, 395);
            this.gbUsersList.TabIndex = 1;
            this.gbUsersList.TabStop = false;
            this.gbUsersList.Text = "User\'s List";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(18, 413);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 50);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btRem
            // 
            this.btRem.Location = new System.Drawing.Point(80, 413);
            this.btRem.Name = "btRem";
            this.btRem.Size = new System.Drawing.Size(56, 50);
            this.btRem.TabIndex = 3;
            this.btRem.Text = "Remove";
            this.btRem.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(206, 413);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(56, 50);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // UsersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 496);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btRem);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.gbUsersList);
            this.Name = "UsersMenu";
            this.Text = "UsersMenu";
            this.gbUsersList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox gbUsersList;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRem;
        private System.Windows.Forms.Button btBack;

    }
}