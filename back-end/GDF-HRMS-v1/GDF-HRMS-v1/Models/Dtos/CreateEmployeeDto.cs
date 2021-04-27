using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Models
{
    public class CreateEmployeeDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NationalityId { get; set; }
        // [ForeignKey("NId")]
        // public Nationality Nationality { get; set; }
        //public string Nationality { get; set; }
        public int ReligionId { get; set; }
        // [ForeignKey("RId")]
        //public Religion Religion { get; set; }

        // public string Religion { get; set; }
        public int EthnicityId { get; set; }
        // [ForeignKey("EId")]
        // public Ethnicity Ethnicity { get; set; }
        //public string Ethnicity { get; set; }
        public int MaritalStatusId { get; set; }
        //  [ForeignKey("MId")]
        //  public MaritalStatus MaritalStatus { get; set; }

        //public string MaritalStatus { get; set; }

        //public string Position { get; set; }
       // public int PositionId { get; set; }

        //public string Country { get; set; }
       // public int CountryId { get; set; }
        // [ForeignKey("CId")]

       // public int RegionId { get; set; }
        // public ContactInfo ContactInfo { get; set; }

      //  public int DepartmentId { get; set; }
        public int HomeNumber { get; set; }
        public int CellNumber { get; set; }
        public int WorkNumber { get; set; }
        public string Email { get; set; }
        // public int AId { get; set; }
        // [ForeignKey("AId")]
        // public Address Address { get; set; }

        //public string AddressLot { get; set; }
        //public string AddressStreet { get; set; }
        //public string AddressArea { get; set; }

        //public string AddressVillage { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public int RegimentNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public int NationalIdNumber { get; set; }
        public string PassportNumber { get; set; }
        public DateTime PassportExpirationDate { get; set; }
        public int TinNumber { get; set; }


        // address info
        public int EId { get; set; }
        public string Lot { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string Village { get; set; }

        public int Region { get; set; }

        public int Country { get; set; }

    }
}