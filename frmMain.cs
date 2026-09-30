using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WinForms_Template.Retail;

namespace WinForms_Template
{
    public partial class frmMain : Form
    {
        private ProductList productList = new ProductList();

        public frmMain()
        {
            InitializeComponent();

            lvReceipt.View = View.Details;
            lvReceipt.FullRowSelect = true;
            lvReceipt.GridLines = true;

            lvReceipt.Columns.Add("Barcode");
            lvReceipt.Columns.Add("Desc.");
            lvReceipt.Columns.Add("Unit £");
            lvReceipt.Columns.Add("Qnty");
            lvReceipt.Columns.Add("Total");

            txtProduct.KeyDown += txtProductCode_KeyDown;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    RecordProduct(txtProduct.Text);
                    txtProduct.Text = "";
                    break;
            }
        }

        private bool RecordProduct(string code) {

            int _quantity = 1;
            Product? _product = productList.GetProduct(code);
            if(_product == null)
            {
                //Show Error
                return false;
            }

            ListViewItem row1 = new ListViewItem(code);
            row1.SubItems.Add(_product.Value.description);
            row1.SubItems.Add(_product.Value.unitPrice.ToString());
            row1.SubItems.Add(_quantity.ToString());
            row1.SubItems.Add((_product.Value.unitPrice * _quantity).ToString());

            lvReceipt.Items.Add(row1);
            return true;
        }

        private void ChangeQuantity()
        {
            string quantityValue = txtProduct.Text;
            int quantity = -1;
            if(int.TryParse(quantityValue, out quantity))
            {
                    ListViewItem latestItem = lvReceipt.Items[lvReceipt.Items.Count - 1];
                    latestItem.SubItems[3].Text = quantity.ToString();
                    latestItem.SubItems[4].Text = (float.Parse(latestItem.SubItems[2].Text) * quantity).ToString();
                
            }
            txtProduct.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeQuantity();
        }
    }
}
