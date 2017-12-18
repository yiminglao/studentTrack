using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjectGroup2
{
    /// <summary>
    /// Interaction logic for wpfGroup.xaml
    /// </summary>
    public partial class wpfGroup : Window
    {

        public GroupDetail GroupList;

        private clsSQLite Sqlite;

        public SQLquery Query;

        clsDataTracker dataTracker;

        /// <summary>
        /// array for hours in school day
        /// </summary>
        int[] hours = new int[] { 7, 8, 9, 10, 11, 12, 1, 2, 3 };

        ///array for minutes in school schedule
        int[] minutes = new int[] { 00, 15, 30, 45 };
        /// <summary>
        /// datetime object to hold the date
        /// </summary>
        DateTime Date;

        /// <summary>
        /// string to hold group name
        /// </summary>
        string groupName = "";

        /// <summary>
        /// string to hold time schedule hours
        /// </summary>
        string scheduleHours = "";

        /// <summary>
        /// string to hold time schedule minutes
        /// </summary>
        string scheduleMins = "";

        /// <summary>
        /// string to hold Subject
        /// </summary>
        string subject = "";

        public wpfGroup()
        {
            Sqlite = new clsSQLite();

            Query = new SQLquery();

            dataTracker = new clsDataTracker();

            InitializeComponent();
            FocusManager.SetFocusedElement(this, txtGroupName);
            dteDate.SelectedDate = DateTime.Today;
            for (int i = 0; i < hours.Length; i++)
                cboxHour.Items.Add(hours[i]);
            for (int i = 0; i < minutes.Length; i++)
                cboxMin.Items.Add(minutes[i]);
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

        }


        /// <summary>
        /// on click "clear" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntClear_Click(object sender, RoutedEventArgs e)
        {
            resetBoard();
            Keyboard.Focus(txtGroupName);
            dteDate.SelectedDate = DateTime.Today;
        }

        /// <summary>
        /// on click "save" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            GroupList = new GroupDetail();
            GroupList.groupName = txtGroupName.Text;
            GroupList.groupStartDate = dteDate.SelectedDate.Value;

            if (GroupList.groupStartDate.Month < 10)
            {
                GroupList.groupSStartDate = GroupList.groupStartDate.Year.ToString() + "-0" + GroupList.groupStartDate.Month.ToString();
            }
            else
            {
                GroupList.groupSStartDate = GroupList.groupStartDate.Year.ToString() + "-" + GroupList.groupStartDate.Month.ToString();
            }
            if (GroupList.groupStartDate.Day < 10)
            {
                GroupList.groupSStartDate += "-0" + GroupList.groupStartDate.Day.ToString();
            }
            else
            {
                GroupList.groupSStartDate += "-" + GroupList.groupStartDate.Day.ToString();
            }


            GroupList.groupDesc = txtSubject.Text;
            GroupList.groupStartTime = scheduleHours + ":" + scheduleMins;
            Sqlite.ExecuteNonQuery(Query.insertGroup(GroupList));

            Close();
        }

        /// <summary>
        /// clear board
        /// </summary>
        private void resetBoard()
        {
            dteDate.Text = DateTime.Now.Date.ToString();
            /// txtDate.Text = "";
            txtGroupName.Text = "";
            // txtSchedule.Text = "";
            txtSubject.Text = "";
        }


      

        private void cboxHour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            scheduleHours = cboxHour.SelectedItem.ToString();
        }

        /// <summary>
        /// choose the quarter-hour the lesson starts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxMin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            scheduleMins = cboxMin.SelectedItem.ToString();
        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //hide the window
            this.Hide();
            //stop app to actruly close window
            e.Cancel = true;
        }
    }
}
