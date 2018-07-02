using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using MahApps.Metro.Controls;
using RentalSoftware.Logic;
using PrintDialog = System.Windows.Controls.PrintDialog;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for MakeASale.xaml
    /// </summary>
    public partial class MakeASale : MetroWindow
    {
        //globabl compnay infor
        public string compName= new CompanyLogic().GetCompanyInfo().CompanyName;
        public string comPhone = new CompanyLogic().GetCompanyInfo().Phone;
        public string compAddress = new CompanyLogic().GetCompanyInfo().Address;
        public string compTerms= new CompanyLogic().GetCompanyInfo().Terms;

        //global customer infor
        public string name;
        public string phone;
        public string address;
        public string email;


        public  string itemName;
        public string quantity;
        public string totalCost;
        public string unitprice;
      //  public List<string> quanty = new List<string>();
        public double per=0.00;

     ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public MakeASale()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
            this.Pos.Text= new CompanyLogic().GetCompanyInfo().CompanyName + " POS";
            //Days.Text = "1";
        }

        //validation rules
        //regular expression for checking validation
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9@,&()'-.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Customer_Loaded(object sender, RoutedEventArgs e)
        {

            ItemName.ItemsSource = new ItemLogic().ItemName();
            Customer.ItemsSource = new CustomerLocgic().CustomerName();
        }

        private void Customer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             name = new CustomerLocgic().GetCustomerInfo(Customer.SelectedItem.ToString()).FullName;
             phone = new CustomerLocgic().GetCustomerInfo(Customer.SelectedItem.ToString()).Phone;
             address = new CustomerLocgic().GetCustomerInfo(Customer.SelectedItem.ToString()).Address;
             email = new CustomerLocgic().GetCustomerInfo(Customer.SelectedItem.ToString()).Email;

            list.Items.Clear();
            list.Items.Add(name);
            list.Items.Add(phone);
            list.Items.Add(address);
            list.Items.Add(email);
        }

        private void PrintAndSave_Click(object sender, RoutedEventArgs e)
        {
           // DataGrid li = new DataGrid;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
           
            //// this.ItemListView.ItemsSource = OrderCollection.GetOder();

        }

        //inserting values into varies textboxes as item is selected
        private void ItemName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = ItemName.SelectedItem.ToString();

            if (!MakeSaleLogic.IsQuantityZero(item))
            {
                errM.Message =
                    "OOPS!!! Item may have zero quantity, check available quantity and try again.";
                errM.Show();
            }
            else
            {
               
                UnitPrice.Text = new ItemLogic().GeItemInfo(item).UnitePrice.ToString();
                AvailQty.Text = new ItemLogic().GeItemInfo(item).Quantity.ToString();

                Quantity.Value = 0;
                TotalCost.Text = 0.ToString();
            }
           
        }

        //values changed on various controls
        private void Quantity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
           
            double num;
            if (string.IsNullOrEmpty(Quantity.Value.ToString()) == false)
            {
                if (double.TryParse(Quantity.Value.ToString(), out num))
                {
                    if (ItemName.SelectedValue == null)
                    {
                        errM.Message = "Please select an item name";
                        errM.Show();
                    }
                    else
                    {
                        var value = Convert.ToDouble(Quantity.Value) * Convert.ToDouble(UnitPrice.Text) + "";
                        TotalCost.Text = value;
                    }

                }
               
            }
        }

        private void Quantity_TextInput(object sender, TextCompositionEventArgs e)
        {
           
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (string.IsNullOrEmpty(ItemName.Text) || string.IsNullOrEmpty(Quantity.Value.ToString()))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                    OrderList.Items.Add(
                    new OrderItem.Order()
                    {
                        ItemName = ItemName.SelectedItem.ToString(),
                        Quantity = Quantity.Value.ToString(),
                        UnitPrice = UnitPrice.Text.ToString(),
                        Total = TotalCost.Text  
                    });
                i++;

                //summation of total colum
                double total = 0;
                foreach (OrderItem.Order item in OrderList.Items)
                {                
                    total += Convert.ToDouble(item.Total);
                }
                Total.Value = total;
                SubTotal.Value = total;
            }

        }


        private void OrderList_Loaded(object sender, RoutedEventArgs e)
        {
           
        }


        private void Discount_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            //if (Total.Value == null)
            //{
            //    errM.Message = "Please select Total is empty to add or deduct";
            //    errM.Show();
            //}
            //else if (Discount.Text != null)
            //{
            //    Total.Value = Total.Value.GetValueOrDefault() - Convert.ToDouble(Discount.Text);
            //}
            //else if (Discount.Text == null)
            //{
            //    double total2 = 0;
            //    foreach (OrderItem.Order item in OrderList.Items)
            //    {
            //        total2 += Convert.ToDouble(item.Total);
            //    }
            //    Total.Value = total2;
            //}
        }
       


    private void button_Click(object sender, RoutedEventArgs e)
        {
            //removing items from the listview
            double total = 0;
            ArrayList elems = new ArrayList(OrderList.SelectedItems);

            foreach (OrderItem.Order eachItem in elems)
            {
                OrderList.Items.Remove(eachItem);
              
            }

            //deducting from remove items
            double total2 = 0;
            foreach (OrderItem.Order item in OrderList.Items)
            {
                total2 += Convert.ToDouble(item.Total);
            }
            Total.Value = total2;
            SubTotal.Value = total2;
        }

        private void Discount_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            //if (Total.Value == null)
            //{
            //    errM.Message = "Please select Total is empty to add or deduct";
            //    errM.Show();
            //}
            //else if (Discount.Value != null)
            //{
            //    Total.Value = Total.Value.GetValueOrDefault() - Discount.Value.GetValueOrDefault();
            //}
            //else if (Discount.Value == null)
            //{
            //    double total2 = 0;
            //    foreach (OrderItem.Order item in OrderList.Items)
            //    {
            //        total2 += Convert.ToDouble(item.Total);
            //    }
            //    Total.Value = total2;
            //}
        }

        private void Discount_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (String.IsNullOrEmpty(Total.Value.ToString()) == true)
            //{
            //    errM.Message = "Please select Total is empty to add or deduct";
            //    errM.Show();
            //}
            //else if (Discount.Text != String.Empty)
            //{
            //    Total.Value -= Convert.ToInt32(Discount.Text);
            //}

            ////revert back to original Total if no discount given
            //else if (Discount.Text == String.Empty)
            //{
            //    double total2 = 0;
            //    foreach (OrderItem.Order item in OrderList.Items)
            //    {
            //        total2 += Convert.ToDouble(item.Total);
            //    }
            //    Total.Value = total2;
            //}
        }

        private void Discount_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Total.Value.ToString()) == true)
            {
                errM.Message = "Please select Total is empty to add or deduct";
                errM.Show();
            }
            else if (Discount.Text != String.Empty)
            {
                Total.Value -= Convert.ToInt32(Discount.Text);

                var disc = (Convert.ToDouble(Discount.Text)/SubTotal.Value.GetValueOrDefault()) * 100;

                Percent.Text= string.Format("{0:N2}", disc);
            }

            //revert back to original Total if no discount given
            else if (Discount.Text == String.Empty)
            {
                Percent.Text = 0.00.ToString();
                double total2 = 0;
                foreach (OrderItem.Order item in OrderList.Items)
                {
                    total2 += Convert.ToDouble(item.Total);
                }
                Total.Value = total2;
            }
        }

        private void Percent_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Total.Value.ToString()) == true)
            {
                errM.Message = "Please select Total is empty to add or deduct";
                errM.Show();
            }

            else if (Percent.Text != String.Empty)
            {
                var percentage = (Convert.ToDouble(Percent.Text)/100)*SubTotal.Value.GetValueOrDefault();
                Discount.Text = percentage.ToString();

                Total.Value = SubTotal.Value.GetValueOrDefault() - Convert.ToDouble(Discount.Text);
            }

            //revert back to original Total if no discount given
            else if (Percent.Text == String.Empty)
            {
                Discount.Text = 0.00.ToString();
                double total2 = 0;
                foreach (OrderItem.Order item in OrderList.Items)
                {
                    total2 += Convert.ToDouble(item.Total);
                }
                Total.Value = total2;
            }
            
        }

        //private void Days_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    if (String.IsNullOrEmpty(Total.Value.ToString()) == true)
        //    {
        //        errM.Message = "Please select Total is empty to add or deduct";
        //        errM.Show();
        //    }

        //    else if (Days.Text != String.Empty)
        //    {


        //        Total.Value = Total.Value.GetValueOrDefault() * Convert.ToDouble(Days.Text);
        //        SubTotal.Value = SubTotal.Value.GetValueOrDefault() * Convert.ToDouble(Days.Text);
        //    }

        //    //revert back to original Total if no discount given
        //    else if (Days.Text == String.Empty)
        //    {
        //        double total2 = 0;
        //        foreach (OrderItem.Order item in OrderList.Items)
        //        {
        //            total2 += Convert.ToDouble(item.Total);
        //        }
        //        Total.Value = total2;
        //        SubTotal.Value = total2;
        //    }
        //}


        //save only
        private void SaveO_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(ItemName.Text) || string.IsNullOrEmpty(Quantity.Value.ToString()))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                //looping to get all items in the listview
                foreach (OrderItem.Order item in OrderList.Items)
                {
                    for (int i = 0; i < OrderList.Items.Count; i++)
                    {
                        itemName = item.ItemName;
                        quantity = item.Quantity;
                        totalCost = item.Total;

                    }

                    MakeSaleLogic.Ordering(Customer.Text, itemName, CurrentUserLoggedInData.id.ToString(), quantity, Discount.Text, totalCost);

                }
                sm.Message = "New item(s) order is processed successfully.";
                sm.Show();
                //PrintDocument printDocument = new PrintDocument();
                //PrintPreviewDialog prview = new PrintPreviewDialog();

                //prview.Document = printDocument;
                //printDocument.PrintPage += PrintDocument_PrintPage;
                //printDocument.Print();

            }
        }



        //saving odering into oder table
        private void SavedOnly_Click(object sender, RoutedEventArgs e)
        {
          

            if (string.IsNullOrEmpty(ItemName.Text) || string.IsNullOrEmpty(Quantity.Value.ToString()))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                //looping to get all items in the listview
                foreach (OrderItem.Order item in OrderList.Items)
                {
                    for (int i = 0; i < OrderList.Items.Count; i++)
                    {
                        itemName = item.ItemName;
                        quantity = item.Quantity;
                        totalCost = item.Total;
                      
                    }
                    
                MakeSaleLogic.Ordering(Customer.Text, itemName, CurrentUserLoggedInData.id.ToString(), quantity,Discount.Text, totalCost);
 
                }
                //sm.Message = "New item(s) order is processed successfully.";
                //sm.Show();
                PrintDocument printDocument = new PrintDocument();
                PrintPreviewDialog prview = new PrintPreviewDialog();

                prview.Document = printDocument;
                printDocument.PrintPage += PrintDocument_PrintPage;
                printDocument.Print();

            }
        }

        private void ResetAll_Click(object sender, RoutedEventArgs e)
        {
            //removing items from the listview
            double total = 0;
            ArrayList elems = new ArrayList(OrderList.Items);

            foreach (OrderItem.Order eachItem in elems)
            {
                OrderList.Items.Remove(eachItem);

            }

            //deducting from remove items
            double total2 = 0;
            foreach (OrderItem.Order item in OrderList.Items)
            {
                total2 += Convert.ToDouble(item.Total);
            }
            Total.Value = total2;
            SubTotal.Value = total2;

            //setting others to notting
            Discount.Text = 0.ToString();
            Percent.Text = 0.ToString();

        }

        private void NewCustomer_Click(object sender, RoutedEventArgs e)
        {
            new AddCustomer().ShowDialog();
        }

        private void PrintAndSave_Click_1(object sender, RoutedEventArgs e)
        {
           PrintDialog printDilog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            PrintPreviewDialog prview = new PrintPreviewDialog();

            prview.Document = printDocument;
            printDocument.PrintPage += PrintDocument_PrintPage;
            prview.ShowDialog();
            
        }

        //printing function
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Arial", 12, System.Drawing.FontStyle.Regular);
            float fontHeight = font.GetHeight();

            int startx = 10;
            int starty = 420;
            int offset = 10;

            //Bitmap bmp = Properties.Resources.
            //Image newImage = bmp;
            graphic.FillRectangle(Brushes.DarkCyan, new Rectangle(25, 80, 800, 5));
            graphic.DrawString(compName, new Font("Arial", 18, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 100), new SizeF(370, 0)));
            graphic.DrawString(compAddress, new Font("Arial", 18), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 130), new SizeF(370, 0)));

            graphic.DrawString(comPhone, new Font("Arial", 18), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 200), new SizeF(370, 0)));
            graphic.DrawString("PAYMENT RECIEPT", new Font("Arial Black", 18,System.Drawing.FontStyle.Bold), new SolidBrush(Color.DarkCyan), new PointF(420, 100));
            graphic.DrawString("DATE: " + DateTime.Now, new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new PointF(420, 150));

            //drawing a rectangle
            graphic.FillRectangle(Brushes.DarkCyan, new Rectangle(25, 240, 800, 5));

            //Bill to customer information
            graphic.DrawString("Bill To: ", new Font("Arial", 18), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 270), new SizeF(500, 0)));
            graphic.DrawString(name, new Font("Arial", 14), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 300), new SizeF(500, 0)));
            graphic.DrawString(phone, new Font("Arial", 14), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 320), new SizeF(500, 0)));
            graphic.DrawString(address, new Font("Arial", 14), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 340), new SizeF(500, 0)));

            //item Bill information heading.
            graphic.FillRectangle(Brushes.Black, new Rectangle(25, 375, 800, 2));
            graphic.DrawString("DRUG DESCRIPTION", new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 380), new SizeF(500, 0)));
            graphic.DrawString("QUANTITY", new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(350, 380), new SizeF(500, 0)));
            graphic.DrawString("UNIT PRICE", new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(480, 380), new SizeF(500, 0)));
            graphic.DrawString("TOTAL COST", new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(650, 380), new SizeF(500, 0)));
            graphic.FillRectangle(Brushes.Black, new Rectangle(25, 405, 800, 2));

            //looping through the items
            foreach (OrderItem.Order item in OrderList.Items)
            {
                for (int i = 0; i < OrderList.Items.Count; i++)
                {
                    itemName = item.ItemName.PadRight(30);
                    quantity = item.Quantity;
                    unitprice=String.Format("{0:N2}", item.UnitPrice);
                    totalCost = string.Format("{0:N2}", item.Total);

                }
                graphic.DrawString(itemName, font, new SolidBrush(Color.Black), new RectangleF(new PointF(25, starty + offset), new SizeF(500, 0)));
                graphic.DrawString(quantity, font, new SolidBrush(Color.Black), new RectangleF(new PointF(365, starty + offset), new SizeF(500, 0)));
                graphic.DrawString(unitprice, font, new SolidBrush(Color.Black), new RectangleF(new PointF(495, starty + offset), new SizeF(500, 0)));
                graphic.DrawString(totalCost, font, new SolidBrush(Color.Black), new RectangleF(new PointF(665, starty + offset), new SizeF(500, 0)));

                offset = offset + (int) fontHeight + 8;
                
            }
            graphic.FillRectangle(Brushes.Black, new Rectangle(25, 350 + starty, 800, 2));
            //terms
            graphic.DrawString("Terms and Condition:", new Font("Arial", 10, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 380 + starty), new SizeF(400, 0)));
            graphic.DrawString(compTerms, new Font("Arial", 10, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Black), new RectangleF(new PointF(25, 400 + starty), new SizeF(400, 0)));

            //discount
             //var perc = Convert.ToDouble(Percent.Text);
            graphic.DrawString("Discount", new Font("Arial", 12, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Black), new RectangleF(new PointF(495, 360 + starty), new SizeF(500, 0)));
            graphic.DrawString(string.Format("%{0:N2}",Percent.Text), new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(660, 360 + starty), new SizeF(500, 0)));

            //subtotal
            graphic.DrawString("SubTotal", new Font("Arial", 12, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Black), new RectangleF(new PointF(495, 385 + starty), new SizeF(500, 0)));
            graphic.DrawString(string.Format("₵{0:N2}", SubTotal.Value), new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(660, 385 + starty), new SizeF(500, 0)));

            //total
            graphic.FillRectangle(Brushes.Black, new Rectangle(495, 420 + starty, 300, 2));
            graphic.DrawString("Total", new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(495, 430 + starty), new SizeF(500, 0)));
            graphic.DrawString(string.Format("₵{0:N2}", Total.Value), new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(660, 430 + starty), new SizeF(500, 0)));
            graphic.FillRectangle(Brushes.Black, new Rectangle(495, 460 + starty, 300, 2));

            //customer and manager sign
            graphic.FillRectangle(Brushes.Black, new Rectangle(80, 520 + starty, 200, 1));
            graphic.DrawString("Customer Signature", new Font("Arial", 12, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Black), new RectangleF(new PointF(100, 530 + starty), new SizeF(500, 0)));

            graphic.FillRectangle(Brushes.Black, new Rectangle(500, 520 + starty, 200, 1));
            graphic.DrawString("Manager Signature", new Font("Arial", 12, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Black), new RectangleF(new PointF(520, 530 + starty), new SizeF(500, 0)));

            //thank you
            graphic.DrawString("Thank you and Stay Healthy.", new Font("Arial", 12, System.Drawing.FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(new PointF(280, 570 + starty), new SizeF(400, 0)));

        }

      
        //
    }
}
