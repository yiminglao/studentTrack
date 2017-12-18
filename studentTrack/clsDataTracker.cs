using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectGroup2
{
    public class clsDataTracker
    {
        private clsSQLite Sqlite;

        public SQLquery Query;

        public int index;

        public List<assignmentDetail> assignmentList;
     

        public List<DescriptionDetail> descList;

        public List<StudentDetail> StudentList;

        public List<GroupDetail> groupList;

        

        public List<StudentGroupList> sGroupList;

        public List<GroupAssignmentList> gpAList;

        public List<StudentScoreDetail> studentScore;

        public clsDataTracker()
        {
            Sqlite = new clsSQLite();
            Query = new SQLquery();
            descList = new List<DescriptionDetail>();
            StudentList = new List<StudentDetail>();
            groupList = new List<GroupDetail>();
            sGroupList = new List<StudentGroupList>();
            gpAList = new List<GroupAssignmentList>();

            studentScore = new List<StudentScoreDetail>();
        }

        public void updateStudentGrade(int index, int grade)
        {
            Sqlite.ExecuteNonQuery(Query.updateGrade(index, grade));
        }

        public List<StudentScoreDetail> getStudentScoreList(int groupId, int assignmentId)
        {

            studentScore.Clear();
            int retVal = 0;
            DataSet ds = Sqlite.ExecuteSQLStatement(Query.getStudentGradeBygidaid(groupId, assignmentId), ref retVal);

            for (int i = 0; i < retVal; i++)
            {
                StudentScoreDetail Temp = new StudentScoreDetail();
                //group ID
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[0].ToString(), out int gid))
                    Temp.groupId = gid;

                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[1].ToString(), out int aid))
                    Temp.assignmentId = aid;

                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[2].ToString(), out int sid))
                    Temp.studentId = sid;

                //student name
                Temp.FirstName = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                //student name
                Temp.LastName = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                //grade
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[5].ToString(), out int grade))
                    Temp.grade = grade;

                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[6].ToString(), out int gIndex))
                    Temp.gradeIndex = gIndex;

                //add to list
                studentScore.Add(Temp);

            }


            return studentScore;
        }

        public void addDescList(DescriptionDetail desc)
        {
            descList.Add(desc);
        }

        public void addStudent(StudentDetail student)
        {
            StudentList.Add(student);
        }

        public void addGroupList(GroupDetail gp)
        {
            groupList.Add(gp);
        }

        public void addStudentGroupList(StudentGroupList sgl)
        {
            sGroupList.Add(sgl);
        }

        public void addGroupAssignmentList(GroupAssignmentList gal)
        {
            gpAList.Add(gal);
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

        /// <summary>
        /// this is function to make Description List from database
        /// </summary>
        /// <returns>list of DescriptionDetail</returns>
        public List<DescriptionDetail> makeDescriptionList()
        {
            List<DescriptionDetail> descList = new List<DescriptionDetail>();
            int retVal = 0;
            DataSet ds = Sqlite.ExecuteSQLStatement(Query.getDescData(), ref retVal);

            for (int i = 0; i < retVal; i++)
            {
                DescriptionDetail descTemp = new DescriptionDetail();
                //Description ID
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[0].ToString(), out int id))
                    descTemp.DescId = id;
                //description name
                descTemp.name = ds.Tables[0].Rows[i].ItemArray[1].ToString();

                //source id
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[2].ToString(), out int sourceId))
                    descTemp.sourceId = sourceId;
                //description
                descTemp.description = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                //create date
                descTemp.sDate = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                //add to list
                descList.Add(descTemp);

            }

            return descList;
        }


        public List<StudentDetail> makeStudentList()
        {
            List<StudentDetail> tempStudentList = new List<StudentDetail>();
            int retVal = 0;
            DataSet ds = Sqlite.ExecuteSQLStatement(Query.getStudentData(), ref retVal);


            for (int i = 0; i < retVal; i++)
            {
                StudentDetail temp = new StudentDetail();
                //index
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[0].ToString(), out int index))
                temp.index = index;
                //studnet Id
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[1].ToString(), out int sId))
                temp.studentId = sId;
                //studnet first name
                temp.firstName = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                //student last name
                temp.lastName = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                //gradeLevel
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[4].ToString(), out int gradeLevel))
                    temp.gradeLevel = gradeLevel;
                //educator Id
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[4].ToString(), out int educatorId))
                    temp.educatorId = educatorId;

                temp.sFullName = temp.lastName.ToString() + "," + temp.firstName.ToString();

                tempStudentList.Add(temp);
            }


            return tempStudentList;
        }


        /// <summary>
        /// this is a function to make a Group List from database
        /// </summary>
        /// <returns>list of DescriptionDetail</returns>
        public List<GroupDetail> makeGroupList()
        {
            groupList.Clear();
            List<GroupDetail> tempGroupList = new List<GroupDetail>();
            int retVal = 0;
            DataSet ds = Sqlite.ExecuteSQLStatement(Query.getGroupList(), ref retVal);

            for (int i = 0; i < retVal; i++)
            {
                GroupDetail gpTemp = new GroupDetail();
                //Group ID
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[4].ToString(), out int id))
                gpTemp.groupID = id;
                //Group name
                gpTemp.groupName = ds.Tables[0].Rows[i].ItemArray[0].ToString();

                //start date
                // gpTemp.groupStartDate.Equals(ds.Tables[0].Rows[i].ItemArray[2]);
                gpTemp.groupSStartDate = ds.Tables[0].Rows[i].ItemArray[1].ToString();

                //start time
                gpTemp.groupStartTime = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                //description
                gpTemp.groupDesc = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                //add to list
                groupList.Add(gpTemp);

            }

            return groupList;
        }

        public List<GroupDetail> getGroupStudents(string groupID)
        {
            sGroupList.Clear();
            List<StudentGroupList> tempGroupList = new List<StudentGroupList>();
            int retVal = 0;
            DataSet ds = Sqlite.ExecuteSQLStatement(Query.getGroupStudents(groupID), ref retVal);

            for (int i = 0; i < retVal; i++)
            {
                StudentGroupList groupList = new StudentGroupList();
                //Group ID
                // if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[0].ToString(), out int id))
                //    gpTemp.groupID = id;

                //First name
                groupList.firstName = ds.Tables[0].Rows[i].ItemArray[0].ToString();

                //Last name
                groupList.lastName = ds.Tables[0].Rows[i].ItemArray[1].ToString();

                //assignment number
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[2].ToString(), out int assignmentNum))
                    groupList.assignmentNum = assignmentNum;

                //grade
                if (float.TryParse(ds.Tables[0].Rows[i].ItemArray[3].ToString(), out float grade))
                    groupList.grade = grade;

                //add to list
                tempGroupList.Add(groupList);

            }

            return groupList;
        }

        /// <summary>
        /// this is function to make group assignment list from database
        /// </summary>
        /// <returns>list of DescriptionDetail</returns>
        public List<GroupAssignmentList> getGroupAssignments(string groupID)
        {
            gpAList.Clear();
            List<GroupAssignmentList> groupAssignmentList = new List<GroupAssignmentList>();
            int retVal = 0;
            DataSet ds = Sqlite.ExecuteSQLStatement(Query.getGroupAssignments(groupID), ref retVal);

            for (int i = 0; i < retVal; i++)
            {
                GroupAssignmentList assignmentList = new GroupAssignmentList();
                //Description ID
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[0].ToString(), out int id))
                    assignmentList.DescId = id;

                //create date
                assignmentList.sDate = ds.Tables[0].Rows[i].ItemArray[1].ToString();

                //description name
                assignmentList.name = ds.Tables[0].Rows[i].ItemArray[2].ToString();



                //add to list
                groupAssignmentList.Add(assignmentList);

            }

            return groupAssignmentList;
        }



        public List<assignmentDetail> getAssignmentList(int id)
        {
            assignmentList = new List<assignmentDetail>();

            int retVal = 0;

            DataSet ds = Sqlite.ExecuteSQLStatement(Query.getGAssignments(id), ref retVal);

            for (int i = 0; i < retVal; i++)
            {
                assignmentDetail temp = new assignmentDetail();
                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[0].ToString(), out int index))
                    temp.groupId = index;

                if (int.TryParse(ds.Tables[0].Rows[i].ItemArray[1].ToString(), out int sId))
                    temp.assignmentId = sId;

                temp.createDate = ds.Tables[0].Rows[i].ItemArray[2].ToString();

                temp.name = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                temp.desc = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                assignmentList.Add(temp);
            }

            return assignmentList;
        }
    }

        


    public class assignmentDetail
    {
        public int groupId { get; set; }

        public int assignmentId { get; set; }

        public string createDate { get; set; }

        public string name { get; set; }

        public string desc { get; set; }
    }


    public class DescriptionDetail
    {
        public int DescId { get; set; }

        public int sourceId { get; set; }

        public string name { get; set; }

        public string sDate { get; set; }

        public DateTime date { get; set; }

        public string description { get; set; }


    }


    public class StudentDetail
    {

        public int index { get; set; }
        public int studentId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }

        public string sFullName { get; set; }
        public int gradeLevel { get; set; }
        public int educatorId { get; set; }

    }

    public class GroupDetail
    {
        public int groupID { get; set; }
        public string groupName { get; set; }
        public string groupSStartDate { get; set; }
        public DateTime groupStartDate { get; set; }
        public string groupStartTime { get; set; }
        public string groupDesc { get; set; }
    }

    public class StudentGroupList
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int assignmentNum { get; set; }
        public float grade { get; set; }
    }

    public class GroupAssignmentList
    {
        public int DescId { get; set; }
        public string sDate { get; set; }
        public string name { get; set; }
    }

    public class StudentScoreDetail
    {
        public int groupId { get; set; }

        public int assignmentId { get; set; }

        public int studentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int grade { get; set; }

        public int gradeIndex { get; set; }
    }

}
