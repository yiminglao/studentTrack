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
    /// Interaction logic for wpfGroupDetail.xaml
    /// </summary>
    public partial class wpfGroupDetail : Window
    {
        clsDataTracker dataTracker;

        private clsSQLite Sqlite;

        public SQLquery Query;

        public int index;
        public wpfGroupDetail()
        {
            InitializeComponent();

            Sqlite = new clsSQLite();

            Query = new SQLquery();

            dataTracker = new clsDataTracker();



            dgGroupList.ItemsSource = dataTracker.makeGroupList();
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
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


        private void btnEditGroup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                wpfGroupUpdate updateGroup = new wpfGroupUpdate();
                updateGroup.index = (dgGroupList.SelectedItem as GroupDetail).groupID;

                updateGroup.ShowDialog();

                dgGroupList.ItemsSource = dataTracker.makeGroupList();

                dgGroupList.Items.Refresh();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDelGroup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult result;
                //prompt message box and hold result
                result = MessageBox.Show("Are you suer want to delete?", "confirm", MessageBoxButton.YesNo);

                if (dgGroupList.SelectedItem != "" && result == MessageBoxResult.Yes)
                {

                    int gid = (dgGroupList.SelectedItem as GroupDetail).groupID;

                    Sqlite.ExecuteNonQuery(Query.delGroup(gid));

                    dgGroupList.ItemsSource = dataTracker.makeGroupList();

                    dgGroupList.Items.Refresh();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGroupDetail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(dgGroupList.SelectedItem != null)
                {
                    int index = (dgGroupList.SelectedItem as GroupDetail).groupID;
                    wpfMoreGroupDetail moreDetail = new wpfMoreGroupDetail();
                    moreDetail.groupId = index;
                    moreDetail.dgAssignment.ItemsSource = dataTracker.getAssignmentList(index);
                    moreDetail.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
