using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cofee_Shop
{
    public partial class Cofee_Shop : Form
    {
        public Cofee_Shop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            int price = 0;
            string name = "";
            string number = "";
            string address = "";
            string order = "";
            string quantity = "";

             name = customer_nameTextBox.Text;
             number = contact_numberTextBox.Text;
             address = addressTextBox.Text;
             order = orderComboBox.Text;
             quantity = quantityTextBox.Text;

            int Quantity = Convert.ToInt32(quantity);


            if (name != "" && number != "" && address != "" && order !="" && quantity!="")
            {
                if (order == "Black")
                {
                    price = Quantity * 120;
                    MessageBox.Show("The bill is " + price + "Tk.");
                }

                else if (order == "Cold")
                {
                    price = Quantity * 100;
                    MessageBox.Show("The bill is " + price + "Tk.");
                }

                else if (order == "Hot")
                {
                    price = Quantity * 90;
                    MessageBox.Show("The bill is " + price + "Tk.");
                }

                else if (order == "Regular")
                {
                    price = Quantity * 80;
                    MessageBox.Show("The bill is " + price + "Tk.");
                }
                else
                {
                    MessageBox.Show("Please fill the Order option");
                }



                displayRichTextBox.SelectedText = Environment.NewLine + "Customer Name :" + name;
                displayRichTextBox.SelectedText = Environment.NewLine + "Contact Number:" + number;
                displayRichTextBox.SelectedText = Environment.NewLine + "Address             :" + address;
                displayRichTextBox.SelectedText = Environment.NewLine + "Order                 :" + order;
                displayRichTextBox.SelectedText = Environment.NewLine + "Quantity            :" + quantity;
                displayRichTextBox.SelectedText = Environment.NewLine + "Price                 :" + price + "Tk.";
                displayRichTextBox.SelectedText = Environment.NewLine + "";

                customer_nameTextBox.Text = "";
                contact_numberTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.Text = "";
                quantityTextBox.Text = "";

                MessageBox.Show("All data is saved");


            }
            else
            {
                MessageBox.Show("Please fillup all options");
            }

        }
    }
}
