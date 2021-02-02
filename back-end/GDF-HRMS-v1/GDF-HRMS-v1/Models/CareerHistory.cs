using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Models
{
    public class CareerHistory
    {
        [Key]
        public int Id { get; set; }
        public int EId { get; set; }
        public int PositionId { get; set; }
        public int DeptId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
