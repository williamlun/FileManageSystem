using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace FileManageSystem
{
    
    public partial class Lib : Form
    {
        Inisetting libset;
        List<string> sourcepath = new List<string>();
        List<string> checkedsourcepath = new List<string>();
        List<string> filter = new List<string>();
        List<Register> registerlist = new List<Register>();
        List<Fileprop> libfilelist = new List<Fileprop>();
        List<Fileprop> registerfilelist = new List<Fileprop>();
        List<Fileprop> nonvalidfilelist = new List<Fileprop>();
        string libtxtpath;
        

        public Lib()
        {
            InitializeComponent();
        }
        public Lib(setting set)
        {
            InitializeComponent();
            cleearAllList();

            libset = new Inisetting(set.path);
            readsetting();

            var libsource = new BindingSource();
            libsource.DataSource = sourcepath;
            SourceCheckList.DataSource = libsource;
            for (int i = 0; i < SourceCheckList.Items.Count; i++)
            {
                SourceCheckList.SetItemChecked(i, true);
            }

            BindingSource BindingSourceRegister = new BindingSource();
            BindingSourceRegister.DataSource = registerlist;
            registerComboBox.DataSource = BindingSourceRegister.DataSource;
            registerComboBox.DisplayMember = "name";
            registerComboBox.ValueMember = "name";
            registerComboBox.SelectedIndex = -1;
            registerComboBox.Text = "PLZ Select a register";

            readfuckinglibtxt();
            registerfilelist.Clear();
        }

        
        private void readsetting()      //read the ini file
        {
            int sourcecount = Int32.Parse(libset.Read("sourcecount", "SourceFile"));
            for (int i = 0; i < sourcecount; i++)
            {
                string name = libset.Read("sourcePath"+(i+1), "SourceFile");
                sourcepath.Add(name);
            }
            int filtercount = Int32.Parse(libset.Read("filtercount", "Filter"));
            for (int i = 0; i < filtercount; i++)
            {
                string name = libset.Read("filter" + (i + 1), "Filter");
                filter.Add(name);
            }
            int Registercount = Int32.Parse(libset.Read("listcount", "Registered"));
            for (int i = 0; i < Registercount; i++)
            {
                string name = libset.Read("listname" + (i + 1), "Registered");
                string path = libset.Read("listpath" + (i + 1), "Registered");
                registerlist.Add(new Register(name, path));
            }
            libtxtpath = libset.Read("lib", "Lib");

        }

        private void renewLibdata()     //the function real do the search
        {
            libfilelist.Clear();
            foreach (string pa in checkedsourcepath)
            {
                foreach (string fil in filter)
                {
                    string[] dirs = Directory.GetFiles(pa, fil, SearchOption.AllDirectories);
                    foreach (string dir in dirs)
                    {
                        libfilelist.Add(new Fileprop(dir));
                    }

                }
            }
            var source = new BindingSource();
            source.DataSource = libfilelist;
            LibdataGrid.DataSource = source;
            DataGridToText(LibdataGrid, libtxtpath);

        }

        private void SourceCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileNameLabel.Text = SourceCheckList.SelectedValue.ToString();
        }

        private void SourceCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            checkedsourcepath.Clear();
            foreach (var item in SourceCheckList.CheckedItems)
                checkedsourcepath.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
                checkedsourcepath.Add(SourceCheckList.Items[e.Index].ToString());
            else
                checkedsourcepath.Remove(SourceCheckList.Items[e.Index].ToString());
            //renewLibdata();
        }

        private void cmd_brower_Click(object sender, EventArgs e)   //
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                filePathtextbox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void cmd_AddSource_Click(object sender, EventArgs e)    
        {
            if (Directory.Exists(filePathtextbox.Text))
            {
                sourcepath.Add(filePathtextbox.Text);
                int sourcecount = Int32.Parse(libset.Read("sourcecount", "SourceFile"));
                sourcecount++;
                libset.Write("sourcecount", sourcecount.ToString(), "SourceFile");
                libset.Write("sourcePath" + sourcecount, filePathtextbox.Text, "SourceFile");

                var libsource = new BindingSource();
                libsource.DataSource = sourcepath;
                SourceCheckList.DataSource = libsource;
            }
            else
            {
                MessageBox.Show("plz confirm the file is valid");
            }
        }

        private void registerComboBox_SelectedIndexChanged(object sender, EventArgs e)  //choose register
        {
            if (registerComboBox.SelectedIndex == -1) return;
            Register temp = (Register)registerComboBox.SelectedItem;
            string registerpath = temp.path;
            string line;
            registerfilelist.Clear();
            StreamReader filereader = new StreamReader(Directory.GetCurrentDirectory() +"\\\\" +registerpath);
            while ((line = filereader.ReadLine()) != null)
            {
                LinetoObject(line);
            }
            filereader.Close();


            var registerfile = new BindingSource();
            registerfile.DataSource = registerfilelist;
            registerDataGrid.DataSource = registerfile;

        }

        private void DataGridToText(DataGridView data, string path)     //save the datagrid to text file
        {
            StreamWriter filewriter = new StreamWriter(Directory.GetCurrentDirectory() + "\\\\"+path, false);
            for (int i = 0; i < data.Rows.Count - 1; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    if(data.Rows[i].Cells[j].Value != null)
                        filewriter.Write("\t" + data.Rows[i].Cells[j].Value.ToString() + "\t");
                    //filewriter.Write("\t" + data.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    else
                        filewriter.Write("\t" + "--" + "\t");
                    //filewriter.Write("\t" +" "+  "\t" + "|");
                }
                filewriter.WriteLine("");
            }
            filewriter.Close();
            MessageBox.Show("Data Exported");

        }

        private void LinetoObject(string line)  //read text file to make filelist and datagridview
        {
            string a = line;
            string[] array = a.Split('\t');
            registerfilelist.Add(new Fileprop(array[1], array[3], array[5], array[7], array[9], array[11], array[13], array[15]));

        }

        private void cmd_renewlibdata_Click(object sender, EventArgs e) //Re-search the lib 
        {
            renewLibdata();
        }

        private void readfuckinglibtxt()    //Lib record 
        {
            libfilelist.Clear();
            string line;
            StreamReader filereader = new StreamReader(Directory.GetCurrentDirectory() + "\\\\" + libtxtpath);
            while ((line = filereader.ReadLine()) != null)
            {
                string a = line;
                string[] array = a.Split('\t');
                libfilelist.Add(new Fileprop(array[1], array[3], array[5], array[7], array[9], array[11], array[13], array[15]));
            }
            filereader.Close();

            var libfile = new BindingSource();
            libfile.DataSource = libfilelist;
            LibdataGrid.DataSource = libfile;
        }

        private void cmd_libToReg_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = LibdataGrid.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                string path = row.Cells[7].Value.ToString();
                if (File.Exists(path))
                {
                    Fileprop temp = new Fileprop(path);
                    if(!temp.checkExist(registerfilelist,temp))
                        registerfilelist.Add(temp);
                }
            }

            var registerfile = new BindingSource();
            registerfile.DataSource = registerfilelist;
            registerDataGrid.DataSource = registerfile;


        }

        private void cmd_saveReglist_Click(object sender, EventArgs e)  //save the file list to register
        {
            Register temp = (Register)registerComboBox.SelectedItem;
            string registerpath = temp.path;
            DataGridToText(registerDataGrid, registerpath);

        }

        private void cmd_delfromReg_Click(object sender, EventArgs e)   //del record from the registed file list
        {
            DataGridViewSelectedRowCollection rows = registerDataGrid.SelectedRows;
            List<DataGridViewRow> myrows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in rows)
            {
                myrows.Add(row);
            }
            foreach (DataGridViewRow row in myrows)
            {
                string pa = row.Cells[7].Value.ToString();
                bool exist = new bool();
                Fileprop temp = Fileprop.searchByPath(registerfilelist , pa , out exist);
                if(exist) registerfilelist.Remove(temp);
            }
            var registerfile = new BindingSource();
            registerfile.DataSource = registerfilelist;
            registerDataGrid.DataSource = registerfile;        
        }

        private void cmd_checklistVaild_Click(object sender, EventArgs e)
        {
            nonvalidfilelist.Clear();
            foreach (Fileprop file in registerfilelist)
            {
                if (!File.Exists(file.path))
                    nonvalidfilelist.Add(file);
            }
            var nonvalidfile = new BindingSource();
            nonvalidfile.DataSource = nonvalidfilelist;
            notValildlist.DataSource = nonvalidfile;
        }

        private void cleearAllList()
        {
            sourcepath = new List<string>();
            checkedsourcepath = new List<string>();
            filter = new List<string>();
            registerlist = new List<Register>();
            libfilelist = new List<Fileprop>();
            registerfilelist = new List<Fileprop>();
            nonvalidfilelist = new List<Fileprop>();
        }

        private void cmd_Addreg_Click(object sender, EventArgs e)
        {
            Addreg win = new Addreg(libset);
            win.Show();
        }
    }
}
 