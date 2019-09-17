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

        int i = 0;
        int[] price = new int[100];
        string[] name = new string[100];
        string[] number = new string[100];
        string[] address = new string[100];
        string[] order = new string[100];
        string[] quantity = new string[100];
        int[] Quantity = new int[100];

        public Cofee_Shop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           

                if (customernameTextBox.Text != "" && contactnumberTextBox.Text != "" && addressTextBox.Text != "" &&
                    orderComboBox.Text != "" && quantityTextBox.Text != "")
                {

                    quantity[i] = "0";
                    name[i] = customernameTextBox.Text;
                    number[i] = contactnumberTextBox.Text;
                    address[i] = addressTextBox.Text;
                    order[i] = orderComboBox.Text;
                    quantity[i] = quantityTextBox.Text;

                    Quantity[i] = Convert.ToInt32(quantity[i]);

                    if (orderComboBox.Text == "Black")
                    {
                        price[i] = Quantity[i] * 120;
                        MessageBox.Show("The bill is " + price[i] + "Tk.");
                    }

                    else if (orderComboBox.Text == "Cold")
                    {
                        price[i] = Quantity[i] * 100;
                        MessageBox.Show("The bill is " + price[i] + "Tk.");
                    }

                    else if (orderComboBox.Text == "Hot")
                    {
                        price[i] = Quantity[i] * 90;
                        MessageBox.Show("The bill is " + price[i] + "Tk.");
                    }

                    else if (orderComboBox.Text == "Regular")
                    {
                        price[i] = Quantity[i] * 80;
                        MessageBox.Show("The bill is " + price[i] + "Tk.");
                    }
                    else
                    {
                        MessageBox.Show("Please fill the Order option");
                    }



                    displayRichTextBox.SelectedText = Environment.NewLine + "Customer Name :" + name[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Contact Number:" + number[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Address             :" + address[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Order                 :" + order[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Quantity            :" + quantity[i];
                    displayRichTextBox.SelectedText =Environment.NewLine + "Price                 :" + price[i] + "Tk.";
                    displayRichTextBox.SelectedText = Environment.NewLine + " ";

                    MessageBox.Show("All data is saved");

                    customernameTextBox.Text = "";
                    contactnumberTextBox.Text = "";
                    addressTextBox.Text = "";
                    orderComboBox.Text = "";
                    quantityTextBox.Text = "";

                  

                }

                else
                {
                    MessageBox.Show("Please fillup all options");
                }


                i++;

        }
    }
}
