using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPOS_Viral
{
    public partial class frmSearch : Form
    {
        Product[] pArr = null;
        public frmSearch()
        {
            InitializeComponent();
        }

    
           

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.pArr = null;
            this.Tag = this.pArr;
            this.Close();
        }

     

        private void btnCopyIDtoPOS_Click(object sender, EventArgs e)
        {
            if (txtCopyIDtoPOS.Text != "" && btnCopyIDtoPOS.Text == "Copy ID to POS")
            {
                lstSearch.Items.Clear();
                pArr = ProductDB.SelectLikeDesc(lstSearch.Text);
                if (pArr != null)
                {
                    foreach (Product product in pArr)
                    {
                        if (product != null)
                        {
                            lstSearch.Items.Add(product.ToString());
                            btnCopyIDtoPOS.Text = "Copy ID to POS";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Records Found");
                }
            }
            else if (btnCopyIDtoPOS.Text == "Copy ID to POS")
            {
                if (lstSearch.SelectedIndex >= 0)
                {
                    Tag = this.pArr[lstSearch.SelectedIndex];
                    this.Close();
                }
              else
               {
                 MessageBox.Show("No item selected. Please select an item in the list box.");
               }
            }
            else
            {
                return;
            }
        }

        private void lstSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCopyIDtoPOS.Text = "Search";
        }
    }

       
    }
    

