using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace D3
{
    public partial class EULA : Form
    {
        public EULA()
        {
            InitializeComponent();
        }

        private void B_accept_Click(object sender, EventArgs e)
        {
            XmlLibrary.XmlHandling.acceptEULA("Settings.xml", rTB_EULA.Text, "0.1");
            Form.ActiveForm.Close();
        }

        private void B_decline_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
