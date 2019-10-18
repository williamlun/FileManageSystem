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
    public partial class Addreg : Form
    {
        Inisetting libset;
        List<Register> registerlist = new List<Register>();

        int Registercount;

        public Addreg()
        {
            InitializeComponent();
        }
        public Addreg(Inisetting setting)
        {
            InitializeComponent();
            libset = setting;
        }

        private void readsetting()      //read the ini file
        {

            int Registercount = Int32.Parse(libset.Read("listcount", "Registered"));
            for (int i = 0; i < Registercount; i++)
            {
                string name = libset.Read("listname" + (i + 1), "Registered");
                string path = libset.Read("listpath" + (i + 1), "Registered");
                registerlist.Add(new Register(name, path));
            }

        }
        
        private void cmd_sure_Click(object sender, EventArgs e)
        {
            Registercount = Int32.Parse(libset.Read("listcount", "Registered"));
            Registercount++;
            try
            {
                libset.Write("listcount", Registercount.ToString(), "Registered");

                File.Create("\\setting\\" + Registercount.ToString() + ".ini");
                libset.Write("listname" + Registercount.ToString(), textBox1.Text, "Registered");
                libset.Write("listpath" + Registercount.ToString(), "\\setting\\" +  Registercount.ToString() + ".ini", "Registered");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
