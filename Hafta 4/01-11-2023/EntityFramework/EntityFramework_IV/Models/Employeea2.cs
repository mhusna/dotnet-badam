using System;
using System.Collections.Generic;

namespace EntityFramework_IV.Models
{
    public partial class Employeea2
    {
        public decimal EmployeeId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public decimal? DeptId { get; set; }

        public virtual Departmentsa1? Dept { get; set; }
    }
}
