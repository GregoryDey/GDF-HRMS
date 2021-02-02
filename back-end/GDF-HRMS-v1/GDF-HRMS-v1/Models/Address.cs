using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Lot { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string Village { get; set; }
        public int Region { get; set; }
        public int Country { get; set; }
    }
}
