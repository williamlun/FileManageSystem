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
    public partial class Addsetting : Form
    {
        int settingcount;
        Inisetting mainIni;
        List<setting> listofsetting = new List<setting>();

        public Addsetting()
        {
            InitializeComponent();
            mainIni = new Inisetting("settingsaver.ini");
        }

        private void cmd_sure_Click(object sender, EventArgs e)
        {
            settingcount = Int32.Parse(mainIni.Read("settingCount", "Setting"));
            settingcount++;
            try
            {
                mainIni.Write("settingCount", settingcount.ToString(), "Setting");

                File.Create(settingcount.ToString() + ".ini");
                mainIni.Write("name", textBox1.Text, "SettingFile" + settingcount.ToString());
                mainIni.Write("path", settingcount.ToString() + ".ini", "SettingFile" + settingcount.ToString());
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
        private void readsetting()
        {
            settingcount = Int32.Parse(mainIni.Read("settingCount", "Setting"));
            for (int i = 0; i < settingcount; i++)
            {
                string name = mainIni.Read("name", "SettingFile" + (i + 1));
                string path = mainIni.Read("path", "SettingFile" + (i + 1));
                listofsetting.Add(new setting(name, path));
            }

        }
    }
}
