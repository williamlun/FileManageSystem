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
    public partial class freeCom : Form
    {
        List<StringValue> maindir = new List<StringValue>();
        List<StringValue> subdir = new List<StringValue>();
        List<StringValue> mainHave = new List<StringValue>();
        List<StringValue> subHave = new List<StringValue>();

        string mainPath;
        string subPath;


        public freeCom()
        {
            InitializeComponent();
        }

        private void cmd_main_browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                main_FilePathtextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void cmd_main_fileToDataGrid_Click(object sender, EventArgs e)
        {
            maindir.Clear();
            if (Directory.Exists(main_FilePathtextBox.Text))
            {
                mainPath = main_FilePathtextBox.Text;
                string[] dirs = Directory.GetDirectories(mainPath);
                foreach (string str in dirs)
                {
                    if (Directory.Exists(str)) maindir.Add(new StringValue(str));
                }
            }
            var mainfile = new BindingSource();
            mainfile.DataSource = maindir;
            dataGrid_registerAll.DataSource = mainfile;
        }

        private void cmd_sub_fileToDataGrid_Click(object sender, EventArgs e)
        {
            subdir.Clear();
            if (Directory.Exists(sub_FilePathtextBox.Text))
            {
                subPath = sub_FilePathtextBox.Text;
                string[] dirs = Directory.GetDirectories(subPath);
                foreach (string str in dirs)
                {
                    if (Directory.Exists(str)) subdir.Add(new StringValue(str));
                }
            }
            var subfile = new BindingSource();
            subfile.DataSource = subdir;
            dataGrid_subAll.DataSource = subfile;
        }

        private void cmd_sub_browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog2 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog2.ShowDialog();
            if (result == DialogResult.OK)
                sub_FilePathtextBox.Text = folderBrowserDialog2.SelectedPath;
        }

        private void cmd_compare_Click(object sender, EventArgs e)
        {
            subHave.Clear();
            mainHave.Clear();
            /*
            foreach (StringValue main in maindir)
            {
                foreach (StringValue sub in subdir)
                {
                    DirectoryInfo maindir = new DirectoryInfo(main.Value);
                    DirectoryInfo subdir = new DirectoryInfo(sub.Value);
                    if (maindir.Name == subdir.Name)
                        continue;
                }
                mainHave.Add(main);
            }
            */
            mainHave.AddRange(StringValue.comparelist2(maindir, subdir));

            var mainfile = new BindingSource();
            mainfile.DataSource = mainHave;
            dataGrid_regHave.DataSource = mainfile;

            /*
            foreach (StringValue sub in subdir)
            {
                foreach (StringValue main in maindir)
                {
                    DirectoryInfo maindir = new DirectoryInfo(main.Value);
                    DirectoryInfo subdir = new DirectoryInfo(sub.Value);
                    if (subdir.Name == maindir.Name)
                        continue;
                }
                subHave.Add(sub);
            }
            */
            subHave.AddRange(StringValue.comparelist2(subdir, maindir));
            var subfile = new BindingSource();
            subfile.DataSource = subHave;
            dataGrid_subHave.DataSource = subfile;
        }

        private void cmd_main_delSelcetion_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGrid_regHave.SelectedRows;
            List<DataGridViewRow> myrows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in rows)
            {
                myrows.Add(row);
            }
            foreach (DataGridViewRow row in myrows)
            {
                string pa = row.Cells[0].Value.ToString();
                bool Exist = new bool();
                StringValue temp = StringValue.search(mainHave, pa,out Exist);
                if(Exist)mainHave.Remove(temp);
            }
            var mainHavefile = new BindingSource();
            mainHavefile.DataSource = mainHave;
            dataGrid_regHave.DataSource = mainHavefile;
        }

        private void cmd_sub_delSelcetion_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGrid_subHave.SelectedRows;
            List<DataGridViewRow> myrows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in rows)
            {
                myrows.Add(row);
            }
            foreach (DataGridViewRow row in myrows)
            {
                string pa = row.Cells[0].Value.ToString();
                bool Exist = new bool();
                StringValue temp = StringValue.search(subHave, pa, out Exist);
                if (Exist) subHave.Remove(temp);
            }
            var subHavefile = new BindingSource();
            subHavefile.DataSource = subHave;
            dataGrid_subHave.DataSource = subHavefile;
        }

        private void cmd_main_copyselection_Click(object sender, EventArgs e)
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
                try
                {
                    DirectoryInfo dir = new DirectoryInfo(na);
                    DirectoryCopy(na, subPath+"\\"+dir.Name, true);
                    successCount++;
                }
                catch
                {
                    faillist.Add(na);
                    failCount++;
                }
            }
            MessageBox.Show("Success : " + successCount);
            if (failCount > 0)
                MessageBox.Show("Fail : " + failCount + "\n" + faillist.ToString());

        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void cmd_sub_copyselection_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGrid_subHave.SelectedRows;
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
                try
                {
                    DirectoryInfo dir = new DirectoryInfo(na);
                    DirectoryCopy(na, subPath + "\\" + dir.Name, true);
                    successCount++;
                }
                catch
                {
                    faillist.Add(na);
                    failCount++;
                }
            }
            MessageBox.Show("Success : " + successCount);
            if (failCount > 0)
                MessageBox.Show("Fail : " + failCount + "\n" + faillist.ToString());
        }
    }
}
