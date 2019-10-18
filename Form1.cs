using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManageSystem
{
    public partial class Form1 : Form
    {
        private BindingSource BindingSource1 = new BindingSource();
        int settingcount;
        Inisetting mainIni;
        List<setting>  listofsetting = new List<setting>();


        public Form1()
        {
            InitializeComponent();
            mainIni = new Inisetting("settingsaver.ini");
            readsetting();
            BindingSource1.DataSource = listofsetting;

            selectSettingComboBox.DataSource = BindingSource1.DataSource;
            selectSettingComboBox.DisplayMember = "name";
            selectSettingComboBox.ValueMember = "name";

        }


        private void readsetting()
        {
            settingcount = Int32.Parse(mainIni.Read("settingCount", "Setting"));
            for (int i = 0 ; i < settingcount ; i++)
            {
                string name = mainIni.Read("name", "SettingFile" + (i + 1));
                string path = mainIni.Read("path", "SettingFile" + (i + 1));
                listofsetting.Add(new setting(name, path));
            }

        }

        private void FuckUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_Libmanage_Click(object sender, EventArgs e)
        {
            Lib win = new Lib((setting)selectSettingComboBox.SelectedItem);
            win.Show();
        }

        private void cmd_register_Click(object sender, EventArgs e)
        {
            RegToDes win = new RegToDes((setting)selectSettingComboBox.SelectedItem);
            win.Show();
        }

        private void cmd_freecompare_Click(object sender, EventArgs e)
        {
            freeCom win = new freeCom();
            win.Show();
        }

        private void cmd_Addsetting_Click(object sender, EventArgs e)
        {
            Addsetting win = new Addsetting();
            win.Show();
        }

        private void cmd_test_Click(object sender, EventArgs e)
        {

        }
    }

    public class setting
    {
        public string name { get; set; }
        public string path { get; set; }

        public setting(string na,string pa)
        {
            name = na;
            path = pa;
        }
        
    }
}
