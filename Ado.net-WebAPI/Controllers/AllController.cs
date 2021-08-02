using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Ado.net_EF_BAL;
using Ado.net_EF_DTO;
using Newtonsoft.Json;

namespace Ado.net_WebAPI.Controllers
{   
    public class AllController : ApiController
    {
        ProjectXEFBAL BAL;

        [HttpGet]
        [ActionName("GetAllFaculties")]
        public HttpResponseMessage GetFaculties()
        {
            try
            {
                BAL = new ProjectXEFBAL();
                List<FacultyDTO> FaLst = BAL.GetFaculties();
                if (FaLst != null)
                {
                    var res = new HttpResponseMessage(HttpStatusCode.OK);
                    res.Content = new StringContent(JsonConvert.SerializeObject(FaLst));
                    res.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("json");
                    return res;
                }
                else
                {
                    var res = new HttpResponseMessage(HttpStatusCode.NoContent);
                    res.Content = new StringContent("No Table Found");
                    return res;
                }
             
            }
            catch (Exception ex)
            {
                var res = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                res.Content = new StringContent(" SomeThing went wrong");
                return res;
            }
        }

        [HttpGet]
        [ActionName("GetAllCourses")]
        public HttpResponseMessage GetCourses()
        {
            try
            {
                objBAL = new ProjectXEFBAL();
                List<CourseDTO> CourseLst = objBAL.GetCourses();
                if (CourLst != null)
                {
                    var res = new HttpResponseMessage(HttpStatusCode.OK);
                    res.Content = new StringContent(JsonConvert.SerializeObject(CoursLst));
                    res.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application//json");
                    return res;
                }
                else
                {
                    var res = new HttpResponseMessage(HttpStatusCode.NoContent);
                    res.Content = new StringContent("No  Found");
                    return res;
                }

            }
            catch (Exception ex)
            {
                var res = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                res.Content = new StringContent(" SomeThing went wrong");
                return res;
            }
        }
    }
}
