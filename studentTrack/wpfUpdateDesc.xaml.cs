using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Reflection;

namespace ProjectGroup2
{
    /// <summary>
    /// Interaction logic for wpfDescription.xaml
    /// </summary>
    public partial class wpfUpdateDesc : Window
    {

        private clsSQLite Sqlite;

        public SQLquery Query;

        public DescriptionDetail descDetail;

        public wpfUpdateDesc()
        {
            InitializeComponent();

            Sqlite = new clsSQLite();
            Query = new SQLquery();



        }



        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (tbDesc.Text != "" && DescDate != null)
                {

                   
                    descDetail.date = DescDate.SelectedDate.Value;
                    if (descDetail.date.Month < 10)
                    {
                        descDetail.sDate = descDetail.date.Year.ToString() + "-0" + descDetail.date.Month.ToString();
                    }
                    else
                    {
                        descDetail.sDate = descDetail.date.Year.ToString() + "-" + descDetail.date.Month.ToString();
                    }
                    if (descDetail.date.Day < 10)
                    {
                        descDetail.sDate += "-0" + descDetail.date.Day.ToString();
                    }
                    else
                    {
                        descDetail.sDate += "-" + descDetail.date.Day.ToString();
                    }

                    descDetail.description = tbDesc.Text;

                    

                    descDetail.name = tbName.Text;

                    if (Int32.TryParse(tbSourceId.Text, out int sourId))
                        descDetail.sourceId = sourId;

                    Sqlite.ExecuteNonQuery(Query.updateDesc(descDetail));
                    


                    this.Hide();
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
            try
            {
                this.Hide();
            }
            catch (Exception ex)
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
                //output error log to file
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }
    }
}
