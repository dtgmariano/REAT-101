namespace Log_Processor.Modules
{
    partial class UserForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPatientSide = new System.Windows.Forms.ComboBox();
            this.numPatientYB = new System.Windows.Forms.NumericUpDown();
            this.tbPacientName = new System.Windows.Forms.TextBox();
            this.tbPatientId = new System.Windows.Forms.TextBox();
            this.cbPatientGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPatientYB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPacientName);
            this.groupBox1.Controls.Add(this.numPatientYB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbPatientSide);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPatientId);
            this.groupBox1.Controls.Add(this.cbPatientGender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User information";
            // 
            // cbPatientSide
            // 
            this.cbPatientSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbPatientSide.FormattingEnabled = true;
            this.cbPatientSide.Items.AddRange(new object[] {
            "..........",
            "Direita",
            "Esquerda"});
            this.cbPatientSide.Location = new System.Drawing.Point(123, 109);
            this.cbPatientSide.Name = "cbPatientSide";
            this.cbPatientSide.Size = new System.Drawing.Size(121, 33);
            this.cbPatientSide.TabIndex = 10;
            // 
            // numPatientYB
            // 
            this.numPatientYB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numPatientYB.Location = new System.Drawing.Point(372, 72);
            this.numPatientYB.Maximum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.numPatientYB.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numPatientYB.Name = "numPatientYB";
            this.numPatientYB.Size = new System.Drawing.Size(90, 32);
            this.numPatientYB.TabIndex = 9;
            this.numPatientYB.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // tbPacientName
            // 
            this.tbPacientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbPacientName.Location = new System.Drawing.Point(123, 34);
            this.tbPacientName.Name = "tbPacientName";
            this.tbPacientName.Size = new System.Drawing.Size(339, 32);
            this.tbPacientName.TabIndex = 8;
            // 
            // tbPatientId
            // 
            this.tbPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbPatientId.Location = new System.Drawing.Point(123, 72);
            this.tbPatientId.Name = "tbPatientId";
            this.tbPatientId.Size = new System.Drawing.Size(100, 32);
            this.tbPatientId.TabIndex = 7;
            // 
            // cbPatientGender
            // 
            this.cbPatientGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbPatientGender.FormattingEnabled = true;
            this.cbPatientGender.Items.AddRange(new object[] {
            "..........",
            "Feminino",
            "Masculino"});
            this.cbPatientGender.Location = new System.Drawing.Point(341, 112);
            this.cbPatientGender.Name = "cbPatientGender";
            this.cbPatientGender.Size = new System.Drawing.Size(121, 33);
            this.cbPatientGender.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(236, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birth (Year):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(250, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Laterality:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(77, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(340, 181);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(64, 64);
            this.btCheck.TabIndex = 4;
            this.btCheck.Text = "Ok";
            this.btCheck.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(410, 181);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(64, 64);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 248);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserForm";
            this.Text = "User information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPatientYB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPatientSide;
        private System.Windows.Forms.NumericUpDown numPatientYB;
        private System.Windows.Forms.TextBox tbPacientName;
        private System.Windows.Forms.TextBox tbPatientId;
        private System.Windows.Forms.ComboBox cbPatientGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btCancel;

    }
}