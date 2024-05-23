using System.ComponentModel.DataAnnotations;

namespace HRManagement.Models
{
    public class Employee
    {
        [Key] //<----------- This one
        public int Emp_Id { get; set; }//<---

        public string Emp_Name { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }
        public string Designation { get; set; }
        public string Salary { get; set; }


    }
}
