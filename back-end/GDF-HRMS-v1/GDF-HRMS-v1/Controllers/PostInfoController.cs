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
    public class PostInfoController : ControllerBase
    {
        private IEmployeePIRepository _npRepo;
        private readonly IMapper _mapper;

        public PostInfoController(IEmployeePIRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;
        }

        [HttpPost("AddAnEmployee", Name = "AddAnEmployee")]
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
            var employeePIObj = _mapper.Map<CreateEmployeeDto, EmployeePI>(createEmployeeDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateEmployeePI(employeePIObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {employeePIObj.Fname}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddAnEmployeeAddress", Name = "AddAnEmployeeAddress")]
        public IActionResult AddAnEmployeeAddress([FromBody] AddAddressDto addressDto)
        {
            if (addressDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.AddressExists(addressDto.Id))
            {
                ModelState.AddModelError("", "Address already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var employeeAddressObj = _mapper.Map<AddAddressDto, Address>(addressDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateEmployeeAddress(employeeAddressObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {employeeAddressObj.Lot}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddAnEmployeeCareerHistory", Name = "AddAnEmployeeCareerHistory")]
        public IActionResult AddAnEmployeeCH([FromBody] AddCareerHistoryDto careerHistoryDto)
        {
            if (careerHistoryDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.EmployeeCHExists(careerHistoryDto.Id))
            {
                ModelState.AddModelError("", "Career History already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var employeeCHObj = _mapper.Map<AddCareerHistoryDto, CareerHistory>(careerHistoryDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateEmployeeCH(employeeCHObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {employeeCHObj.StartDate}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddAReligion", Name = "AddAReligion")]
        public IActionResult AddAReligion([FromBody] ReligionDto religionDto)
        {
            if (religionDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.ReligionExists(religionDto.Name))
            {
                ModelState.AddModelError("", "Religion already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var religionObj = _mapper.Map<ReligionDto, Religion>(religionDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateReligion(religionObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {religionObj.Name}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddACountry", Name = "AddACountry")]
        public IActionResult AddACountry([FromBody] CountryDto countryDto)
        {
            if (countryDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.CountryExists(countryDto.Name))
            {
                ModelState.AddModelError("", "Country already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var countryObj = _mapper.Map<CountryDto, Country>(countryDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateCountry(countryObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {countryObj.Name}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddADepartment", Name = "AddADepartment")]
        public IActionResult AddADepartment([FromBody] DepartmentDto departmentDto)
        {
            if (departmentDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.DepartmentExists(departmentDto.Name))
            {
                ModelState.AddModelError("", "Department already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var departmentObj = _mapper.Map<DepartmentDto, Department>(departmentDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateDepartment(departmentObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {departmentObj.Name}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddAnEthnicity", Name = "AddAnEthnicity")]
        public IActionResult AddAnEthnicity([FromBody] EthnicityDto ethnicityDto)
        {
            if (ethnicityDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.EthnicityExists(ethnicityDto.Name))
            {
                ModelState.AddModelError("", "Ethnicity already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var ethnicityObj = _mapper.Map<EthnicityDto, Ethnicity>(ethnicityDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateEthnicity(ethnicityObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {ethnicityObj.Name}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddAMaritalStatus", Name = "AddAMaritalStatus")]
        public IActionResult AddAMaritalStatus([FromBody] MaritalStatusDto maritalStatusDto)
        {
            if (maritalStatusDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.MaritalStatusExists(maritalStatusDto.Name))
            {
                ModelState.AddModelError("", "Marital Status already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var maritalStatusObj = _mapper.Map<MaritalStatusDto, MaritalStatus>(maritalStatusDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateMaritalStatus(maritalStatusObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {maritalStatusObj.Name}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddANationality", Name = "AddANationality")]
        public IActionResult AddANationality([FromBody] NationalityDto nationalityDto)
        {
            if (nationalityDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.NationalityExists(nationalityDto.Name))
            {
                ModelState.AddModelError("", "Nationality already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var nationalityObj = _mapper.Map<NationalityDto, Nationality>(nationalityDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateNationality(nationalityObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {nationalityObj.Name}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddAPosition", Name = "AddAPosition")]
        public IActionResult AddAPosition([FromBody] PositionDto positionDto)
        {
            if (positionDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.CountryExists(positionDto.Name))
            {
                ModelState.AddModelError("", "Country already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var positionObj = _mapper.Map<PositionDto, Position>(positionDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreatePosition(positionObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {positionObj.Name}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPost("AddARegion", Name = "AddARegion")]
        public IActionResult AddARegion([FromBody] RegionDto regionDto)
        {
            if (regionDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_npRepo.RegionExists(regionDto.Name))
            {
                ModelState.AddModelError("", "Region already exists.");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // var ContactInfoObj = _mapper.Map<CreateEmployeeDto, ContactInfo>(createEmployeeDto);
            var regionObj = _mapper.Map<RegionDto, Region>(regionDto);

            // employeePIObj.ContactInfo = ContactInfoObj;
            if (!_npRepo.CreateRegion(regionObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {regionObj.Name}");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }
    }
}
