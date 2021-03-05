using AutoMapper;
using GDF_HRMS_v1.Models;
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
            CreateMap<EmployeePI, EmployeePIDto>().ReverseMap();
            CreateMap<Religion, ReligionDto>().ReverseMap();
            CreateMap<Nationality, NationalityDto>().ReverseMap();
        }
    }
}
