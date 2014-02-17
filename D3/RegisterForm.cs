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
    public partial class RegisterForm : Form
    {
        private int days;
        private WelcomingForm parent;
        public RegisterForm(int daysleft, WelcomingForm Wform)
        {
            InitializeComponent();
            TB_Rkey.UseSystemPasswordChar = true;
            days = daysleft;
            parent = Wform;
        }

        private void B_accept_Click(object sender, EventArgs e)
        {
            if (TB_Rkey.Text == "mitävittua")
            {
                XmlLibrary.XmlHandling.registerUser("Settings.xml", "mitävittua");
                RegisterForm.ActiveForm.Close();
                parent.registerStatusChanged();
            }
            else if (TB_Rkey.Text == "kallata")
            {
                XmlLibrary.XmlHandling.registerUser("Settings.xml", "kallata");
                RegisterForm.ActiveForm.Close();
                parent.registerStatusChanged();
            }
            else
            {
                TB_Rkey.BackColor = Color.Red;
            }
        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            RegisterForm.ActiveForm.Close();
        }
    }
}
