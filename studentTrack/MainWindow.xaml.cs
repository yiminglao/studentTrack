using System;
using System.Reflection;
using System.Windows;

namespace ProjectGroup2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            

            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

        }

        private void btnAddGroup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfGroup group = new wpfGroup();
                group.ShowDialog();


                group.Hide();
            }
            catch (System.Exception ex)
            {
                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        private void btnSearchGroup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfGroupDetail groupDetail = new wpfGroupDetail();
                groupDetail.ShowDialog();

                groupDetail.Hide();
            }
            catch (System.Exception ex)
            {
                
                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfStudent student = new wpfStudent();
                student.ShowDialog();

                
            }
            catch (System.Exception ex)
            {
                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
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
            catch (Exception ex)
            {
                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnSearchStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfStudentDetail studentDetail = new wpfStudentDetail();
                studentDetail.ShowDialog();
            }
            catch (Exception ex)
            {

                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnAddAssignment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfDescription desc = new wpfDescription();
                desc.ShowDialog();
            }
            catch (Exception ex)
            {

                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnSearchAssignment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfDescDetail descDetail = new wpfDescDetail();
                descDetail.ShowDialog();
            }
            catch (Exception ex)
            {

                //handle error method
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnDataSheet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wpfDataSheet dataSheet = new wpfDataSheet();
                dataSheet.ShowDialog();
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
