using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroup2
{
    public class SQLquery
    {
        public string getDescData()
        {
            return "SELECT * FROM Assignment;";

        }

        public string getStudentData()
        {
            return "SELECT * FROM Student";
        }

        public string insertDesc(DescriptionDetail descDetail)
        {

            //string dt = DateTime.Parse(descDetail.date).ToString("yyyy-MM-dd");
            //descDetail.date = descDetail.date.ToString("yyyy-MM-dd");
            return "INSERT INTO Assignment (Name,Source_id, Description,CreationDate) " +
               "VALUES ('"+ descDetail.name + "', " + descDetail.sourceId + ", '"  + descDetail.description + "', '" + descDetail.sDate + "');";

            //INSERT INTO "main"."Assignment"("Name", "Source_id", "Description", "CreationDate") VALUES('asdfsadf', 2, 'asdfsadfsdf', '2017-8-1')
        }

        public string insertStudent(StudentDetail student)
        {
            return "INSERT INTO Student (StudentId,FirstName,LastName,GradeLevel,Educator_id)" +
                "VALUES (" + student.studentId + ",'" + student.firstName + "','" + student.lastName + "'," + student.gradeLevel + "," + student.educatorId + ");";
        }
        public string UpdateStudent(StudentDetail student)
        {
            return "UPDATE Student SET FirstName = '" + student.firstName + "', LastName = '" + student.lastName+ "', StudentId = " + student.studentId + ", GradeLevel = " + student.gradeLevel + ",Educator_id= " + student.gradeLevel + " WHERE(_id =" + student.index + ");";

        }
        public string getMaxIndex()
        {

            return "SELECT MAX(_id) FROM Student;";
        }

        public string delStudent(int studentId)
        {
            return "DELETE FROM [Student] " +
                    "WHERE StudentId = " + studentId + ";";
        }

        public string delGroup(int id)
        {
            return "DELETE FROM ClassGroup WHERE _id = " + id + ";";
        }

        public string delDesc(int id)
        {
            return "DELETE FROM Assignment WHERE _id = " + id + ";";
        }

        public string updateDesc(DescriptionDetail detail)
        {
            return "UPDATE Assignment SET Name = '"+ detail .name + "', Source_id = " + detail.sourceId  +", Description = '" + detail.description + "',CreationDate= '" + detail.sDate + "' WHERE(_id =" + detail.DescId + ");";
        }

        public string getGroupList()
        {
            return "Select Name, StartDate,ScheduledTimeStart,Description, _id From ClassGroup";
        }

        public string insertGroup(GroupDetail group)
        {
            return "INSERT INTO ClassGroup (Name,StartDate,ScheduledTimeStart,Description)" +
                "VALUES ('" + group.groupName + "', '" + group.groupSStartDate + "','" + group.groupStartTime + "', '" + group.groupDesc + "');";
        }

        public string UpdateGroup(GroupDetail group)
        {
            return "UPDATE ClassGroup SET Name = '" + group.groupName + "', StartDate ='" + group.groupSStartDate + "'," +
                "ScheduledTimeStart ='" + group.groupStartTime + "', Description = '" + group.groupDesc + "' WHERE (_id = " + group.groupID + ");";      
        }

        public string getGroupStudents(string groupID)
        {
            return "select s.FirstName, s.LastName, a.Assignment_id, gd.Grade " +
            "from Student s inner join GroupStudentMember m on s.StudentId = m.Student_id " +
            "inner join ClassGroup g on m.Group_id = g._id " +
            "inner join GroupAssignment a on m.Group_id = a.Group_id " +
            "inner join StudentAssignmentGrade gd on s.StudentId = gd.Student_id  " +
            "Where g.Name = '" + groupID + "';";
        }

        public string getGroupAssignments(string groupID)
        {
            return "select a._id, a.CreationDate, a.Name " +
            "from Assignment a inner join GroupAssignment ga on a._id = ga.Assignment_id " +
            "inner join ClassGroup g on ga.Group_id = g._id " +
            "Where g.Name = '" + groupID + "';";
        }

        public string getGAssignments(int groupID)
        {
            return "SELECT ga.Group_id, ga.Assignment_id, ga.AssignmentDate, a.Name, a.Description FROM " +
                    "GroupAssignment ga JOIN Assignment a ON ga.Assignment_id = a.'_id'" +
                    "WHERE ga.Group_id =  " + groupID;

            
        }

        public string getStudentGradeBygidaid(int groupId, int assignmentId)
        {
            return "SELECT ga.Group_id, ga.Assignment_id, sa.Student_id, st.FirstName, st.LastName, sa.Grade, sa.'_id' FROM "
                    + "GroupAssignment ga JOIN StudentAssignmentGrade sa ON ga.Assignment_id = sa.GroupAssignment_id " +
                    " JOIN Student st ON st.'_id' = sa.Student_id " +
                    "WHERE ga.Group_id = " + groupId + " AND ga.Assignment_id = " + assignmentId + ";";
        }

        public string updateGrade(int index, int grade)
        {
            return "UPDATE StudentAssignmentGrade SET Grade = " + grade + " WHERE _id = " + index + ";";
        }

        public string addStudentToGroup(int studentID, int groupID)
        {
            return "INSERT INTO GroupStudentMember (Student_id, Group_id)" +
                "VALUES (" + studentID + ", " + groupID + ");";
        }

        public string removeStudentFromGroup(int studentID, int groupID)
        {
            return "Delete From GroupStudentMember Where Student_id = " + studentID + " and Group_id = " + groupID + ";";
        }

    }
}
