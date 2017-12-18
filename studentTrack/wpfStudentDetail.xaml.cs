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
    /// Interaction logic for wpfStudentDetail.xaml
    /// </summary>
    public partial class wpfStudentDetail : Window
    {
        clsDataTracker dataTracker;

        private clsSQLite Sqlite;

        public SQLquery Query;
        public wpfStudentDetail()
        {
            Sqlite = new clsSQLite();

            Query = new SQLquery();
            dataTracker = new clsDataTracker();

            InitializeComponent();

            dgStudentList.ItemsSource = dataTracker.makeStudentList();
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfStudent student = new wpfStudent();
                student.ShowDialog();

                dgStudentList.ItemsSource = dataTracker.makeStudentList();


                dgStudentList.Items.Refresh();

                this.Show();
            }
            catch (Exception ex)
            {
                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btndelStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult result;
                //prompt message box and hold result
                result = MessageBox.Show("Are you suer want to delete?", "confirm", MessageBoxButton.YesNo);

                if (dgStudentList.SelectedItem != "" && result == MessageBoxResult.Yes)
                {

                    int sid = (dgStudentList.SelectedItem as StudentDetail).studentId;

                    Sqlite.ExecuteNonQuery(Query.delStudent(sid));

                    dgStudentList.ItemsSource = dataTracker.makeStudentList();

                    dgStudentList.Items.Refresh();
                }

            }
            catch (Exception ex)
            {
                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnEditStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                

                if (dgStudentList.SelectedItem != null)
                {
                    wpfStudentEdit editStudent = new wpfStudentEdit();
                    editStudent.index = (dgStudentList.SelectedItem as StudentDetail).index;
                    editStudent.ShowDialog();

                    dgStudentList.ItemsSource = dataTracker.makeStudentList();

                    dgStudentList.Items.Refresh();
                }

            }
            catch (Exception ex)
            {
                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
