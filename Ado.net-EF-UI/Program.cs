using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.net_EF_DTO;
using Ado.net_EF_BAL;

namespace Ado.net_EF_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectXEFBAL obj = new ProjectXEFBAL();
            /*var output = obj.GetFaculties();
             foreach (var item in output)
             {
                 Console.WriteLine(item.NAME);
             }*/

            //********INSERT**********
            /*Console.WriteLine("Enter PSNo:");
            int inputPSNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email ID:");
            string inputEmailID = Console.ReadLine();
            Console.WriteLine("Enter Full Name:");
            string inputName = Console.ReadLine();
            FacultyDTO facObj = new FacultyDTO
            {
                PSNo = inputPSNo,
                EmailId = inputEmailID,
                NAME = inputName
            };

            int returnValue = obj.AddNewFaculty(facObj);

            if (returnValue == 1)
            {
                Console.WriteLine("Data Added Successfully");
                Console.WriteLine("List of Faculties");
                Console.WriteLine("------------------------");
                var output = obj.GetFaculties();
                foreach (var item in output)
                {
                    Console.WriteLine(item.NAME);
                }
            }
            else
            {
                Console.WriteLine("Oopppssiiiee, Something went wrong ! ");
            }*/


            //********UPDATE*****
            Console.WriteLine("Enter PSNo:");
            int inputPSNo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string inputName1 = Console.ReadLine();
            FacultyDTO facObj1 = new FacultyDTO
            {
                PSNo = inputPSNo1,
                NAME = inputName1
            };

            int returnValue1 = obj.UpdateFaculty(facObj1);

            if (returnValue1 == 1)
            {
                Console.WriteLine("Data Updated Successfully");
                Console.WriteLine("List of Faculties");
                Console.WriteLine("------------------------");
                var output = obj.GetFaculties();
                foreach (var item in output)
                {
                    Console.WriteLine(item.NAME);
                }
            }
            else
            {
                Console.WriteLine("Oopppssiiiee, Something went wrong ! ");
            }


            //******DELETE********
          /*  Console.WriteLine("Enter PSNo:");
            int inputPSNo = Convert.ToInt32(Console.ReadLine());
           
            FacultyDTO facObj = new FacultyDTO
            {
                PSNo = inputPSNo
            };

            int returnValue = obj.DeleteFaculty(facObj);

            if (returnValue == 1)
            {
                Console.WriteLine("Data Deleted Successfully");
                Console.WriteLine("List of Faculties");
                Console.WriteLine("------------------------");
                var output = obj.GetFaculties();
                foreach (var item in output)
                {
                    Console.WriteLine(item.NAME);
                }
            }
            else
            {
                Console.WriteLine("Oopppssiiiee, Something went wrong ! ");
            }*/
        }
    }
}
