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
    public partial class frmMain : Form
    {
        private Transaction trans = new Transaction();

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.trans = new Transaction();
        }

        private void btnGetDescripition_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {

                Product product = ProductDB.SelectProduct(this.txtProductID.Text);
                Product realProduct = (Product) null;

                if (product != null)
                {
                    MessageBox.Show("Product: " + product.ToString());
                    if (product.Type == "Movie")
                        realProduct = (Product) ProductDB.SelectMovie(product.ID);
                    if (product.Type == "Music")
                        realProduct = (Product) ProductDB.SelectMusic(product.ID);
                    if (product.Type == "Software")
                        realProduct = (Product) ProductDB.SelectSoftware(product.ID);
                    if (product.Type == "Pants")
                        realProduct = (Product) ProductDB.SelectPants(product.ID);
                    if (product.Type == "DressShirt")
                        realProduct = (Product) ProductDB.SelectDressShirt(product.ID);
                    if (product.Type == "TShirt")
                        realProduct = (Product) ProductDB.SelectTShirt(product.ID);
                    if (product.Type == "Book")
                        realProduct = (Product) ProductDB.SelectBook(product.ID);
                }

                if (realProduct != null)
                {
                    Form frm = (Form) new frmProduct();
                    frm.Tag =  (Object)  realProduct;
                   int num = (int) frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Product: " + txtProductID.Text + " not found. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Product ID is empty. Please enter in a valid Product ID.");
            }
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            int qty;
            if (txtProductID.Text != "")
            {
                if (txtQuantity.Text != "" && Convert.ToInt32(txtQuantity.Text) > 0)
                {
                    try
                    {
                        qty = Convert.ToInt32(txtQuantity.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                    Product p = ProductDB.SelectProduct(txtProductID.Text);
                    if (p != null)
                    {
                        double num = p.Price * (double)qty;
                        this.lstScreen.Items.Add((object)(p.ID + "  " + p.Desc + "  " + (object)qty + " @ " + p.Price.ToString("C") + " -> " + num.ToString("C")));
                        trans.Add(p, qty);
                        txtProductID.Clear();
                        txtQuantity.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Quantity is empty/less than 0. Please enter in a value greater than 0.");
                }

            }
            else
            {
                MessageBox.Show("Product ID is empty. Please enter in a valid Product ID.");
            }
        }

        private void btnRemoveSelectedProduct_Click(object sender, EventArgs e)
        {

            if (lstScreen.SelectedIndex >= 0)
            {
                trans.RemoveAt(lstScreen.SelectedIndex);
                lstScreen.Items.RemoveAt(lstScreen.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Unable to remove product, no product selected. Please select a product.");
            }
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            trans.Clear();
            lstScreen.Items.Clear();

        }

        private void btnEnterSale_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {

                Product product = ProductDB.SelectProduct(this.txtProductID.Text);
                Product realProduct = null;

                if (product != null)
                {
                    MessageBox.Show("Product: " + product.ToString());
                    if (product.Type == "Movie")
                        realProduct = ProductDB.SelectMovie(product.ID);
                    if (product.Type == "Music")
                        realProduct = ProductDB.SelectMusic(product.ID);
                    if (product.Type == "Software")
                        realProduct = ProductDB.SelectSoftware(product.ID);
                    if (product.Type == "Pants")
                        realProduct = ProductDB.SelectPants(product.ID);
                    if (product.Type == "DressShirt")
                        realProduct = ProductDB.SelectDressShirt(product.ID);
                    if (product.Type == "TShirt")
                        realProduct = ProductDB.SelectTShirt(product.ID);
                    if (product.Type == "Book")
                        realProduct = ProductDB.SelectBook(product.ID);
                }

                if (realProduct != null)
                {
                    Form frm = new frmProduct();
                    frm.Tag = realProduct;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Product: " + txtProductID.Text + " not found. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Product ID is empty. Please enter in a valid Product ID.");
            }

        }

        private void btnSerchProducts_Click(object sender, EventArgs e)
        {
            Form form = new frmSearch();
            form.ShowDialog();
            if (form.Tag != null)
            {
                this.txtProductID.Text = ((Product)form.Tag).ID;
            }
            else
            {
                return;
            }
        }
    }
}