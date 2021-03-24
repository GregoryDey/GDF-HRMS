
using AutoMapper;
using GDF_HRMS_v1.Models;
using GDF_HRMS_v1.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.HRMS_Mapper
{
    public class HRMSMappings : Profile
    {
        public HRMSMappings()
        {
            CreateMap<EmployeePI, EmployeePIDto>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Fname))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Lname))
                .ForMember(dest => dest.OtherName, opt => opt.MapFrom(src => src.Oname))
                .ForMember(dest => dest.NationalIdNumber, opt => opt.MapFrom(src => src.NidNumber))
                .ForMember(dest => dest.PassportNumber, opt => opt.MapFrom(src => src.PNumber))
                .ForMember(dest => dest.PassportExpirationDate, opt => opt.MapFrom(src => src.PExpirationDate))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sex))
                .ForMember(dest => dest.TinNumber, opt => opt.MapFrom(src => src.TinNumber))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.Dob))
                .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.HNumber))
                .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.WNumber))
                .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.CNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Religion, opt => opt.MapFrom(src => src.Religion.Name))
                .ForMember(dest => dest.Ethnicity, opt => opt.MapFrom(src => src.Ethnicity.Name))
                .ForMember(dest => dest.MaritalStatus, opt => opt.MapFrom(src => src.MaritalStatus.Name))
                 .ForMember(dest => dest.Nationality, opt => opt.MapFrom(src => src.Nationality.Name))
                //  .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Address.Country.Name))
                // .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.CareerHistory.Position.Name))
                .ForMember(dest => dest.RegimentNumber, opt => opt.MapFrom(src => src.RNumber));
               // .ForMember(dest => dest.AddressArea, opt => opt.MapFrom(src => src.Address.Area))
               // .ForMember(dest => dest.AddressLot, opt => opt.MapFrom(src => src.Address.Lot))
              ///  .ForMember(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.Address.Street))
              //  .ForMember(dest => dest.AddressVillage, opt => opt.MapFrom(src => src.Address.Village))
              //  .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Address.Region.Name));
                //.ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.ContactInfo.HNumber))
               // .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.ContactInfo.CNumber))
               // .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.ContactInfo.WNumber))
               // .ForMember(dest => dest.Nationality, opt => opt.MapFrom(src => src.Nationality.Name));
                
            // .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.CareerHistory.Department.Name))
            // .ForMember(dest => dest.DepartmentDescription, opt => opt.MapFrom(src => src.CareerHistory.Department.Description))
            // .ForMember(dest => dest.DepartmentLocation, opt => opt.MapFrom(src => src.CareerHistory.Department.Location));


            CreateMap<EmployeePIDto, EmployeePI>()
                .ForMember(dest => dest.Fname, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Lname, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Oname, opt => opt.MapFrom(src => src.OtherName))
                .ForMember(dest => dest.NId, opt => opt.MapFrom(src => src.NationalIdNumber))
                .ForMember(dest => dest.PNumber, opt => opt.MapFrom(src => src.PassportNumber))
                .ForMember(dest => dest.PExpirationDate, opt => opt.MapFrom(src => src.PassportExpirationDate))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sex))
                .ForMember(dest => dest.TinNumber, opt => opt.MapFrom(src => src.TinNumber))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Dob, opt => opt.MapFrom(src => src.DateOfBirth))
                .ForMember(dest => dest.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
                .ForMember(dest => dest.CNumber, opt => opt.MapFrom(src => src.CellNumber))
                .ForMember(dest => dest.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForPath(dest => dest.Religion.Name, opt => opt.MapFrom(src => src.Religion))
                .ForPath(dest => dest.Ethnicity.Name, opt => opt.MapFrom(src => src.Ethnicity))
                .ForPath(dest => dest.MaritalStatus.Name, opt => opt.MapFrom(src => src.MaritalStatus))
               // .ForPath(dest => dest.Address.Country.Name, opt => opt.MapFrom(src => src.Country))
                // .ForPath(dest => dest.CareerHistory.Position.Name, opt => opt.MapFrom(src => src.Position))
                .ForMember(dest => dest.RNumber, opt => opt.MapFrom(src => src.RegimentNumber))
           //     .ForPath(dest => dest.Address.Area, opt => opt.MapFrom(src => src.AddressArea))
              //  .ForPath(dest => dest.Address.Lot, opt => opt.MapFrom(src => src.AddressLot))
             ///   .ForPath(dest => dest.Address.Street, opt => opt.MapFrom(src => src.AddressStreet))
             /////   .ForPath(dest => dest.Address.Village, opt => opt.MapFrom(src => src.AddressVillage))
             ///   .ForPath(dest => dest.Address.Region.Name, opt => opt.MapFrom(src => src.Region))
               // .ForPath(dest => dest.ContactInfo.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
               // .ForPath(dest => dest.ContactInfo.CNumber, opt => opt.MapFrom(src => src.CellNumber))
               // .ForPath(dest => dest.ContactInfo.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
              //  .ForPath(dest => dest.ContactInfo.Email, opt => opt.MapFrom(src => src.Email))
                .ForPath(dest => dest.Nationality.Name, opt => opt.MapFrom(src => src.Nationality));
            // .ForPath(dest => dest.CareerHistory.Department.Name, opt => opt.MapFrom(src => src.DepartmentName))
            // .ForPath(dest => dest.CareerHistory.Department.Description, opt => opt.MapFrom(src => src.DepartmentDescription))
            // .ForPath(dest => dest.CareerHistory.Department.Location, opt => opt.MapFrom(src => src.DepartmentLocation));
            //.ForPath(dest => dest.Department.Name, opt => opt.MapFrom(src => src.DepartmentName))
            // .ForPath(dest => dest.Department.Description, opt => opt.MapFrom(src => src.DepartmentDescription))
            //.ForPath(dest => dest.Department.Location, opt => opt.MapFrom(src => src.DepartmentLocation));




            CreateMap<EmployeePI, CreateEmployeeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NationalityId, opt => opt.MapFrom(src => src.NId))
                .ForMember(dest => dest.ReligionId, opt => opt.MapFrom(src => src.RId))
                .ForMember(dest => dest.EthnicityId, opt => opt.MapFrom(src => src.EId))
                .ForMember(dest => dest.MaritalStatusId, opt => opt.MapFrom(src => src.MId))
                .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.HNumber))
                .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.WNumber))
                .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.CNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                //.ForMember(dest => dest.PositionId, opt => opt.MapFrom(src => src.CareerHistory.Position.Id))
                // .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CId))
                //  .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.Address.Region.Id))
                //  .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.Address.Country.Id))

                .ForMember(dest => dest.RegimentNumber, opt => opt.MapFrom(src => src.RNumber))
                // .ForMember(dest => dest.AddressArea, opt => opt.MapFrom(src => src.Address.Area))
                // .ForMember(dest => dest.AddressLot, opt => opt.MapFrom(src => src.Address.Lot))
                ///   .ForMember(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.Address.Street))
                ///   .ForMember(dest => dest.AddressVillage, opt => opt.MapFrom(src => src.Address.Village))
                // .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.ContactInfo.HNumber))
                // .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.ContactInfo.CNumber))
                // .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.ContactInfo.WNumber))
                //   .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.ContactInfo.Email))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Fname))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Lname))
                .ForMember(dest => dest.OtherName, opt => opt.MapFrom(src => src.Oname))
                .ForMember(dest => dest.NationalIdNumber, opt => opt.MapFrom(src => src.NidNumber))
                .ForMember(dest => dest.PassportNumber, opt => opt.MapFrom(src => src.PNumber))
                .ForMember(dest => dest.PassportExpirationDate, opt => opt.MapFrom(src => src.PExpirationDate))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sex))
                .ForMember(dest => dest.TinNumber, opt => opt.MapFrom(src => src.TinNumber))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.Dob));
               // .ForPath(dest => dest.CountryId, opt => opt.MapFrom(src => src.Address.Ctry))
               //   .ForPath(dest => dest.RegionId, opt => opt.MapFrom(src => src.Address.Reg));
               //.ForPath(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.Department.EmployeeId));


            CreateMap<CreateEmployeeDto, EmployeePI>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NId, opt => opt.MapFrom(src => src.NationalityId))
                .ForMember(dest => dest.RId, opt => opt.MapFrom(src => src.ReligionId))
                .ForMember(dest => dest.EId, opt => opt.MapFrom(src => src.EthnicityId))
                .ForMember(dest => dest.MId, opt => opt.MapFrom(src => src.MaritalStatusId))
                .ForMember(dest => dest.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
                .ForMember(dest => dest.CNumber, opt => opt.MapFrom(src => src.CellNumber))
                .ForMember(dest => dest.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                //.ForMember(dest => dest.CareerHistory.Position.Id, opt => opt.MapFrom(src => src.PositionId))
                //.ForPath(dest => dest.Address.Country.Id, opt => opt.MapFrom(src => src.CountryId))
                // .ForMember(dest => dest.RId, opt => opt.MapFrom(src => src.RegionId))
                .ForMember(dest => dest.RNumber, opt => opt.MapFrom(src => src.RegimentNumber))
                .ForMember(dest => dest.Fname, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Lname, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Oname, opt => opt.MapFrom(src => src.OtherName))
                .ForMember(dest => dest.NidNumber, opt => opt.MapFrom(src => src.NationalIdNumber))
                .ForMember(dest => dest.PNumber, opt => opt.MapFrom(src => src.PassportNumber))
                .ForMember(dest => dest.PExpirationDate, opt => opt.MapFrom(src => src.PassportExpirationDate))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sex))
                .ForMember(dest => dest.TinNumber, opt => opt.MapFrom(src => src.TinNumber))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Dob, opt => opt.MapFrom(src => src.DateOfBirth));
            //.ForPath(dest => dest.ContactInfo.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
            // .ForPath(dest => dest.ContactInfo.CNumber, opt => opt.MapFrom(src => src.CellNumber))
            //  .ForPath(dest => dest.ContactInfo.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
            //   .ForPath(dest => dest.ContactInfo.Email, opt => opt.MapFrom(src => src.Email))
            //.ForPath(dest => dest.Address.Area, opt => opt.MapFrom(src => src.AddressArea))
            //.ForPath(dest => dest.Address.Lot, opt => opt.MapFrom(src => src.AddressLot))
            //.ForPath(dest => dest.Address.Ctry, opt => opt.MapFrom(src => src.CountryId))
            //.ForPath(dest => dest.Address.Reg, opt => opt.MapFrom(src => src.RegionId))
            //.ForPath(dest => dest.Address.Street, opt => opt.MapFrom(src => src.AddressStreet))
            //.ForPath(dest => dest.Address.Village, opt => opt.MapFrom(src => src.AddressVillage));
            //.ForPath(dest => dest.Department.EmployeeId, opt => opt.MapFrom(src => src.DepartmentId));


            // CreateMap<CreateEmployeeDto, ContactInfo>()
            //     .ForMember(dest => dest.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
            //     .ForMember(dest => dest.CNumber, opt => opt.MapFrom(src => src.CellNumber))
            //     .ForMember(dest => dest.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
            //     .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));

            CreateMap<UpdateEmployeeDto, EmployeePI>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NId, opt => opt.MapFrom(src => src.NationalityId))
                .ForMember(dest => dest.RId, opt => opt.MapFrom(src => src.ReligionId))
                .ForMember(dest => dest.EId, opt => opt.MapFrom(src => src.EthnicityId))
                .ForMember(dest => dest.MId, opt => opt.MapFrom(src => src.MaritalStatusId))
                

                .ForMember(dest => dest.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
                .ForMember(dest => dest.CNumber, opt => opt.MapFrom(src => src.CellNumber))
                .ForMember(dest => dest.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                // .ForMember(dest => dest.CareerHistory.Position.Id, opt => opt.MapFrom(src => src.PositionId))
                //  .ForMember(dest => dest.CId, opt => opt.MapFrom(src => src.CountryId))
                // .ForMember(dest => dest.DId, opt => opt.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.RId, opt => opt.MapFrom(src => src.RegionId))
                .ForMember(dest => dest.RNumber, opt => opt.MapFrom(src => src.RegimentNumber))
                .ForMember(dest => dest.Fname, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Lname, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Oname, opt => opt.MapFrom(src => src.OtherName))
                .ForMember(dest => dest.NidNumber, opt => opt.MapFrom(src => src.NationalIdNumber))
                .ForMember(dest => dest.PNumber, opt => opt.MapFrom(src => src.PassportNumber))
                .ForMember(dest => dest.PExpirationDate, opt => opt.MapFrom(src => src.PassportExpirationDate))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sex))
                .ForMember(dest => dest.TinNumber, opt => opt.MapFrom(src => src.TinNumber))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Dob, opt => opt.MapFrom(src => src.DateOfBirth));
            /// .ForPath(dest => dest.ContactInfo.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
            //  .ForPath(dest => dest.ContactInfo.CNumber, opt => opt.MapFrom(src => src.CellNumber))
            //  .ForPath(dest => dest.ContactInfo.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
            //   .ForPath(dest => dest.ContactInfo.Email, opt => opt.MapFrom(src => src.Email))
            //.ForPath(dest => dest.Address.Area, opt => opt.MapFrom(src => src.AddressArea))
            //.ForPath(dest => dest.Address.Lot, opt => opt.MapFrom(src => src.AddressLot))
            //.ForPath(dest => dest.Address.Ctry, opt => opt.MapFrom(src => src.CountryId))
            //.ForPath(dest => dest.Address.Reg, opt => opt.MapFrom(src => src.RegionId))
            //.ForPath(dest => dest.Address.Street, opt => opt.MapFrom(src => src.AddressStreet))
            //.ForPath(dest => dest.Address.Village, opt => opt.MapFrom(src => src.AddressVillage));

            CreateMap<EmployeePI, UpdateEmployeeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NationalityId, opt => opt.MapFrom(src => src.NId))
                .ForMember(dest => dest.ReligionId, opt => opt.MapFrom(src => src.RId))
                .ForMember(dest => dest.EthnicityId, opt => opt.MapFrom(src => src.EId))
                .ForMember(dest => dest.MaritalStatusId, opt => opt.MapFrom(src => src.MId))
                .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.HNumber))
                .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.WNumber))
                .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.CNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                //.ForMember(dest => dest.PositionId, opt => opt.MapFrom(src => src.CareerHistory.Position.Id))
                //  .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CId))
                //  .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.RId))
                //.ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DId))
                .ForMember(dest => dest.RegimentNumber, opt => opt.MapFrom(src => src.RNumber))
                //.ForMember(dest => dest.AddressArea, opt => opt.MapFrom(src => src.Address.Area))
                //.ForMember(dest => dest.AddressLot, opt => opt.MapFrom(src => src.Address.Lot))
                //.ForMember(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.Address.Street))
                //.ForMember(dest => dest.AddressVillage, opt => opt.MapFrom(src => src.Address.Village))
                // .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.ContactInfo.HNumber))
                //  .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.ContactInfo.CNumber))
                //  .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.ContactInfo.WNumber))
                //  .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.ContactInfo.Email))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Fname))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Lname))
                .ForMember(dest => dest.OtherName, opt => opt.MapFrom(src => src.Oname))
                .ForMember(dest => dest.NationalIdNumber, opt => opt.MapFrom(src => src.NidNumber))
                .ForMember(dest => dest.PassportNumber, opt => opt.MapFrom(src => src.PNumber))
                .ForMember(dest => dest.PassportExpirationDate, opt => opt.MapFrom(src => src.PExpirationDate))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sex))
                .ForMember(dest => dest.TinNumber, opt => opt.MapFrom(src => src.TinNumber))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.Dob)); 
                //.ForPath(dest => dest.CountryId, opt => opt.MapFrom(src => src.Address.Ctry))
                //.ForPath(dest => dest.RegionId, opt => opt.MapFrom(src => src.Address.Reg));


            //CreateMap<CareerHistory, EmployeePIDto>()
            //    .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name))
            //    .ForMember(dest => dest.DepartmentLocation, opt => opt.MapFrom(src => src.Department.Location))
            //    .ForMember(dest => dest.DepartmentDescription, opt => opt.MapFrom(src => src.Department.Description))
            //    .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position.Name));

            //CreateMap<EmployeePIDto, CareerHistory>()
            //    .ForPath(dest => dest.Department.Name, opt => opt.MapFrom(src => src.DepartmentName))
            //    .ForPath(dest => dest.Department.Location, opt => opt.MapFrom(src => src.DepartmentLocation))
            //    .ForPath(dest => dest.Department.Description, opt => opt.MapFrom(src => src.DepartmentDescription))
            //    .ForPath(dest => dest.Position.Name, opt => opt.MapFrom(src => src.Position));


            //CreateMap<CareerHistory, CreateEmployeeDto>()
            //    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DeptId))
            //    .ForMember(dest => dest.PositionId, opt => opt.MapFrom(src => src.PosId));

            //CreateMap<CreateEmployeeDto, CareerHistory>()
            //    .ForPath(dest => dest.DeptId, opt => opt.MapFrom(src => src.DepartmentId))
            //     .ForPath(dest => dest.PosId, opt => opt.MapFrom(src => src.PositionId));

            CreateMap<CareerHistory, UpdateEmployeeDto>()
                .ForPath(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DeptId))
                 .ForPath(dest => dest.PositionId, opt => opt.MapFrom(src => src.PosId));

            CreateMap<UpdateEmployeeDto, CareerHistory>()
                .ForPath(dest => dest.DeptId, opt => opt.MapFrom(src => src.DepartmentId))
                 .ForPath(dest => dest.PosId, opt => opt.MapFrom(src => src.PositionId));

            //CreateMap<Address, EmployeePIDto>()
            //    .ForPath(dest => dest.AddressLot, opt => opt.MapFrom(src => src.Lot))
            //     .ForPath(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.Street));

            //CreateMap<EmployeePIDto, Address>()
            //    .ForPath(dest => dest.Lot, opt => opt.MapFrom(src => src.AddressLot))
            //     .ForPath(dest => dest.Street, opt => opt.MapFrom(src => src.AddressStreet));


            CreateMap<Address, AddressDto>()
                .ForPath(dest => dest.Lot, opt => opt.MapFrom(src => src.Lot))
                .ForPath(dest => dest.Village, opt => opt.MapFrom(src => src.Village))
                .ForPath(dest => dest.Area, opt => opt.MapFrom(src => src.Area))
                .ForPath(dest => dest.Street, opt => opt.MapFrom(src => src.Street))
                .ForPath(dest => dest.Region, opt => opt.MapFrom(src => src.Region.Name))
                .ForPath(dest => dest.Country, opt => opt.MapFrom(src => src.Country.Name));

            CreateMap<AddressDto, Address>()
                .ForPath(dest => dest.Lot, opt => opt.MapFrom(src => src.Lot))
                .ForPath(dest => dest.Street, opt => opt.MapFrom(src => src.Street))
                .ForPath(dest => dest.Area, opt => opt.MapFrom(src => src.Area))
                .ForPath(dest => dest.Village, opt => opt.MapFrom(src => src.Village))
                .ForPath(dest => dest.Region.Name, opt => opt.MapFrom(src => src.Region))
                .ForPath(dest => dest.Country.Name, opt => opt.MapFrom(src => src.Country));

            CreateMap<CareerHistory, CareerHistoryDto>()
                .ForPath(dest => dest.Position, opt => opt.MapFrom(src => src.Position.Name))
                .ForPath(dest => dest.Department, opt => opt.MapFrom(src => src.Department.Name))
                .ForPath(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForPath(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate));

            CreateMap<CareerHistoryDto, CareerHistory>()
                .ForPath(dest => dest.Position.Name, opt => opt.MapFrom(src => src.Position))
                .ForPath(dest => dest.Department.Name, opt => opt.MapFrom(src => src.Department))
                .ForPath(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForPath(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate));

            CreateMap<Religion, ReligionDto>().ReverseMap();
            CreateMap<Nationality, NationalityDto>().ReverseMap();
            CreateMap<Position, PositionDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Religion, ReligionDto>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<MaritalStatus, MaritalStatusDto>().ReverseMap();
            CreateMap<Ethnicity, EthnicityDto>().ReverseMap();
           // CreateMap<CareerHistory, CareerHistoryDto>().ReverseMap();
         //   CreateMap<Address, AddressDto>().ReverseMap();
            //CreateMap<ContactInfo, ContactInfoDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
        }
    }
}