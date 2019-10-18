namespace FileManageSystem
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
            this.FuckUp = new System.Windows.Forms.Button();
            this.selectSettingComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_Libmanage = new System.Windows.Forms.Button();
            this.cmd_register = new System.Windows.Forms.Button();
            this.cmd_freecompare = new System.Windows.Forms.Button();
            this.cmd_Addsetting = new System.Windows.Forms.Button();
            this.cmd_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FuckUp
            // 
            this.FuckUp.Location = new System.Drawing.Point(127, 374);
            this.FuckUp.Name = "FuckUp";
            this.FuckUp.Size = new System.Drawing.Size(101, 37);
            this.FuckUp.TabIndex = 0;
            this.FuckUp.Text = "Quit";
            this.FuckUp.UseVisualStyleBackColor = true;
            this.FuckUp.Click += new System.EventHandler(this.FuckUp_Click);
            // 
            // selectSettingComboBox
            // 
            this.selectSettingComboBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectSettingComboBox.FormattingEnabled = true;
            this.selectSettingComboBox.Location = new System.Drawing.Point(12, 28);
            this.selectSettingComboBox.Name = "selectSettingComboBox";
            this.selectSettingComboBox.Size = new System.Drawing.Size(216, 28);
            this.selectSettingComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Setting File :";
            // 
            // cmd_Libmanage
            // 
            this.cmd_Libmanage.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmd_Libmanage.Location = new System.Drawing.Point(12, 72);
            this.cmd_Libmanage.Name = "cmd_Libmanage";
            this.cmd_Libmanage.Size = new System.Drawing.Size(216, 41);
            this.cmd_Libmanage.TabIndex = 3;
            this.cmd_Libmanage.Text = "Lib Manage";
            this.cmd_Libmanage.UseVisualStyleBackColor = true;
            this.cmd_Libmanage.Click += new System.EventHandler(this.cmd_Libmanage_Click);
            // 
            // cmd_register
            // 
            this.cmd_register.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmd_register.Location = new System.Drawing.Point(12, 119);
            this.cmd_register.Name = "cmd_register";
            this.cmd_register.Size = new System.Drawing.Size(216, 41);
            this.cmd_register.TabIndex = 4;
            this.cmd_register.Text = "register to target";
            this.cmd_register.UseVisualStyleBackColor = true;
            this.cmd_register.Click += new System.EventHandler(this.cmd_register_Click);
            // 
            // cmd_freecompare
            // 
            this.cmd_freecompare.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmd_freecompare.Location = new System.Drawing.Point(12, 166);
            this.cmd_freecompare.Name = "cmd_freecompare";
            this.cmd_freecompare.Size = new System.Drawing.Size(216, 41);
            this.cmd_freecompare.TabIndex = 5;
            this.cmd_freecompare.Text = "[free]file compare";
            this.cmd_freecompare.UseVisualStyleBackColor = true;
            this.cmd_freecompare.Click += new System.EventHandler(this.cmd_freecompare_Click);
            // 
            // cmd_Addsetting
            // 
            this.cmd_Addsetting.Location = new System.Drawing.Point(176, 7);
            this.cmd_Addsetting.Name = "cmd_Addsetting";
            this.cmd_Addsetting.Size = new System.Drawing.Size(52, 23);
            this.cmd_Addsetting.TabIndex = 6;
            this.cmd_Addsetting.Text = "Add";
            this.cmd_Addsetting.UseVisualStyleBackColor = true;
            this.cmd_Addsetting.Click += new System.EventHandler(this.cmd_Addsetting_Click);
            // 
            // cmd_test
            // 
            this.cmd_test.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.cmd_test.Location = new System.Drawing.Point(12, 213);
            this.cmd_test.Name = "cmd_test";
            this.cmd_test.Size = new System.Drawing.Size(216, 42);
            this.cmd_test.TabIndex = 7;
            this.cmd_test.Text = "testing";
            this.cmd_test.UseVisualStyleBackColor = true;
            this.cmd_test.Click += new System.EventHandler(this.cmd_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 423);
            this.Controls.Add(this.cmd_test);
            this.Controls.Add(this.cmd_Addsetting);
            this.Controls.Add(this.cmd_freecompare);
            this.Controls.Add(this.cmd_register);
            this.Controls.Add(this.cmd_Libmanage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectSettingComboBox);
            this.Controls.Add(this.FuckUp);
            this.Name = "Form1";
            this.Text = "File Manage System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FuckUp;
        private System.Windows.Forms.ComboBox selectSettingComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_Libmanage;
        private System.Windows.Forms.Button cmd_register;
        private System.Windows.Forms.Button cmd_freecompare;
        private System.Windows.Forms.Button cmd_Addsetting;
        private System.Windows.Forms.Button cmd_test;
    }
}

