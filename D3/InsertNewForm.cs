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
    public partial class InsertNewForm : Form
    {
        public InsertNewForm()
        {
            InitializeComponent();
        }

        private void B_insert_Click(object sender, EventArgs e)
        {
            bool invalid = false;
            decimal result;
            if (TB_name.Text == "")
            {
                invalid = true;
                TB_name.BackColor = Color.Red;
            }
            else
            {
                TB_name.BackColor = Color.White;
            }
            if (TB_manufacturer.Text == "")
            {
                invalid = true;
                TB_manufacturer.BackColor = Color.Red;
            }
            else
            {
                TB_manufacturer.BackColor = Color.White;
            }
            if (TB_kcal100g.Text == "" || !decimal.TryParse(TB_kcal100g.Text, out result))
            {
                invalid = true;
                TB_kcal100g.BackColor = Color.Red;
            }
            else
            {
                TB_kcal100g.BackColor = Color.White;
            }
            if (TB_carbohydrates.Text == "" || !decimal.TryParse(TB_carbohydrates.Text, out result))
            {
                invalid = true;
                TB_carbohydrates.BackColor = Color.Red;
            }
            else
            {
                TB_carbohydrates.BackColor = Color.White;
            }
            if (TB_proteins.Text == "" || !decimal.TryParse(TB_proteins.Text, out result))
            {
                invalid = true;
                TB_proteins.BackColor = Color.Red;
            }
            else
            {
                TB_proteins.BackColor = Color.White;
            }
            if (TB_fats.Text == "" || !decimal.TryParse(TB_fats.Text, out result))
            {
                invalid = true;
                TB_fats.BackColor = Color.Red;
            }
            else
            {
                TB_fats.BackColor = Color.White;
            }
            if (TB_portion.Text == "" || !decimal.TryParse(TB_portion.Text, out result))
            {
                invalid = true;
                TB_portion.BackColor = Color.Red;
            }
            else
            {
                TB_portion.BackColor = Color.White;
            }

            if (!invalid)
            {
                XmlLibrary.XmlHandling.addProduct("Products.xml", TB_name.Text, TB_manufacturer.Text, TB_kcal100g.Text, TB_carbohydrates.Text, TB_proteins.Text, TB_fats.Text, TB_portion.Text);
                InsertNewForm.ActiveForm.Close();
            }
        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            InsertNewForm.ActiveForm.Close();
        }
    }
}
