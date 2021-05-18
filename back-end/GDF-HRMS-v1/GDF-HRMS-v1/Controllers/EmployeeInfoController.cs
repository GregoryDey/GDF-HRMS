using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GDF_HRMS_v1.Models;
using GDF_HRMS_v1.Models.Dtos;
using GDF_HRMS_v1.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;




namespace GDF_HRMS_v1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeInfoController : ControllerBase
    {
        private IEmployeePIRepository _npRepo;
        private readonly IMapper _mapper;

        public EmployeeInfoController(IEmployeePIRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;
        }
        //Get all employees personal info
        [HttpGet]
        public IActionResult GetEmployeePIs()
        {
            var objList = _npRepo.GetEmployeePIs();
            var objDto = new List<EmployeePIDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<EmployeePIDto>(obj));
            }
            return Ok(objDto);
        }


        //Get all Regions
        //[HttpGet("GetAllRegions", Name = "GetAllRegions")]
        //public IActionResult GetAllRegions()
        //{
        //    var objList = _npRepo.GetAllRegions();
        //    var objDto = new List<RegionDto>();
        //    foreach (var obj in objList)
        //    {
        //        objDto.Add(_mapper.Map<RegionDto>(obj));
        //    }
        //    return Ok(objDto);
        //}

        


        //Get employee info by ID
        [HttpGet("id/{employeeId:int}", Name = "GetEmployeePIById")]
        public IActionResult GetEmployeePIById(int employeeId)
        {
            var obj = _npRepo.GetEmployeePIById(employeeId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<UpdateEmployeeDto>(obj);
            return Ok(objDto);

        }

        //Get employee career history by ID
        [HttpGet("GetEmployeeCareerHistoryByTheirId", Name = "GetEmployeeCareerHistoryByTheirId")]
        public IActionResult GetEmployeeCHByEId(int employeeId)
        {
            var obj = _npRepo.GetEmployeeCHByEId(employeeId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<List<CareerHistoryDto>>(obj);
            return Ok(objDto);

        }

        //Get employee career history by ID
        [HttpGet("GetEmployeeAddressByTheirId", Name = "GetEmployeeAddressByTheirId")]
        public IActionResult GetEmployeeAddressByEId(int employeeId)
        {
            var obj = _npRepo.GetAddressByEId(employeeId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<List<AddressDto>>(obj);
            return Ok(objDto);

        }








    }

}

