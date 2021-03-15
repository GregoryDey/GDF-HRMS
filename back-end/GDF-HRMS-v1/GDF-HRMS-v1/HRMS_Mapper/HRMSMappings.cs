
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
                .ForMember(dest => dest.Religion, opt => opt.MapFrom(src => src.Religion.Name))
                .ForMember(dest => dest.Ethnicity, opt => opt.MapFrom(src => src.Ethnicity.Name))
                .ForMember(dest => dest.MaritalStatus, opt => opt.MapFrom(src => src.MaritalStatus.Name))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position.Name))
                .ForMember(dest => dest.RegimentNumber, opt => opt.MapFrom(src => src.RNumber))
                .ForMember(dest => dest.AddressArea, opt => opt.MapFrom(src => src.Address.Area))
                .ForMember(dest => dest.AddressLot, opt => opt.MapFrom(src => src.Address.Lot))
                .ForMember(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.AddressVillage, opt => opt.MapFrom(src => src.Address.Village))
                .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.ContactInfo.HNumber))
                .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.ContactInfo.CNumber))
                .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.ContactInfo.WNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.ContactInfo.Email))
                .ForMember(dest => dest.Nationality, opt => opt.MapFrom(src => src.Nationality.Name));


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
                .ForPath(dest => dest.Religion.Name, opt => opt.MapFrom(src => src.Religion))
                .ForPath(dest => dest.Ethnicity.Name, opt => opt.MapFrom(src => src.Ethnicity))
                .ForPath(dest => dest.MaritalStatus.Name, opt => opt.MapFrom(src => src.MaritalStatus))
                .ForPath(dest => dest.Country.Name, opt => opt.MapFrom(src => src.Country))
                .ForPath(dest => dest.Position.Name, opt => opt.MapFrom(src => src.Position))
                .ForMember(dest => dest.RNumber, opt => opt.MapFrom(src => src.RegimentNumber))
                .ForPath(dest => dest.Address.Area, opt => opt.MapFrom(src => src.AddressArea))
                .ForPath(dest => dest.Address.Lot, opt => opt.MapFrom(src => src.AddressLot))
                .ForPath(dest => dest.Address.Street, opt => opt.MapFrom(src => src.AddressStreet))
                .ForPath(dest => dest.Address.Village, opt => opt.MapFrom(src => src.AddressVillage))
                .ForPath(dest => dest.ContactInfo.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
                .ForPath(dest => dest.ContactInfo.CNumber, opt => opt.MapFrom(src => src.CellNumber))
                .ForPath(dest => dest.ContactInfo.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
                .ForPath(dest => dest.ContactInfo.Email, opt => opt.MapFrom(src => src.Email))
                .ForPath(dest => dest.Nationality.Name, opt => opt.MapFrom(src => src.Nationality));

            CreateMap<EmployeePI, EmployeePIDtoForChanges>()
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
            .ForMember(dest => dest.Religion, opt => opt.MapFrom(src => src.Religion.Name))
            .ForMember(dest => dest.Ethnicity, opt => opt.MapFrom(src => src.Ethnicity.Name))
            .ForMember(dest => dest.MaritalStatus, opt => opt.MapFrom(src => src.MaritalStatus.Name))
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.Name))
            .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position.Name))
            .ForMember(dest => dest.RegimentNumber, opt => opt.MapFrom(src => src.RNumber))
            .ForMember(dest => dest.AddressArea, opt => opt.MapFrom(src => src.Address.Area))
            .ForMember(dest => dest.AddressLot, opt => opt.MapFrom(src => src.Address.Lot))
            .ForMember(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.Address.Street))
            .ForMember(dest => dest.AddressVillage, opt => opt.MapFrom(src => src.Address.Village))
            .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.ContactInfo.HNumber))
            .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.ContactInfo.CNumber))
            .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.ContactInfo.WNumber))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.ContactInfo.Email))
            .ForMember(dest => dest.Nationality, opt => opt.MapFrom(src => src.Nationality.Name));



            CreateMap<EmployeePI, CreateEmployeeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NationalityId, opt => opt.MapFrom(src => src.NId))
                .ForMember(dest => dest.ReligionId, opt => opt.MapFrom(src => src.RId))
                .ForMember(dest => dest.EthnicityId, opt => opt.MapFrom(src => src.EId))
                .ForMember(dest => dest.MaritalStatusId, opt => opt.MapFrom(src => src.MId))
                .ForMember(dest => dest.PositionId, opt => opt.MapFrom(src => src.PId))
                .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CId))
                .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.RegId))
                .ForMember(dest => dest.RegimentNumber, opt => opt.MapFrom(src => src.RNumber))
                .ForMember(dest => dest.AddressArea, opt => opt.MapFrom(src => src.Address.Area))
                .ForMember(dest => dest.AddressLot, opt => opt.MapFrom(src => src.Address.Lot))
                .ForMember(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.AddressVillage, opt => opt.MapFrom(src => src.Address.Village))
                .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.ContactInfo.HNumber))
                .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.ContactInfo.CNumber))
                .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.ContactInfo.WNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.ContactInfo.Email))
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
                .ForPath(dest => dest.CountryId, opt => opt.MapFrom(src => src.Address.Ctry))
                .ForPath(dest => dest.RegionId, opt => opt.MapFrom(src => src.Address.Reg));


            CreateMap<CreateEmployeeDto, EmployeePI>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NId, opt => opt.MapFrom(src => src.NationalityId))
                .ForMember(dest => dest.RId, opt => opt.MapFrom(src => src.ReligionId))
                .ForMember(dest => dest.EId, opt => opt.MapFrom(src => src.EthnicityId))
                .ForMember(dest => dest.MId, opt => opt.MapFrom(src => src.MaritalStatusId))
                .ForMember(dest => dest.PId, opt => opt.MapFrom(src => src.PositionId))
                .ForMember(dest => dest.CId, opt => opt.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.RegId, opt => opt.MapFrom(src => src.RegionId))
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
                .ForMember(dest => dest.Dob, opt => opt.MapFrom(src => src.DateOfBirth))
                .ForPath(dest => dest.ContactInfo.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
                .ForPath(dest => dest.ContactInfo.CNumber, opt => opt.MapFrom(src => src.CellNumber))
                .ForPath(dest => dest.ContactInfo.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
                .ForPath(dest => dest.ContactInfo.Email, opt => opt.MapFrom(src => src.Email))
                .ForPath(dest => dest.Address.Area, opt => opt.MapFrom(src => src.AddressArea))
                .ForPath(dest => dest.Address.Lot, opt => opt.MapFrom(src => src.AddressLot))
                .ForPath(dest => dest.Address.Ctry, opt => opt.MapFrom(src => src.CountryId))
                .ForPath(dest => dest.Address.Reg, opt => opt.MapFrom(src => src.RegionId))
                .ForPath(dest => dest.Address.Street, opt => opt.MapFrom(src => src.AddressStreet))
                .ForPath(dest => dest.Address.Village, opt => opt.MapFrom(src => src.AddressVillage));


            CreateMap<CreateEmployeeDto, ContactInfo>()
                .ForMember(dest => dest.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
                .ForMember(dest => dest.CNumber, opt => opt.MapFrom(src => src.CellNumber))
                .ForMember(dest => dest.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));

            CreateMap<UpdateEmployeeDto, EmployeePI>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NId, opt => opt.MapFrom(src => src.NationalityId))
                .ForMember(dest => dest.RId, opt => opt.MapFrom(src => src.ReligionId))
                .ForMember(dest => dest.EId, opt => opt.MapFrom(src => src.EthnicityId))
                .ForMember(dest => dest.MId, opt => opt.MapFrom(src => src.MaritalStatusId))
                .ForMember(dest => dest.PId, opt => opt.MapFrom(src => src.PositionId))
                .ForMember(dest => dest.CId, opt => opt.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.RegId, opt => opt.MapFrom(src => src.RegionId))
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
                .ForMember(dest => dest.Dob, opt => opt.MapFrom(src => src.DateOfBirth))
                .ForPath(dest => dest.ContactInfo.HNumber, opt => opt.MapFrom(src => src.HomeNumber))
                .ForPath(dest => dest.ContactInfo.CNumber, opt => opt.MapFrom(src => src.CellNumber))
                .ForPath(dest => dest.ContactInfo.WNumber, opt => opt.MapFrom(src => src.WorkNumber))
                .ForPath(dest => dest.ContactInfo.Email, opt => opt.MapFrom(src => src.Email))
                .ForPath(dest => dest.Address.Area, opt => opt.MapFrom(src => src.AddressArea))
                .ForPath(dest => dest.Address.Lot, opt => opt.MapFrom(src => src.AddressLot))
                .ForPath(dest => dest.Address.Ctry, opt => opt.MapFrom(src => src.CountryId))
                .ForPath(dest => dest.Address.Reg, opt => opt.MapFrom(src => src.RegionId))
                .ForPath(dest => dest.Address.Street, opt => opt.MapFrom(src => src.AddressStreet))
                .ForPath(dest => dest.Address.Village, opt => opt.MapFrom(src => src.AddressVillage));

            CreateMap<EmployeePI, UpdateEmployeeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NationalityId, opt => opt.MapFrom(src => src.NId))
                .ForMember(dest => dest.ReligionId, opt => opt.MapFrom(src => src.RId))
                .ForMember(dest => dest.EthnicityId, opt => opt.MapFrom(src => src.EId))
                .ForMember(dest => dest.MaritalStatusId, opt => opt.MapFrom(src => src.MId))
                .ForMember(dest => dest.PositionId, opt => opt.MapFrom(src => src.PId))
                .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CId))
                .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.RegId))
                .ForMember(dest => dest.RegimentNumber, opt => opt.MapFrom(src => src.RNumber))
                .ForMember(dest => dest.AddressArea, opt => opt.MapFrom(src => src.Address.Area))
                .ForMember(dest => dest.AddressLot, opt => opt.MapFrom(src => src.Address.Lot))
                .ForMember(dest => dest.AddressStreet, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.AddressVillage, opt => opt.MapFrom(src => src.Address.Village))
                .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src.ContactInfo.HNumber))
                .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(src => src.ContactInfo.CNumber))
                .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src.ContactInfo.WNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.ContactInfo.Email))
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
                .ForPath(dest => dest.CountryId, opt => opt.MapFrom(src => src.Address.Ctry))
                .ForPath(dest => dest.RegionId, opt => opt.MapFrom(src => src.Address.Reg));

            CreateMap<Religion, ReligionDto>().ReverseMap();
            CreateMap<Nationality, NationalityDto>().ReverseMap();
            CreateMap<Position, PositionDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Religion, ReligionDto>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<MaritalStatus, MaritalStatusDto>().ReverseMap();
            CreateMap<Ethnicity, EthnicityDto>().ReverseMap();
            CreateMap<CareerHistory, CareerHistoryDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<ContactInfo, ContactInfoDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
        }
    }
}