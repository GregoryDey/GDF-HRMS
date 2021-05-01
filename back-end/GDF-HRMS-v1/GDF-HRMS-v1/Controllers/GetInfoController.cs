using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GDF_HRMS_v1.Data;
using GDF_HRMS_v1.Models;
using GDF_HRMS_v1.Models.Dtos;
using GDF_HRMS_v1.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GDF_HRMS_v1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetInfoController : ControllerBase
    {
        private IEmployeePIRepository _npRepo;
        private readonly IMapper _mapper;
        public GetInfoController(IEmployeePIRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;
        }

        //Get all Regions
        [HttpGet("GetAllRegions", Name = "GetAllRegions")]
        public IActionResult GetAllRegions()
        {
            var objList = _npRepo.GetAllRegions();
            var objDto = new List<RegionDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<RegionDto>(obj));
            }
            return Ok(objDto);
        }

        //Get all Religions
        [HttpGet("GetAllReligions", Name = "GetAllReligions")]
        public IActionResult GetAllReligions()
        {
            var objList = _npRepo.GetAllReligions();
            var objDto = new List<ReligionDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<ReligionDto>(obj));
            }
            return Ok(objDto);
        }

        //Get all Nationalities
        [HttpGet("GetAllNationalities", Name = "GetAllNationalities")]
        public IActionResult GetAllNationalities()
        {
            var objList = _npRepo.GetAllNationalities();
            var objDto = new List<NationalityDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<NationalityDto>(obj));
            }
            return Ok(objDto);
        }

        //Get all Ethnicities
        [HttpGet("GetAllEthnicities", Name = "GetAllEthnicities")]
        public IActionResult GetAllEthnicities()
        {
            var objList = _npRepo.GetAllEthnicities();
            var objDto = new List<EthnicityDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<EthnicityDto>(obj));
            }
            return Ok(objDto);
        }

        //Get all Positions
        [HttpGet("GetAllPositions", Name = "GetAllPositions")]
        public IActionResult GetAllPositions()
        {
            var objList = _npRepo.GetAllPositions();
            var objDto = new List<PositionDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<PositionDto>(obj));
            }
            return Ok(objDto);
        }

        //Get all MaritalStatus
        [HttpGet("GetAllMaritalStaus", Name = "GetAllMaritalStatus")]
        public IActionResult GetAllMaritalStatus()
        {
            var objList = _npRepo.GetAllMaritalStatus();
            var objDto = new List<MaritalStatusDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<MaritalStatusDto>(obj));
            }
            return Ok(objDto);
        }

        //Get all Countries
        [HttpGet("GetAllCountries", Name = "GetAllCountries")]
        public IActionResult GetAllCountries()
        {
            var objList = _npRepo.GetAllCountries();
            var objDto = new List<CountryDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<CountryDto>(obj));
            }
            return Ok(objDto);
        }

        //Get all Departments
        [HttpGet("GetAllDepartments", Name = "GetAllDepartments")]
        public IActionResult GetAllDepartments()
        {
            var objList = _npRepo.GetAllDepartments();
            var objDto = new List<DepartmentDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<DepartmentDto>(obj));
            }
            return Ok(objDto);
        }

        //Get employee info by Regiment Number
        [HttpGet("RegimentNumber/{employeeRNumber:int}", Name = "GetEmployeePIByRegNumber")]
        public IActionResult GetEmployeePIByRegNumber(int employeeRNumber)
        {
           
            var obj = _npRepo.GetEmployeePIByRegNumber(employeeRNumber);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<EmployeePIDto>(obj);
            
            return Ok(objDto);

        }
        //Get employee info by other criteria
        [HttpGet("OtherCriteria/{employeeFname}/ {employeeLname}/ {employeePosition}", Name = "GetEmployeePIByOtherCriteria")]
        public IActionResult GetEmployeePIByOtherCriteria(string employeeFname, string employeeLname, int employeePosition)
        {
            var obj = _npRepo.GetEmployeePIByOtherCriteria(employeeFname, employeeLname, employeePosition);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<EmployeePIDto>(obj);
            return Ok(objDto);

        }
    }
}
