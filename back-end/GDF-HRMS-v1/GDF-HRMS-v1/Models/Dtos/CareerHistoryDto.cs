using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Models
{
    public class CareerHistoryDto
    {
        [Key]
        public int Id { get; set; }

        public int EId { get; set; }

        public string Position { get; set; }
       
        public string Department { get; set; }
       
        
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}