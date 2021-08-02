using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.net_EF_DAL;
using Ado.net_EF_DTO;

namespace Ado.net_EF_BAL
{
    public class ProjectXEFBAL
    {
        ProjectXEFDAL obj;
        public ProjectXEFBAL()
        {
            obj = new ProjectXEFDAL();

        }
        public List<FacultyDTO> GetFaculties()
        {
            var facList = obj.GetFaculties();
            return facList;
        }
        public List<CourseDTO> GetCourses()
        {
            var CourseList = obj.GetCourses();
            return CourseList;
        }
        public int AddNewFaculty(FacultyDTO newFacDetails)
        {
            int returnvalue = obj.AddNewFaculty(newFacDetails);
            return returnvalue;
        }
        public int UpdateFaculty(FacultyDTO newFacDetails)
        {
            int returnvalue = obj.UpdateFaculty(newFacDetails);
            return returnvalue;
        }
        public int DeleteFaculty(FacultyDTO FacID)
        {
            int returnvalue = obj.DeleteFaculty(FacID);
            return returnvalue;
        }
    }
}
