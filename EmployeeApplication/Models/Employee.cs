using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeApplication.Models
{
    public class Employee
    {
        public Int32 ID { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")] 
        public DateTime DateOfBirth { get; set; }
        public Int32 Salary { get; set; }
    }
}