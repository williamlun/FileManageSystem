using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManageSystem
{
    public partial class RegToDes : Form
    {
        Inisetting reg;
        List<Register> registerlist = new List<Register>();
        List<Fileprop> registerfilelist = new List<Fileprop>();
        List<string> filter = new List<string>();
        List<Fileprop> tarfilelist = new List<Fileprop>();

        List<Fileprop> regHave = new List<Fileprop>();
        List<Fileprop> tarHave = new List<Fileprop>();
        string tarFileDest;

        public RegToDes()
        {
            InitializeComponent();
        }

        public RegToDes(setting set)
        {
            InitializeComponent();
            reg = new Inisetting(set.path);
            readsetting();
            

            BindingSource BindingSourceRegister = new BindingSource();
            BindingSourceRegister.DataSource = registerlist;
            registerComboBox.DataSource = BindingSourceRegister.DataSource;
            registerComboBox.DisplayMember = "name";
            registerComboBox.ValueMember = "name";
            registerComboBox.SelectedIndex = -1;
            registerComboBox.Text = "PLZ Select a register";

            registerfilelist.Clear();
        }

        private void readsetting()
        {
            int Registercount = Int32.Parse(reg.Read("listcount", "Registered"));
            for (int i = 0; i < Registercount; i++)
            {
                string name = reg.Read("listname" + (i + 1), "Registered");
                string path = reg.Read("listpath" + (i + 1), "Registered");
                registerlist.Add(new Register(name, path));
            }
            int filtercount = Int32.Parse(reg.Read("filtercount", "Filter"));
            for (int i = 0; i < filtercount; i++)
            {
                string name = reg.Read("filter" + (i + 1), "Filter");
                filter.Add(name);
            }
        }

        private void registerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registerComboBox.SelectedIndex == -1) return;           
            Register temp = (Register)registerComboBox.SelectedItem;
            string registerpath = temp.path;
            string line;
            registerfilelist.Clear();
            StreamReader filereader = new StreamReader(Directory.GetCurrentDirectory() + "\\\\" + registerpath);
            while ((line = filereader.ReadLine()) != null)
            {
                LinetoObject(line);
            }
            filereader.Close();

            var registerfile = new BindingSource();
            registerfile.DataSource = registerfilelist;
            dataGrid_registerAll.DataSource = registerfile;
            
        }
        private void LinetoObject(string line)  //read text file to make filelist and datagridview
        {
            string a = line;
            string[] array = a.Split('\t');
            registerfilelist.Add(new Fileprop(array[1], array[3], array[5], array[7], array[9], array[11], array[13], array[15]));

        }

        private void cmd_browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                FilePathtextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void cmd_tarfileToDataGrid_Click(object sender, EventArgs e)
        {
            tarfilelist.Clear();
            if (Directory.Exists(FilePathtextBox.Text))
            {
                tarFileDest = FilePathtextBox.Text;
                foreach (string fil in filter)
                {
                    string[] dirs = Directory.GetFiles(FilePathtextBox.Text, fil, SearchOption.AllDirectories);
                    foreach (string dir in dirs)
                    {
                        tarfilelist.Add(new Fileprop(dir));
                    }
                }

                var source = new BindingSource();
                source.DataSource = tarfilelist;
                dataGrid_tarAll.DataSource = source;
            }
        }

        private void cmd_compare_Click(object sender, EventArgs e)
        {
            regHave.Clear();
            regHave.AddRange(Fileprop.comparelist2(registerfilelist, tarfilelist));

            var reghavedata = new BindingSource();
            reghavedata.DataSource = regHave;
            dataGrid_regHave.DataSource = regHave;

            tarHave.Clear();
            tarHave.AddRange(Fileprop.comparelist2(tarfilelist, registerfilelist));

            var tarhavedata = new BindingSource();
            tarhavedata.DataSource = tarHave;
            dataGrid_tarHave.DataSource = tarHave;
        }

        private void cmd_reg_delSelcetion_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGrid_regHave.SelectedRows;
            List<DataGridViewRow> myrows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in rows)
            {
                myrows.Add(row);
            }
            foreach (DataGridViewRow row in myrows)
            {
                string pa = row.Cells[7].Value.ToString();
                bool exist = new bool();
                Fileprop temp = Fileprop.searchByPath(regHave, pa, out exist);
                if (exist) regHave.Remove(temp);
            }
            var regHavefile = new BindingSource();
            regHavefile.DataSource = regHave;
            dataGrid_regHave.DataSource = regHavefile;
        }

        private void cmd_tar_delSelcetion_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGrid_tarHave.SelectedRows;
            List<DataGridViewRow> myrows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in rows)
            {
                myrows.Add(row);
            }
            foreach (DataGridViewRow row in myrows)
            {
                string pa = row.Cells[7].Value.ToString();
                bool exist = new bool();
                Fileprop temp = Fileprop.searchByPath(tarHave, pa, out exist);
                if (exist) tarHave.Remove(temp);
            }
            var tarHavefile = new BindingSource();
            tarHavefile.DataSource = regHave;
            dataGrid_tarHave.DataSource = tarHavefile;
        }

        private void cmd_reg_copyselection_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGrid_regHave.SelectedRows;
            List<DataGridViewRow> myrows = new List<DataGridViewRow>();
            List<string> faillist = new List<string>();
            int successCount = 0;
            int failCount = 0;
            foreach (DataGridViewRow row in rows)
            {
                myrows.Add(row);
            }
            foreach (DataGridViewRow row in myrows)
            {
                string na = row.Cells[0].Value.ToString();
                string pa = row.Cells[7].Value.ToString();

                try
                {
                    File.Copy(pa, tarFileDest + "//" + na);
                    successCount++;
                }
                catch
                {
                    faillist.Add(pa);
                    failCount++;
                }
            }
            MessageBox.Show("Success : " + successCount);
            if (failCount > 0)
                MessageBox.Show("Fail : " + failCount + "\n" + faillist.ToString());


        }

        private void cmd_reg_copyAll_Click(object sender, EventArgs e)
        {
            
            List<string> faillist = new List<string>();
            int successCount = 0;
            int failCount = 0;
            foreach (DataGridViewRow row in dataGrid_regHave.Rows)
            {
                string na = row.Cells[0].Value.ToString();
                string pa = row.Cells[7].Value.ToString();

                try
                {
                    File.Copy(pa, tarFileDest + "//" + na);
                    successCount++;
                }
                catch
                {
                    faillist.Add(pa);
                    failCount++;
                }
            }
            MessageBox.Show("Success : " + successCount);
            if (failCount > 0)
                MessageBox.Show("Fail : " + failCount + "\n" + faillist.ToString());

        }
    }
}
