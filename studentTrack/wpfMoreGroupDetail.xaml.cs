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
    /// Interaction logic for wpfMoreGroupDetail.xaml
    /// </summary>
    public partial class wpfMoreGroupDetail : Window
    {
        clsDataTracker dataTracker;

        private clsSQLite Sqlite;

        public SQLquery Query;

        public int groupId;
        int aId;
        public wpfMoreGroupDetail()
        {
            InitializeComponent();
            Sqlite = new clsSQLite();

            Query = new SQLquery();

            dataTracker = new clsDataTracker();
                       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(dgAssignment.SelectedItem != null)
                {
                    aId = (dgAssignment.SelectedItem as assignmentDetail).assignmentId;
                    dgstudentsScore.ItemsSource = dataTracker.getStudentScoreList(groupId, aId);
                    dgstudentsScore.Items.Refresh();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if(dgstudentsScore.SelectedItem != null)
                {
                    lblSid.Content = (dgstudentsScore.SelectedItem as StudentScoreDetail).studentId;
                    lblFName.Content = (dgstudentsScore.SelectedItem as StudentScoreDetail).FirstName;
                    lblLName.Content = (dgstudentsScore.SelectedItem as StudentScoreDetail).LastName;
                    tbGrade.Text = (dgstudentsScore.SelectedItem as StudentScoreDetail).grade.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                bool isNum = int.TryParse(tbGrade.Text.ToString(), out int grade);
                //float fGrade = grade;
                if(isNum == true && grade >=0 && grade < 4)
                {
                    tbGrade.Text = grade.ToString();
                    int aIndex = (dgstudentsScore.SelectedItem as StudentScoreDetail).gradeIndex;
                   
                    Sqlite.ExecuteNonQuery(Query.updateGrade(aIndex, grade));

                    dgstudentsScore.ItemsSource = dataTracker.getStudentScoreList(groupId, aId);

                    dgstudentsScore.Items.Refresh();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //close window
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
