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
    /// Interaction logic for wpfDataSheet.xaml
    /// </summary>
    public partial class wpfDataSheet : Window
    {
        clsDataTracker dataTracker;

        private clsSQLite Sqlite;

        public SQLquery Query;

        public static string groupName;
        public static int groupID;
        public wpfDataSheet()
        {
            Sqlite = new clsSQLite();

            Query = new SQLquery();
            dataTracker = new clsDataTracker();

            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;




            //dgDesc.ItemsSource = dataTracker.makeDescriptionList();

            //  dgLesson.ItemsSource = dataTracker.makeStudentList();

            dataTracker.makeGroupList();
            for (int i = 0; i < dataTracker.groupList.Count; i++)
            {
                comboxGroup.Items.Add(dataTracker.groupList[i].groupName);
            }
        }

        private void comboxGroup_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            lblSubject.Content = dataTracker.groupList[comboxGroup.SelectedIndex].groupDesc;
            lblDateRange.Content = dataTracker.groupList[comboxGroup.SelectedIndex].groupSStartDate;
            lblTime.Content = dataTracker.groupList[comboxGroup.SelectedIndex].groupStartTime;

            groupName = dataTracker.groupList[comboxGroup.SelectedIndex].groupName;
            groupID = dataTracker.groupList[comboxGroup.SelectedIndex].groupID;
            dgLesson.ItemsSource = dataTracker.getGroupStudents(groupID.ToString());
            dgDesc.ItemsSource = dataTracker.getGroupAssignments(groupID.ToString());

            dgLesson.Items.Refresh();
            dgDesc.Items.Refresh();

            btnAddStudent.IsEnabled = true;
            btnAddAssignment.IsEnabled = true;
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            wpfAddStudent addStudents = new wpfAddStudent();
            addStudents.ShowDialog();
            dgLesson.ItemsSource = dataTracker.getGroupStudents(groupID.ToString());
            dgLesson.Items.Refresh();
        }

        private void btnAddAssignment_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
