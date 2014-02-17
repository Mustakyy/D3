using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace D3
{
    public partial class CalorieCounter : UserControl
    {
        public CalorieCounter()
        {
            InitializeComponent();
            CB_amounttype.SelectedIndex = 0;
        }

        private void B_insertnew_Click(object sender, EventArgs e)
        {
            InsertNewForm insertform = new InsertNewForm();
            insertform.Show();
        }

        private void B_deleteselected_Click(object sender, EventArgs e)
        {
            if (LW_search.FocusedItem != null)
            {
                if (LW_search.FocusedItem.Selected)
                {
                    XmlLibrary.XmlHandling.removeProduct("Products.xml", LW_search.FocusedItem.SubItems[0].Text, LW_search.FocusedItem.SubItems[1].Text);
                    LW_search.FocusedItem.Remove();
                }
            }
        }

        private void B_Search_Click(object sender, EventArgs e)
        {
            LW_search.Items.Clear();
            List<string[]> productsList = XmlLibrary.XmlHandling.allProducts("Products.xml");

            productsList = productsList.FindAll(searchWord);
            
            if (productsList != null)
            {
                if (RB_searchopt1.Checked)
                {
                    productsList.Sort((prod1, prod2) => prod1[0].CompareTo(prod2[0]));
                }
                else
                {
                    productsList.Sort((prod1, prod2) => prod1[1].CompareTo(prod2[1]));
                }
                foreach (string[] prod in productsList)
                {
                    ListViewItem LVProduct = new ListViewItem(prod, prod[0]+prod[1]);
                    
                    //allow us to give different colort for different subitems
                    LVProduct.UseItemStyleForSubItems = false;
                    
                    LVProduct.SubItems[3].ForeColor = Color.Blue;
                    LVProduct.SubItems[4].ForeColor = Color.Green;
                    LVProduct.SubItems[5].ForeColor = Color.Red;
                    if (decimal.Parse(LVProduct.SubItems[3].Text) >
                        decimal.Parse(LVProduct.SubItems[4].Text) &&
                        decimal.Parse(LVProduct.SubItems[3].Text) >
                        decimal.Parse(LVProduct.SubItems[5].Text))
                    {
                        LVProduct.SubItems[0].ForeColor = Color.Blue;
                    }
                    else if (decimal.Parse(LVProduct.SubItems[4].Text) >
                        decimal.Parse(LVProduct.SubItems[3].Text) &&
                        decimal.Parse(LVProduct.SubItems[4].Text) >
                        decimal.Parse(LVProduct.SubItems[5].Text))
                    {
                        LVProduct.SubItems[0].ForeColor = Color.Green;
                    }
                    else if (decimal.Parse(LVProduct.SubItems[5].Text) >
                        decimal.Parse(LVProduct.SubItems[3].Text) &&
                        decimal.Parse(LVProduct.SubItems[5].Text) >
                        decimal.Parse(LVProduct.SubItems[4].Text))
                    {
                        LVProduct.SubItems[0].ForeColor = Color.Red;
                    }
                    LW_search.Items.Add(LVProduct);
                }
            }
        }

        private bool searchWord(string[] product)
        {
            if (RB_searchopt1.Checked)
            {
                if (product[0].StartsWith(TB_Search.Text, true, null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (product[1].StartsWith(TB_Search.Text, true, null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void B_add_Click(object sender, EventArgs e)
        {
            if (LW_search.FocusedItem != null)
            {
                if (LW_search.FocusedItem.Selected)
                {
                    decimal amount;
                    if (TB_amount.Text != "" && decimal.TryParse(TB_amount.Text, out amount))
                    {
                        //because of our else turns this to red
                        TB_amount.BackColor = Color.White;

                        ListViewItem fooditem = (ListViewItem)LW_search.FocusedItem.Clone();
                        if (CB_amounttype.SelectedIndex == 0)
                        {
                            fooditem.SubItems[2].Text = (decimal.Parse(fooditem.SubItems[2].Text) / 100 * (decimal.Parse(fooditem.SubItems[6].Text) * amount)).ToString();
                            fooditem.SubItems[3].Text = (decimal.Parse(fooditem.SubItems[3].Text) / 100 * (decimal.Parse(fooditem.SubItems[6].Text) * amount)).ToString();
                            fooditem.SubItems[4].Text = (decimal.Parse(fooditem.SubItems[4].Text) / 100 * (decimal.Parse(fooditem.SubItems[6].Text) * amount)).ToString();
                            fooditem.SubItems[5].Text = (decimal.Parse(fooditem.SubItems[5].Text) / 100 * (decimal.Parse(fooditem.SubItems[6].Text) * amount)).ToString();
                            fooditem.SubItems[6].Text = (decimal.Parse(fooditem.SubItems[6].Text) / 100 * (decimal.Parse(fooditem.SubItems[6].Text) * amount)).ToString();
                        }
                        else if (CB_amounttype.SelectedIndex == 1)
                        {
                            fooditem.SubItems[2].Text = (decimal.Parse(fooditem.SubItems[2].Text) / 100 * amount).ToString();
                            fooditem.SubItems[3].Text = (decimal.Parse(fooditem.SubItems[3].Text) / 100 * amount).ToString();
                            fooditem.SubItems[4].Text = (decimal.Parse(fooditem.SubItems[4].Text) / 100 * amount).ToString();
                            fooditem.SubItems[5].Text = (decimal.Parse(fooditem.SubItems[5].Text) / 100 * amount).ToString();
                            fooditem.SubItems[6].Text = (decimal.Parse(fooditem.SubItems[6].Text) / 100 * amount).ToString();
                        }

                        bool added = false;
                        foreach (ListViewItem LvI in LW_foods.Items)
                        {
                            if (LvI.ImageKey == fooditem.ImageKey)
                            {
                                LvI.SubItems[2].Text =
                                    (decimal.Parse(LvI.SubItems[2].Text) +
                                    decimal.Parse(fooditem.SubItems[2].Text)).ToString();
                                LvI.SubItems[3].Text =
                                    (decimal.Parse(LvI.SubItems[3].Text) +
                                    decimal.Parse(fooditem.SubItems[3].Text)).ToString();
                                LvI.SubItems[4].Text =
                                    (decimal.Parse(LvI.SubItems[4].Text) +
                                    decimal.Parse(fooditem.SubItems[4].Text)).ToString();
                                LvI.SubItems[5].Text =
                                    (decimal.Parse(LvI.SubItems[5].Text) +
                                    decimal.Parse(fooditem.SubItems[5].Text)).ToString();
                                LvI.SubItems[6].Text =
                                    (decimal.Parse(LvI.SubItems[6].Text) +
                                    decimal.Parse(fooditem.SubItems[6].Text)).ToString();
                                //keep record if we have same product already in the list
                                added = true;

                                //add same amount to the total list
                                LW_total.Items[0].SubItems[0].Text = (decimal.Parse(LW_total.Items[0].SubItems[0].Text) +
                                    decimal.Parse(fooditem.SubItems[2].Text)).ToString();
                                LW_total.Items[0].SubItems[1].Text = (decimal.Parse(LW_total.Items[0].SubItems[1].Text) +
                                    decimal.Parse(fooditem.SubItems[3].Text)).ToString();
                                LW_total.Items[0].SubItems[2].Text = (decimal.Parse(LW_total.Items[0].SubItems[2].Text) +
                                    decimal.Parse(fooditem.SubItems[4].Text)).ToString();
                                LW_total.Items[0].SubItems[3].Text = (decimal.Parse(LW_total.Items[0].SubItems[3].Text) +
                                    decimal.Parse(fooditem.SubItems[5].Text)).ToString();
                                LW_total.Items[0].SubItems[4].Text = (decimal.Parse(LW_total.Items[0].SubItems[4].Text) +
                                    decimal.Parse(fooditem.SubItems[6].Text)).ToString();

                                //no need to check all when we have found our target product
                                break;
                            }
                        }
                        if (!added)
                        {
                            string k = fooditem.ImageKey;
                            LW_foods.Items.Add(fooditem);

                            //adding same amount to the complete calculator bellow
                            if (LW_total.Items.Count == 0)
                            {
                                ListViewItem LVToT = new ListViewItem(new string[5] { fooditem.SubItems[2].Text, fooditem.SubItems[3].Text, fooditem.SubItems[4].Text, fooditem.SubItems[5].Text, fooditem.SubItems[6].Text }, "Total");
                                LVToT.UseItemStyleForSubItems = false;
                                LVToT.SubItems[1].ForeColor = Color.Blue;
                                LVToT.SubItems[2].ForeColor = Color.Green;
                                LVToT.SubItems[3].ForeColor = Color.Red;
                                LW_total.Items.Add(LVToT);
                            }
                            else
                            {
                                LW_total.Items[0].SubItems[0].Text = (decimal.Parse(LW_total.Items[0].SubItems[0].Text) +
                                    decimal.Parse(fooditem.SubItems[2].Text)).ToString();
                                LW_total.Items[0].SubItems[1].Text = (decimal.Parse(LW_total.Items[0].SubItems[1].Text) +
                                    decimal.Parse(fooditem.SubItems[3].Text)).ToString();
                                LW_total.Items[0].SubItems[2].Text = (decimal.Parse(LW_total.Items[0].SubItems[2].Text) +
                                    decimal.Parse(fooditem.SubItems[4].Text)).ToString();
                                LW_total.Items[0].SubItems[3].Text = (decimal.Parse(LW_total.Items[0].SubItems[3].Text) +
                                    decimal.Parse(fooditem.SubItems[5].Text)).ToString();
                                LW_total.Items[0].SubItems[4].Text = (decimal.Parse(LW_total.Items[0].SubItems[4].Text) +
                                    decimal.Parse(fooditem.SubItems[6].Text)).ToString();
                            }
                        }
                    }
                    else
                    {
                        TB_amount.BackColor = Color.Red;
                    }
                }
            }
        }

        private void B_remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem LvI in LW_foods.SelectedItems)
            {
                LW_total.Items[0].SubItems[0].Text = (decimal.Parse(LW_total.Items[0].SubItems[0].Text) -
                    decimal.Parse(LvI.SubItems[2].Text)).ToString();
                LW_total.Items[0].SubItems[1].Text = (decimal.Parse(LW_total.Items[0].SubItems[1].Text) -
                    decimal.Parse(LvI.SubItems[3].Text)).ToString();
                LW_total.Items[0].SubItems[2].Text = (decimal.Parse(LW_total.Items[0].SubItems[2].Text) -
                    decimal.Parse(LvI.SubItems[4].Text)).ToString();
                LW_total.Items[0].SubItems[3].Text = (decimal.Parse(LW_total.Items[0].SubItems[3].Text) -
                    decimal.Parse(LvI.SubItems[5].Text)).ToString();
                LW_total.Items[0].SubItems[4].Text = (decimal.Parse(LW_total.Items[0].SubItems[4].Text) -
                    decimal.Parse(LvI.SubItems[6].Text)).ToString();
                if (LW_total.Items[0].SubItems[0].Text == "0")
                {
                    LW_total.Items[0].Remove();
                }
                //remove the actual food
                LvI.Remove();
            }
        }

        private void B_combinedb_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.InitialDirectory = Application.StartupPath;
            filedialog.Title = "Open database";
            filedialog.Filter = "XML files (*.xml)|*.xml";
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                XmlLibrary.XmlHandling.combineDB("Products.xml", filedialog.FileName);
            }
        }
    }
}
