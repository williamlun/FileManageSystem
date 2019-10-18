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
    public partial class tesing : Form
    {
        List<StringValue> Ldir = new List<StringValue>();
        List<StringValue> Rdir = new List<StringValue>();
        List<StringValue> LHave = new List<StringValue>();
        List<StringValue> RHave = new List<StringValue>();


        public tesing()
        {
            InitializeComponent();
        }

        private void Bt_submit_Click(object sender, EventArgs e)
        {

        }
    }
}
