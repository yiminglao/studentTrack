using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectGroup2
{
    /// <summary>
    /// Interaction logic for wpfDescDetail.xaml
    /// </summary>
    public partial class wpfDescDetail : Window
    {
        clsDataTracker dataTracker;

        private clsSQLite Sqlite;

        public SQLquery Query;
        public wpfDescDetail()
        {
            InitializeComponent();

            Sqlite = new clsSQLite();

            Query = new SQLquery();
            dataTracker = new clsDataTracker();

            dgDesc.ItemsSource = dataTracker.makeDescriptionList();

           
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();

            e.Cancel = true;
        }

        /// <summary>
        /// Error handler to display errors
        /// </summary>
        /// <param name="sClass">class name</param>
        /// <param name="sMethod">method name</param>
        /// <param name="sMessage">error message</param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                //show message box
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex)
            {
                //output error log to file
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }

        private void btDescdel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult result;
                //prompt message box and hold result
                result = MessageBox.Show("Are you sure want to delete?", "confirm", MessageBoxButton.YesNo);

                if (dgDesc.SelectedItem != null && result == MessageBoxResult.Yes)
                {
                    int id = (dgDesc.SelectedItem as DescriptionDetail).DescId;

                    Sqlite.ExecuteNonQuery(Query.delDesc(id));

                    dgDesc.ItemsSource = dataTracker.makeDescriptionList();


                    dgDesc.Items.Refresh();
                }
            }
            catch (Exception ex)
            {
                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btDescEdit_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgDesc.SelectedItem != null)
                {

                    wpfUpdateDesc update = new wpfUpdateDesc();

                    update.descDetail = (dgDesc.SelectedItem as DescriptionDetail);
                    update.ShowDialog();

                    dgDesc.ItemsSource = dataTracker.makeDescriptionList();

                    dgDesc.Items.Refresh();


                }
            }
            catch (Exception ex)
            {
                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
