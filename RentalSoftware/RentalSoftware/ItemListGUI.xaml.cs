using System;
using System.Data;
using System.Windows;
using System.Windows.Input;
using MahApps.Metro.Controls;
using RentalSoftware.Logic;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Map;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for ItemListGUI.xaml
    /// </summary>
    public partial class ItemListGUI : MetroWindow
    {
        ErrorWindow errM= new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        private static ItemLogic.Item itemData = new ItemLogic.Item();

        public static ItemLogic.Item ItemData
        {
            get { return itemData; }
            set { itemData = value; }
            
        }
        public ItemListGUI()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            

            ItemView.ItemsSource = new ItemLogic().GetAllItems().DefaultView;
            ItemView.Columns[0].MaxWidth = 65;

            //formating the unit price to show in two decimal place
            var column = this.ItemView.Columns[4] as GridViewDataColumn;

            if (column != null) column.DataFormatString = "₵{0:N2}";
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            ItemView.ItemsSource = null;
            ItemView.ItemsSource = new ItemLogic().GetAllItems().DefaultView;

            var column = this.ItemView.Columns[4] as GridViewDataColumn;

            if (column != null) column.DataFormatString = "₵{0:N2}";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewItem_Click(object sender, RoutedEventArgs e)
        {
            new AddItem().ShowDialog();
        }

        //private void addItemCategory_Click(object sender, RoutedEventArgs e)
        //{
        //    new AddItemCategory().ShowDialog();
        //}

        //private void Edit_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void ItemCategory_Click(object sender, RoutedEventArgs e)
        {
            new AddItemCategory().ShowDialog();
        }

        private void ItemView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            DataRowView dataRow = ItemView.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                //over here im selecting each index of the selected row
                //based on the order on which your items are shown in the datagrid
                //note that changing that order will change your resultset
                ItemData.Id = dataRow.Row[0].ToString();
                ItemData.CategoryId = (string)dataRow.Row[1].ToString();
                ItemData.Name = (string)dataRow.Row[2].ToString();
                ItemData.Description = (string)dataRow.Row[3].ToString();
                ItemData.UnitePric = (string)dataRow.Row[4].ToString();
                ItemData.Quantity = (string)dataRow.Row[5].ToString();
                ItemData.Date = dataRow.Row[6].ToString();

            }
            new UpdateItem().ShowDialog();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            DataRowView dataRow = ItemView.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                //over here im selecting each index of the selected row
                //based on the order on which your items are shown in the datagrid
                //note that changing that order will change your resultset
                ItemData.Id = dataRow.Row[0].ToString();
                ItemData.CategoryId = (string)dataRow.Row[1].ToString();
                ItemData.Name = (string)dataRow.Row[2].ToString();
                ItemData.Description = (string)dataRow.Row[3].ToString();
                ItemData.UnitePric = (string)dataRow.Row[4].ToString();
                ItemData.Quantity = (string)dataRow.Row[5].ToString();
                ItemData.Date = dataRow.Row[6].ToString();

            }
            if (dataRow == null)
            {
                errM.Message = "Please select a row or an item from the table to update information.";
                errM.Show();
            }
            else
            {
                new UpdateItem().ShowDialog();

            }
        }

        //returning item into stock
        private void ReturnItem_Click(object sender, RoutedEventArgs e)
        {

            DataRowView dataRow = ItemView.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                ItemData.Id = dataRow.Row[0].ToString();
                ItemData.Name = (string)dataRow.Row[2].ToString();
            }
            if (dataRow == null)
            {
                errM.Message = "Please select a row or an item from the table to return item into stock.";
                errM.Show();
            }
            else
            {
               
                new ReturnItem().ShowDialog();
              //  MessageBox.Show(ItemData.Id);
            }

           
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow = ItemView.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                ItemData.Id = dataRow.Row[0].ToString();
            }
            if (dataRow == null)
            {
                errM.Message = "Please select a row or an item from the table to delete it.";
                errM.Show();
            }
            else
            {
                //giveing a warning message
                var response = System.Windows.MessageBox.Show("Do you really want to to delete this item from store", "Delete",
               MessageBoxButton.YesNo, MessageBoxImage.Stop);

                if (response == MessageBoxResult.No)
                {
                    e.Handled = true;
                }
                else
                {
                    ItemLogic.SetItemDeleteStatusToOne(ItemData.Id);
                    //refresh the datasource to pull all items status with status zero 
                    //into datagrid
                    ItemView.ItemsSource = null;
                    ItemView.ItemsSource = new ItemLogic().GetAllItems().DefaultView;
                    sm.Message = "Item is successfully deleted from the store.";
                    sm.Show();

                }
            }
        }
    }
}
