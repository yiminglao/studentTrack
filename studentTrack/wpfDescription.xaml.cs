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
    public partial class wpfDescription : Window
    {

        private clsSQLite Sqlite;

        public SQLquery Query;

        public DescriptionDetail descDetail;

        public wpfDescription()
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

                    DescriptionDetail desc = new DescriptionDetail();
                    desc.date = DescDate.SelectedDate.Value;
                    if(desc.date.Month < 10)
                    {
                        desc.sDate = desc.date.Year.ToString() + "-0" + desc.date.Month.ToString();
                    }
                    else
                    {
                        desc.sDate = desc.date.Year.ToString() + "-" + desc.date.Month.ToString();
                    }
                    if(desc.date.Day <10)
                    {
                        desc.sDate += "-0" + desc.date.Day.ToString();
                    }
                    else
                    {
                        desc.sDate += "-" + desc.date.Day.ToString();
                    }
                    
                    desc.description = tbDesc.Text;

                    desc.name = tbName.Text;

                    if (Int32.TryParse(tbSourceId.Text, out int sourId))
                    desc.sourceId = sourId;

                    Sqlite.ExecuteNonQuery(Query.insertDesc(desc));
                    descDetail = desc;


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
