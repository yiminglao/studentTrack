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

namespace ProjectGroup2
{
    /// <summary>
    /// Interaction logic for addStudentWPF.xaml
    /// </summary>
    public partial class wpfStudent : Window
    {
        public StudentDetail StudentList;

        private clsSQLite Sqlite;

        public SQLquery Query;

        int maxId;

        public wpfStudent()
        {
            InitializeComponent();

            Sqlite = new clsSQLite();
            Query = new SQLquery();

            if (int.TryParse(Sqlite.ExecuteScalarSQL(Query.getMaxIndex()).ToString(), out int mId))
                maxId = mId + 1 ;
            tbSId.IsEnabled = false;
            tbSId.Text = maxId.ToString();
        }

     

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(tbFName.Text != null && tbLName.Text != null)
            {
                StudentList = new StudentDetail();
                if(int.TryParse(tbSId.Text.ToString(), out int SId)) 
                    StudentList.studentId = SId;
                StudentList.firstName = tbFName.Text;
                StudentList.lastName = tbLName.Text;
                if (int.TryParse(tbEId.Text.ToString(), out int EId))
                    StudentList.educatorId = EId;
                if (int.TryParse(tbGLevel.Text.ToString(), out int gLvl))
                    StudentList.gradeLevel = gLvl;
                StudentList.sFullName =   tbLName.Text.ToString() + "," + tbFName.Text.ToString();

                Sqlite.ExecuteNonQuery(Query.insertStudent(StudentList));

                Close();
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
            catch (System.Exception ex)
            {
                //output error log to file
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }
    }
}
