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
