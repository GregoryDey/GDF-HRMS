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
            CreateMap<EmployeePI, EmployeePIDto>().ForMember(dest =>
            dest.FirstName,
            opt => opt.MapFrom(src => src.Fname)).ForMember(dest =>
            dest.LastName,
            opt => opt.MapFrom(src => src.Lname)).ForMember(dest =>
            dest.OtherName,
            opt => opt.MapFrom(src => src.Oname)).ForMember(dest =>
            dest.NationalIdNumber,
            opt => opt.MapFrom(src => src.NidNumber)).ForMember(dest =>
            dest.PassportNumber,
            opt => opt.MapFrom(src => src.PNumber)).ForMember(dest =>
            dest.PassportExpirationDate,
            opt => opt.MapFrom(src => src.PExpirationDate)).ForMember(dest =>
            dest.Sex,
            opt => opt.MapFrom(src => src.Sex)).ForMember(dest =>
            dest.TinNumber,
            opt => opt.MapFrom(src => src.TinNumber)).ForMember(dest =>
            dest.Title,
            opt => opt.MapFrom(src => src.Title)).ForMember(dest =>
            dest.DateOfBirth,
            opt => opt.MapFrom(src => src.Dob)).ForMember(dest =>
            dest.Religion,
            opt => opt.MapFrom(src => src.Religion.Name)).ForMember(dest =>
            dest.Ethnicity,
            opt => opt.MapFrom(src => src.Ethnicity.Name)).ForMember(dest =>
            dest.MaritalStatus,
            opt => opt.MapFrom(src => src.MaritalStatus.Name)).ForMember(dest =>
            dest.Country,
            opt => opt.MapFrom(src => src.Country.Name)).ForMember(dest =>
            dest.Position,
            opt => opt.MapFrom(src => src.Position.Name)).ForMember(dest =>
            dest.RegimentNumber,
            opt => opt.MapFrom(src => src.RNumber)).ForMember(dest =>
            dest.AddressArea,
            opt => opt.MapFrom(src => src.Address.Area)).ForMember(dest =>
            dest.AddressLot,
            opt => opt.MapFrom(src => src.Address.Lot)).ForMember(dest =>
            dest.AddressStreet,
            opt => opt.MapFrom(src => src.Address.Street)).ForMember(dest =>
            dest.AddressVillage,
            opt => opt.MapFrom(src => src.Address.Village)).ForMember(dest =>
            dest.HomeNumber,
            opt => opt.MapFrom(src => src.ContactInfo.HNumber)).ForMember(dest =>
            dest.CellNumber,
            opt => opt.MapFrom(src => src.ContactInfo.CNumber)).ForMember(dest =>
            dest.WorkNumber,
            opt => opt.MapFrom(src => src.ContactInfo.WNumber)).ForMember(dest =>
            dest.Email,
            opt => opt.MapFrom(src => src.ContactInfo.Email)).ForMember(dest =>
            dest.Nationality,
            opt => opt.MapFrom(src => src.Nationality.Name)).ReverseMap();




            
            CreateMap<EmployeePI, EmployeePIDtoForChanges>().ForMember(dest =>
            dest.FirstName,
            opt => opt.MapFrom(src => src.Fname)).ForMember(dest =>
            dest.LastName,
            opt => opt.MapFrom(src => src.Lname)).ForMember(dest =>
            dest.OtherName,
            opt => opt.MapFrom(src => src.Oname)).ForMember(dest =>
            dest.NationalIdNumber,
            opt => opt.MapFrom(src => src.NidNumber)).ForMember(dest =>
            dest.PassportNumber,
            opt => opt.MapFrom(src => src.PNumber)).ForMember(dest =>
            dest.PassportExpirationDate,
            opt => opt.MapFrom(src => src.PExpirationDate)).ForMember(dest =>
            dest.Sex,
            opt => opt.MapFrom(src => src.Sex)).ForMember(dest =>
            dest.TinNumber,
            opt => opt.MapFrom(src => src.TinNumber)).ForMember(dest =>
            dest.Title,
            opt => opt.MapFrom(src => src.Title)).ForMember(dest =>
            dest.DateOfBirth,
            opt => opt.MapFrom(src => src.Dob)).ForMember(dest =>
            dest.Religion,
            opt => opt.MapFrom(src => src.Religion.Name)).ForMember(dest =>
            dest.Ethnicity,
            opt => opt.MapFrom(src => src.Ethnicity.Name)).ForMember(dest =>
            dest.MaritalStatus,
            opt => opt.MapFrom(src => src.MaritalStatus.Name)).ForMember(dest =>
            dest.Country,
            opt => opt.MapFrom(src => src.Country.Name)).ForMember(dest =>
            dest.Position,
            opt => opt.MapFrom(src => src.Position.Name)).ForMember(dest =>
            dest.RegimentNumber,
            opt => opt.MapFrom(src => src.RNumber)).ForMember(dest =>
            dest.AddressArea,
            opt => opt.MapFrom(src => src.Address.Area)).ForMember(dest =>
            dest.AddressLot,
            opt => opt.MapFrom(src => src.Address.Lot)).ForMember(dest =>
            dest.AddressStreet,
            opt => opt.MapFrom(src => src.Address.Street)).ForMember(dest =>
            dest.AddressVillage,
            opt => opt.MapFrom(src => src.Address.Village)).ForMember(dest =>
            dest.HomeNumber,
            opt => opt.MapFrom(src => src.ContactInfo.HNumber)).ForMember(dest =>
            dest.CellNumber,
            opt => opt.MapFrom(src => src.ContactInfo.CNumber)).ForMember(dest =>
            dest.WorkNumber,
            opt => opt.MapFrom(src => src.ContactInfo.WNumber)).ForMember(dest =>
            dest.Email,
            opt => opt.MapFrom(src => src.ContactInfo.Email)).ForMember(dest =>
            dest.Nationality,
            opt => opt.MapFrom(src => src.Nationality.Name)).ReverseMap();



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
