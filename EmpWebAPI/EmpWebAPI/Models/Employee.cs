using System;
using System.Collections.Generic;

namespace EmpWebAPI.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string EmpCode { get; set; }
        public string Mobile { get; set; }
        public string Position { get; set; }
    }
}
