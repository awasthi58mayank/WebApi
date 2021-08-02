using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.net_EF_DTO;
namespace Ado.net_EF_DAL
{
    public class ProjectXEFDAL
    {
        public ProjectXEFDAL()
        {
           
        }
        public List<FacultyDTO> GetFaculties()
        {
            try
            {
                List<FacultyDTO> lstFaculty = new List<FacultyDTO>();
                ProjectXConStr  objContext = new ProjectXConStr();
                var facDALListObj = objContext.Faculties.ToList();
                foreach (var item in facDALListObj)
                {
                    lstFaculty.Add(
                        new FacultyDTO
                        {
                            PSNo=item.PSNo,
                            EmailId=item.EmailId,
                            NAME=item.NAME

                        });
                }
                return lstFaculty;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooopppss, Something went Wrong!");
                throw ex;
            }
        }
        public List<CourseDTO> GetCourses()
        {
            try
            {
                List<CourseDTO> lstCourse = new List<CourseDTO>();
                ProjectXConStr objContext = new ProjectXConStr();
                var CourseDALListObj = objContext.Courses.ToList();
                foreach (var item in CourseDALListObj)
                {
                    lstCourse.Add(
                        new CourseDTO
                        {
                            CourseID = item.CourseID,
                            CourseTitle = item.CourseTitle,
                            NoOfHours=item.NoOfHours,
                            CourseOwner_ID=item.CourseOwner_ID

                        });
                }
                return lstCourse;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooopppss, Something went Wrong!");
                throw ex;
            }
        }
        public int AddNewFaculty(FacultyDTO newFacObj)
        {
            int ret = 0;
            try
            {
                using (var objContext = new ProjectXConStr())
                {
                    Faculty facDALObj = new Faculty();
                    facDALObj.PSNo = newFacObj.PSNo;
                    facDALObj.EmailId = newFacObj.EmailId;
                    facDALObj.NAME = newFacObj.NAME;
                    objContext.Faculties.Add(facDALObj);
                    ret = objContext.SaveChanges();
                    return ret;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooopppss, Something went Wrong!");
                throw ex;
            }
        }
        public int UpdateFaculty(FacultyDTO newFacObj)
        {
            int ret = 0;
            try
            {
                using (var objContext = new ProjectXConStr())
                {
                    Faculty facDALObj = objContext.Faculties.Find(newFacObj.PSNo);
                    if (facDALObj != null)
                    {
                        objContext.Faculties.Attach(facDALObj);
                        facDALObj.NAME = newFacObj.NAME;
                        ret = objContext.SaveChanges();
                        return ret;
                    }
                    else
                    {
                        Console.WriteLine("User does not exist!");
                        return 0;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooopppss, Something went Wrong!");
                return 0;
            }
        }
        public int DeleteFaculty(FacultyDTO FacObj)
        {
            int ret = 0;
            try
            {
                using (var objContext = new ProjectXConStr())
                {
                    Faculty facDALObj = objContext.Faculties.Find(FacObj.PSNo);
                    if (facDALObj != null)
                    {
                        facDALObj.PSNo = FacObj.PSNo;
                        objContext.Faculties.Remove(facDALObj);
                        ret = objContext.SaveChanges();
                        return ret;
                    }
                    else
                    {
                        Console.WriteLine("User does not exist!");
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooopppss, Something went Wrong!");
                return 0;
            }
        }
    }
}
