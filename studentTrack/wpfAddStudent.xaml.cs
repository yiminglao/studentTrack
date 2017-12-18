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
    /// Interaction logic for wpfAddStudent.xaml
    /// </summary>
    public partial class wpfAddStudent : Window
    {
        public GroupDetail GroupList;

        private clsSQLite Sqlite;

        public SQLquery Query;

        clsDataTracker dataTracker;

        public int groupID = wpfDataSheet.groupID;

        public string groupName = wpfDataSheet.groupName;

        public int addstudentnum;

        public int addgroupNum;

        public int delstudentnum;

        public int delgroupNum;

        public bool editing = false;

        public wpfAddStudent()
        {
            Sqlite = new clsSQLite();

            Query = new SQLquery();

            dataTracker = new clsDataTracker();


            InitializeComponent();

            lblGroup.Content = groupName;
            dgAllStudents.ItemsSource = dataTracker.makeStudentList();
            dgStudentsInGroup.ItemsSource = dataTracker.getGroupStudents(groupID.ToString());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Sqlite.ExecuteNonQuery(Query.addStudentToGroup(addstudentnum, addgroupNum));

            dgStudentsInGroup.ItemsSource = dataTracker.getGroupStudents(groupID.ToString());

            dgStudentsInGroup.Items.Refresh();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            editing = true;
            Sqlite.ExecuteNonQuery(Query.removeStudentFromGroup(delstudentnum, delgroupNum));

            dgStudentsInGroup.ItemsSource = dataTracker.getGroupStudents(groupID.ToString());

            dgStudentsInGroup.Items.Refresh();
            editing = false;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void dgAllStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            StudentDetail group = (StudentDetail)dgAllStudents.SelectedItem;
               
            addstudentnum = group.index;
            addgroupNum = groupID; 
            
        }

        private void dgStudentsInGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (editing) { }
            else
            {
                StudentGroupList dgroup = (StudentGroupList)dgStudentsInGroup.SelectedItem;

                //delstudentnum = dgroup.studentID;
                delgroupNum = groupID;
            }
        }

    }
}
