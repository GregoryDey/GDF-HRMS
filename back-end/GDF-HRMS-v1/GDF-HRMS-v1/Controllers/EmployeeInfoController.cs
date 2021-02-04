using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GDF_HRMS_v1.Models;
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
        //Get employee info by ID
        [HttpGet("id/{employeeId:int}", Name = "GetEmployeePIById")]
        public IActionResult GetEmployeePIById(int employeeId)
        {
            var obj = _npRepo.GetEmployeePIById(employeeId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<EmployeePIDto>(obj);
            return Ok(objDto);

        }
        //Get employee info by Regiment Number
        [HttpGet("regnumber/{employeeRNumber:int}", Name = "GetEmployeePIByRegNumber")]
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
        //Get employee info by First Name
        [HttpGet("fname/{employeeFname}", Name = "GetEmployeePIByFname")]
        public IActionResult GetEmployeePIByFname(string employeeFname)
        {
            var obj = _npRepo.GetEmployeePIByFname(employeeFname);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<EmployeePIDto>(obj);
            return Ok(objDto);

        }

    }
}
