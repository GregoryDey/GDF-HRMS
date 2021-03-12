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
        [HttpGet("OtherCriteria/{FirstName,LastName,Position}", Name = "GetEmployeePIByOtherCriteria/{FirstName,LastName,Position}")]
        public IActionResult GetEmployeePIByOtherCriteria(string employeeFname, string employeeLname, string employeePosition)
        {
            var obj = _npRepo.GetEmployeePIByOtherCriteria(employeeFname, employeeLname, employeePosition);
            if (obj.Count == 0)
            {
                return NotFound();
            }
            //var objDto = _mapper.Map<EmployeePIDto>(obj);
            return Ok(obj);

        }

        //Get employee info by Last Name
        // [HttpGet("lname/{employeeLname}", Name = "GetEmployeePIByLname")]
        [HttpGet("LastName", Name = "GetEmployeePIByLname")]
        public IActionResult GetEmployeePIByLname(string employeeLname)
        {
            var obj = _npRepo.GetEmployeePIByLname(employeeLname);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<EmployeePIDto>(obj);
            return Ok(objDto);

        }

        //Get employee career history by ID
        [HttpGet("employeeCH/id/{employeeId:int}", Name = "GetEmployeeCHByEId")]
        public IActionResult GetEmployeeCHByEId(int employeeId)
        {
            var obj = _npRepo.GetEmployeeCHByEId(employeeId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<CareerHistoryDto>(obj);
            return Ok(objDto);

        }

        [HttpPatch("update/employeePI/{employeeRegimentNumber:int}", Name = "UpdateEmployeePI")] //Update employee info
        public IActionResult UpdateEmployeePI(int employeeId, [FromBody] CreateEmployeeDto createEmployeeDto)
        {
            if (createEmployeeDto == null || employeeId != createEmployeeDto.Id)
            {
                return BadRequest(ModelState);
            }
            var employeeObj = _mapper.Map<EmployeePI>(createEmployeeDto);

            if (!_npRepo.UpdateEmployeePI(employeeObj))
            {
                ModelState.AddModelError("", $"Something went wrong when updating the record {employeeObj.Id}");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }

        [HttpPatch("update/employeeCH/{employeeId:int}", Name = "UpdateEmployeeCH")] //Update career history
        public IActionResult UpdateEmployeeCH(int employeeId, [FromBody] CareerHistoryDto careerHistoryDto)
        {
            if (careerHistoryDto == null || employeeId != careerHistoryDto.Id)
            {
                return BadRequest(ModelState);
            }
            var careerHistoryObj = _mapper.Map<CareerHistory>(careerHistoryDto);

            if (!_npRepo.UpdateEmployeeCH(careerHistoryObj))
            {
                ModelState.AddModelError("", $"Something went wrong when updating the record {careerHistoryObj.Id}");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }

        [HttpPost(Name = "AddAnEmployee")]
        public IActionResult AddAnEmployee([FromBody] CreateEmployeeDto createEmployeeDto)
        {
            if (createEmployeeDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.EmployeePIExists(createEmployeeDto.RegimentNumber))
            {
                ModelState.AddModelError("", "Employee already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var employeePIObj = _mapper.Map<CreateEmployeeDto,EmployeePI>(createEmployeeDto);

           // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateEmployeePI(employeePIObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {employeePIObj.Fname}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }



        [HttpDelete("{employeeId:int}", Name = "DeleteEmployee")]

        public IActionResult DeleteEmployeeInfo(int employeeId)
        {
            if (!_npRepo.EmployeePIExists(employeeId))
            {
                return NotFound();
            }

            var employeePIObj = _npRepo.GetEmployeePIById(employeeId);
            if (!_npRepo.DeleteEmployeePI(employeePIObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {employeePIObj.Fname}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }
    }

}

