namespace Cofee_Shop
{
    partial class Cofee_Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customer_informationLabel = new System.Windows.Forms.Label();
            this.customernameLabel = new System.Windows.Forms.Label();
            this.contactnumberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customernameTextBox = new System.Windows.Forms.TextBox();
            this.contactnumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.displayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.informationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_informationLabel
            // 
            this.customer_informationLabel.AutoSize = true;
            this.customer_informationLabel.Location = new System.Drawing.Point(13, 0);
            this.customer_informationLabel.Name = "customer_informationLabel";
            this.customer_informationLabel.Size = new System.Drawing.Size(142, 17);
            this.customer_informationLabel.TabIndex = 0;
            this.customer_informationLabel.Text = "Customer Information";
            // 
            // customernameLabel
            // 
            this.customernameLabel.AutoSize = true;
            this.customernameLabel.Location = new System.Drawing.Point(13, 57);
            this.customernameLabel.Name = "customernameLabel";
            this.customernameLabel.Size = new System.Drawing.Size(109, 17);
            this.customernameLabel.TabIndex = 1;
            this.customernameLabel.Text = "Customer Name";
            // 
            // contactnumberLabel
            // 
            this.contactnumberLabel.AutoSize = true;
            this.contactnumberLabel.Location = new System.Drawing.Point(13, 101);
            this.contactnumberLabel.Name = "contactnumberLabel";
            this.contactnumberLabel.Size = new System.Drawing.Size(110, 17);
            this.contactnumberLabel.TabIndex = 2;
            this.contactnumberLabel.Text = "Contact Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 147);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(12, 217);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(45, 17);
            this.orderLabel.TabIndex = 4;
            this.orderLabel.Text = "Order";
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox.Location = new System.Drawing.Point(170, 217);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 24);
            this.orderComboBox.TabIndex = 5;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(12, 264);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity";
            // 
            // customernameTextBox
            // 
            this.customernameTextBox.Location = new System.Drawing.Point(170, 57);
            this.customernameTextBox.Name = "customernameTextBox";
            this.customernameTextBox.Size = new System.Drawing.Size(100, 22);
            this.customernameTextBox.TabIndex = 7;
            // 
            // contactnumberTextBox
            // 
            this.contactnumberTextBox.Location = new System.Drawing.Point(170, 101);
            this.contactnumberTextBox.Name = "contactnumberTextBox";
            this.contactnumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.contactnumberTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(170, 147);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressTextBox.TabIndex = 9;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(170, 264);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 10;
            // 
            // informationPanel
            // 
            this.informationPanel.Controls.Add(this.saveButton);
            this.informationPanel.Controls.Add(this.customer_informationLabel);
            this.informationPanel.Controls.Add(this.orderComboBox);
            this.informationPanel.Controls.Add(this.quantityTextBox);
            this.informationPanel.Controls.Add(this.customernameLabel);
            this.informationPanel.Controls.Add(this.addressTextBox);
            this.informationPanel.Controls.Add(this.contactnumberLabel);
            this.informationPanel.Controls.Add(this.contactnumberTextBox);
            this.informationPanel.Controls.Add(this.addressLabel);
            this.informationPanel.Controls.Add(this.customernameTextBox);
            this.informationPanel.Controls.Add(this.orderLabel);
            this.informationPanel.Controls.Add(this.quantityLabel);
            this.informationPanel.Location = new System.Drawing.Point(69, 44);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(407, 363);
            this.informationPanel.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(170, 311);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // displayRichTextBox
            // 
            this.displayRichTextBox.Location = new System.Drawing.Point(496, 44);
            this.displayRichTextBox.Name = "displayRichTextBox";
            this.displayRichTextBox.Size = new System.Drawing.Size(271, 363);
            this.displayRichTextBox.TabIndex = 12;
            this.displayRichTextBox.Text = "";
            // 
            // Cofee_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayRichTextBox);
            this.Controls.Add(this.informationPanel);
            this.Name = "Cofee_Shop";
            this.Text = "Cofee_Shop";
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label customer_informationLabel;
        private System.Windows.Forms.Label customernameLabel;
        private System.Windows.Forms.Label contactnumberLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox customernameTextBox;
        private System.Windows.Forms.TextBox contactnumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.RichTextBox displayRichTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}

