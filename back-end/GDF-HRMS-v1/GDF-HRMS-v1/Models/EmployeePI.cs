using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Models
{
    public class EmployeePI
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NId { get; set; }
        public int RId { get; set; }
        public int EId { get; set; }
        public int MId { get; set; }
        public int CId { get; set; }
        public int AId { get; set; }
        public string Title { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Oname { get; set; }
        public int RNumber { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        public int NidNumber { get; set; }
        public string PNumber { get; set; }
        public DateTime PExpirationDate { get; set; }
        public int TinNumber { get; set; }

    }
}
