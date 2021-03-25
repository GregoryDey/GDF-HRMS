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
    public class DeleteInfoController : ControllerBase
    {
        private IEmployeePIRepository _npRepo;
        private readonly IMapper _mapper;

        public DeleteInfoController(IEmployeePIRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;
        }

        [HttpDelete("DeleteEmployee/{employeeId:int}", Name = "DeleteEmployee")]

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

        [HttpDelete("{DeleteCountry}", Name = "DeleteCountry")]

        public IActionResult DeleteCountry(int countryId)
        {
            if (!_npRepo.CountryExists(countryId))
            {
                return NotFound();
            }

            var countryObj = _npRepo.GetCountryById(countryId);
            if (!_npRepo.DeleteCountry(countryObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {countryObj.Name}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{DeleteDepartment}", Name = "DeleteDepartment")]

        public IActionResult DeleteDepartment(int departmentId)
        {
            if (!_npRepo.DepartmentExists(departmentId))
            {
                return NotFound();
            }

            var departmentObj = _npRepo.GetDepartmentById(departmentId);
            if (!_npRepo.DeleteDepartment(departmentObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {departmentObj.Name}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{DeleteEthnicity}", Name = "DeleteEthnicity")]

        public IActionResult DeleteEthnicity(int ethnicityId)
        {
            if (!_npRepo.EthnicityExists(ethnicityId))
            {
                return NotFound();
            }

            var ethnicityObj = _npRepo.GetEthnicityById(ethnicityId);
            if (!_npRepo.DeleteEthnicity(ethnicityObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {ethnicityObj.Name}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{DeleteMaritalStatus}", Name = "DeleteMaritalSattus")]

        public IActionResult DeleteMaritalStatus(int maritalStatusId)
        {
            if (!_npRepo.MaritalStatusExists(maritalStatusId))
            {
                return NotFound();
            }

            var maritalStatusObj = _npRepo.GetMaritalStatusById(maritalStatusId);
            if (!_npRepo.DeleteMaritalStatus(maritalStatusObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {maritalStatusObj.Name}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{DeleteNationality}", Name = "DeleteNationality")]

        public IActionResult DeleteNationality(int nationalityId)
        {
            if (!_npRepo.NationalityExists(nationalityId))
            {
                return NotFound();
            }

            var nationalityObj = _npRepo.GetNationalityById(nationalityId);
            if (!_npRepo.DeleteNationality(nationalityObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {nationalityObj.Name}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{DeletePosition}", Name = "DeletePosition")]

        public IActionResult DeletePosition(int positionId)
        {
            if (!_npRepo.PositionExists(positionId))
            {
                return NotFound();
            }

            var positionObj = _npRepo.GetPositionById(positionId);
            if (!_npRepo.DeletePosition(positionObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {positionObj.Name}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{DeleteRegion}", Name = "DeleteRegion")]

        public IActionResult DeleteRegion(int regionId)
        {
            if (!_npRepo.RegionExists(regionId))
            {
                return NotFound();
            }

            var regionObj = _npRepo.GetRegionById(regionId);
            if (!_npRepo.DeleteRegion(regionObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {regionObj.Name}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{DeleteReligion}", Name = "DeleteReligion")]

        public IActionResult DeleteReligion(int religionId)
        {
            if (!_npRepo.ReligionExists(religionId))
            {
                return NotFound();
            }

            var religionObj = _npRepo.GetReligionById(religionId);
            if (!_npRepo.DeleteReligion(religionObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {religionObj.Name}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("DeleteAddress/{addressId:int}", Name = "DeleteAddress")]

        public IActionResult DeleteAddress(int addressId)
        {
            if (!_npRepo.AddressExists(addressId))
            {
                return NotFound();
            }

            var addressObj = _npRepo.GetAddressById(addressId);
            if (!_npRepo.DeleteAddress(addressObj))
            {
                ModelState.AddModelError("", $"Something went wrong when deleting the record {addressObj}");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }
    }
}
