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
    public partial class WelcomingForm : Form
    {
        private int days;
        public WelcomingForm(int daysleft)
        {
            InitializeComponent();
            days = daysleft;
            if (!XmlLibrary.XmlHandling.registeredUser("Settings.xml"))
            {
                if (daysleft > 1)
                {
                    L_expDays.Text = daysleft.ToString() + " days";
                }
                else if (daysleft > 0)
                {
                    L_expDays.Text = daysleft.ToString() + " day";
                }
            }
            else
            {
                B_register.Enabled = false;
                L_buildWillExpI.Text = "Registered by:";
                L_expDays.Text = XmlLibrary.XmlHandling.registeredUserName("Settings.xml");
            }
                
            //make the exponent to show correclty
            Font f = RichTextBox.DefaultFont;
            Font smallFont = new Font(f.FontFamily, 16, FontStyle.Bold);
            rTB_title.Text = "D3";
            rTB_title.Find("3");
            rTB_title.SelectionCharOffset = 10;
            rTB_title.SelectionFont = smallFont;

            //this here makes the annoying disabled color back to black!
            rTB_title.SelectAll();
            rTB_title.SelectionColor = Color.Black;
        }

        private void B_ok_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void B_register_Click(object sender, EventArgs e)
        {
            RegisterForm regform = new RegisterForm(days, this);
            regform.Show();
        }

        public void registerStatusChanged()
        {
            B_register.Enabled = false;
            L_buildWillExpI.Text = "Registered by:";
            L_expDays.Text = XmlLibrary.XmlHandling.registeredUserName("Settings.xml");
        }
    }
}
