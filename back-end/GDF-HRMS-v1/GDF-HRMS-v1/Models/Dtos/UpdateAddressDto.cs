using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Models.Dtos
{
    public class UpdateAddressDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Lot { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string Village { get; set; }
        public int CountryId { get; set; }
        public int RegionId { get; set; }
        public int EmployeeId { get; set; }
    }
}
