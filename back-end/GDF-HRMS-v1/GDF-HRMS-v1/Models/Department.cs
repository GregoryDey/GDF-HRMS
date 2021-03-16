using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public EmployeePI EmployeePI { get; set; }

        // public ICollection<EmployeePI> EmployeePIs { get; set; }
    }
}
