namespace FileManageSystem
{
    partial class Lib
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
            this.filePathtextbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmd_brower = new System.Windows.Forms.Button();
            this.cmd_AddSource = new System.Windows.Forms.Button();
            this.SourceCheckList = new System.Windows.Forms.CheckedListBox();
            this.LibdataGrid = new System.Windows.Forms.DataGridView();
            this.cmd_libToReg = new System.Windows.Forms.Button();
            this.registerDataGrid = new System.Windows.Forms.DataGridView();
            this.cmd_delfromReg = new System.Windows.Forms.Button();
            this.notValildlist = new System.Windows.Forms.DataGridView();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.registerComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmd_renewlibdata = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmd_checklistVaild = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cmd_saveReglist = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cmd_Addreg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LibdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notValildlist)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePathtextbox
            // 
            this.filePathtextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filePathtextbox.Location = new System.Drawing.Point(3, 24);
            this.filePathtextbox.Name = "filePathtextbox";
            this.filePathtextbox.Size = new System.Drawing.Size(118, 22);
            this.filePathtextbox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmd_brower
            // 
            this.cmd_brower.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmd_brower.Location = new System.Drawing.Point(3, 3);
            this.cmd_brower.Name = "cmd_brower";
            this.cmd_brower.Size = new System.Drawing.Size(112, 23);
            this.cmd_brower.TabIndex = 1;
            this.cmd_brower.Text = "browser";
            this.cmd_brower.UseVisualStyleBackColor = true;
            this.cmd_brower.Click += new System.EventHandler(this.cmd_brower_Click);
            // 
            // cmd_AddSource
            // 
            this.cmd_AddSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmd_AddSource.Location = new System.Drawing.Point(3, 54);
            this.cmd_AddSource.Name = "cmd_AddSource";
            this.cmd_AddSource.Size = new System.Drawing.Size(112, 23);
            this.cmd_AddSource.TabIndex = 2;
            this.cmd_AddSource.Text = "Add";
            this.cmd_AddSource.UseVisualStyleBackColor = true;
            this.cmd_AddSource.Click += new System.EventHandler(this.cmd_AddSource_Click);
            // 
            // SourceCheckList
            // 
            this.SourceCheckList.BackColor = System.Drawing.SystemColors.Control;
            this.SourceCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SourceCheckList.Dock = System.Windows.Forms.DockStyle.Top;
            this.SourceCheckList.FormattingEnabled = true;
            this.SourceCheckList.Location = new System.Drawing.Point(3, 105);
            this.SourceCheckList.Name = "SourceCheckList";
            this.SourceCheckList.Size = new System.Drawing.Size(112, 255);
            this.SourceCheckList.TabIndex = 3;
            this.SourceCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SourceCheckList_ItemCheck);
            this.SourceCheckList.SelectedIndexChanged += new System.EventHandler(this.SourceCheckList_SelectedIndexChanged);
            // 
            // LibdataGrid
            // 
            this.LibdataGrid.AllowUserToAddRows = false;
            this.LibdataGrid.AllowUserToDeleteRows = false;
            this.LibdataGrid.AllowUserToResizeColumns = false;
            this.LibdataGrid.AllowUserToResizeRows = false;
            this.LibdataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.LibdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibdataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibdataGrid.Location = new System.Drawing.Point(127, 52);
            this.LibdataGrid.Name = "LibdataGrid";
            this.LibdataGrid.ReadOnly = true;
            this.LibdataGrid.RowHeadersVisible = false;
            this.LibdataGrid.RowTemplate.Height = 24;
            this.LibdataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LibdataGrid.Size = new System.Drawing.Size(368, 515);
            this.LibdataGrid.TabIndex = 5;
            // 
            // cmd_libToReg
            // 
            this.cmd_libToReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmd_libToReg.Location = new System.Drawing.Point(3, 3);
            this.cmd_libToReg.Name = "cmd_libToReg";
            this.cmd_libToReg.Size = new System.Drawing.Size(112, 37);
            this.cmd_libToReg.TabIndex = 6;
            this.cmd_libToReg.Text = "registration";
            this.cmd_libToReg.UseVisualStyleBackColor = true;
            this.cmd_libToReg.Click += new System.EventHandler(this.cmd_libToReg_Click);
            // 
            // registerDataGrid
            // 
            this.registerDataGrid.AllowUserToAddRows = false;
            this.registerDataGrid.AllowUserToDeleteRows = false;
            this.registerDataGrid.AllowUserToResizeColumns = false;
            this.registerDataGrid.AllowUserToResizeRows = false;
            this.registerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.registerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerDataGrid.Location = new System.Drawing.Point(812, 52);
            this.registerDataGrid.Name = "registerDataGrid";
            this.registerDataGrid.ReadOnly = true;
            this.registerDataGrid.RowHeadersVisible = false;
            this.registerDataGrid.RowTemplate.Height = 24;
            this.registerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registerDataGrid.Size = new System.Drawing.Size(368, 515);
            this.registerDataGrid.TabIndex = 7;
            // 
            // cmd_delfromReg
            // 
            this.cmd_delfromReg.Location = new System.Drawing.Point(60, 3);
            this.cmd_delfromReg.Name = "cmd_delfromReg";
            this.cmd_delfromReg.Size = new System.Drawing.Size(112, 37);
            this.cmd_delfromReg.TabIndex = 8;
            this.cmd_delfromReg.Text = "del";
            this.cmd_delfromReg.UseVisualStyleBackColor = true;
            this.cmd_delfromReg.Click += new System.EventHandler(this.cmd_delfromReg_Click);
            // 
            // notValildlist
            // 
            this.notValildlist.AllowUserToAddRows = false;
            this.notValildlist.AllowUserToDeleteRows = false;
            this.notValildlist.AllowUserToResizeColumns = false;
            this.notValildlist.AllowUserToResizeRows = false;
            this.notValildlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notValildlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notValildlist.Location = new System.Drawing.Point(3, 208);
            this.notValildlist.Name = "notValildlist";
            this.notValildlist.ReadOnly = true;
            this.notValildlist.RowHeadersVisible = false;
            this.notValildlist.RowTemplate.Height = 24;
            this.notValildlist.Size = new System.Drawing.Size(175, 304);
            this.notValildlist.TabIndex = 9;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fileNameLabel.Location = new System.Drawing.Point(142, 10);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 16);
            this.fileNameLabel.TabIndex = 10;
            // 
            // registerComboBox
            // 
            this.registerComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registerComboBox.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.registerComboBox.FormattingEnabled = true;
            this.registerComboBox.Location = new System.Drawing.Point(812, 22);
            this.registerComboBox.Name = "registerComboBox";
            this.registerComboBox.Size = new System.Drawing.Size(368, 24);
            this.registerComboBox.TabIndex = 11;
            this.registerComboBox.SelectedIndexChanged += new System.EventHandler(this.registerComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.filePathtextbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LibdataGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.registerDataGrid, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.registerComboBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmd_saveReglist, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1247, 621);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cmd_brower, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmd_AddSource, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SourceCheckList, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmd_renewlibdata, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(118, 515);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cmd_renewlibdata
            // 
            this.cmd_renewlibdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmd_renewlibdata.Location = new System.Drawing.Point(3, 465);
            this.cmd_renewlibdata.Name = "cmd_renewlibdata";
            this.cmd_renewlibdata.Size = new System.Drawing.Size(112, 23);
            this.cmd_renewlibdata.TabIndex = 4;
            this.cmd_renewlibdata.Text = "renew lib";
            this.cmd_renewlibdata.UseVisualStyleBackColor = true;
            this.cmd_renewlibdata.Click += new System.EventHandler(this.cmd_renewlibdata_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.notValildlist, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmd_checklistVaild, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(625, 52);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(181, 515);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel5.Controls.Add(this.cmd_delfromReg, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(175, 45);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // cmd_checklistVaild
            // 
            this.cmd_checklistVaild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmd_checklistVaild.Location = new System.Drawing.Point(3, 157);
            this.cmd_checklistVaild.Name = "cmd_checklistVaild";
            this.cmd_checklistVaild.Size = new System.Drawing.Size(175, 45);
            this.cmd_checklistVaild.TabIndex = 11;
            this.cmd_checklistVaild.Text = "check registed list";
            this.cmd_checklistVaild.UseVisualStyleBackColor = true;
            this.cmd_checklistVaild.Click += new System.EventHandler(this.cmd_checklistVaild_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cmd_libToReg, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(501, 52);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(118, 515);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // cmd_saveReglist
            // 
            this.cmd_saveReglist.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmd_saveReglist.Location = new System.Drawing.Point(812, 573);
            this.cmd_saveReglist.Name = "cmd_saveReglist";
            this.cmd_saveReglist.Size = new System.Drawing.Size(368, 23);
            this.cmd_saveReglist.TabIndex = 14;
            this.cmd_saveReglist.Text = "save";
            this.cmd_saveReglist.UseVisualStyleBackColor = true;
            this.cmd_saveReglist.Click += new System.EventHandler(this.cmd_saveReglist_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.cmd_Addreg, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(625, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(181, 43);
            this.tableLayoutPanel6.TabIndex = 15;
            // 
            // cmd_Addreg
            // 
            this.cmd_Addreg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmd_Addreg.Enabled = false;
            this.cmd_Addreg.Location = new System.Drawing.Point(93, 3);
            this.cmd_Addreg.Name = "cmd_Addreg";
            this.cmd_Addreg.Size = new System.Drawing.Size(85, 37);
            this.cmd_Addreg.TabIndex = 0;
            this.cmd_Addreg.Text = "Add_register";
            this.cmd_Addreg.UseVisualStyleBackColor = true;
            this.cmd_Addreg.Click += new System.EventHandler(this.cmd_Addreg_Click);
            // 
            // Lib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.fileNameLabel);
            this.Name = "Lib";
            this.Text = "Manage Lib and Register";
            ((System.ComponentModel.ISupportInitialize)(this.LibdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notValildlist)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathtextbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmd_brower;
        private System.Windows.Forms.Button cmd_AddSource;
        private System.Windows.Forms.CheckedListBox SourceCheckList;
        private System.Windows.Forms.DataGridView LibdataGrid;
        private System.Windows.Forms.Button cmd_libToReg;
        private System.Windows.Forms.DataGridView registerDataGrid;
        private System.Windows.Forms.Button cmd_delfromReg;
        private System.Windows.Forms.DataGridView notValildlist;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.ComboBox registerComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button cmd_renewlibdata;
        private System.Windows.Forms.Button cmd_saveReglist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button cmd_checklistVaild;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button cmd_Addreg;
    }
}