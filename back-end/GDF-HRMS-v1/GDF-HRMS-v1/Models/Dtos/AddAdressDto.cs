using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GDF_HRMS_v1.Models;


namespace GDF_HRMS_v1.Models
{
    public class AddAddressDto
    {

        public AddAddressDto()
        {
            //Region = new Region();
            //Country = new Country();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Lot { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string Village { get; set; }
        public int Reg { get; set; }
      //  [ForeignKey("Reg")]
      //  public Region Region { get; set; }
        public int Ctry { get; set; }
     //   [ForeignKey("Ctry")]
     //   public Country Country { get; set; }

        public int? EId { get; set; }
      //  [ForeignKey("EId")]
      //  public EmployeePI EmployeePI { get; set; }


        // public ICollection<EmployeePI> EmployeePIs { get; set; }
        // public ICollection<Region> Regions { get; set; }
    }
}
