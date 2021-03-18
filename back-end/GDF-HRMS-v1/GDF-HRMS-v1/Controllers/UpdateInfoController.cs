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
    public class UpdateInfoController : ControllerBase
    {

        private IEmployeePIRepository _npRepo;
        private readonly IMapper _mapper;

        public UpdateInfoController(IEmployeePIRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;
        }


        [HttpPatch("update/employeePI/{employeeId:int}", Name = "UpdateEmployeePI")] //Update employee info
        public IActionResult UpdateEmployeePI(int employeeId, [FromBody] UpdateEmployeeDto updateEmployeeDto)
        {
            if (updateEmployeeDto == null || employeeId != updateEmployeeDto.Id)
            {
                return BadRequest(ModelState);
            }
            var employeeObj = _mapper.Map<EmployeePI>(updateEmployeeDto);

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
    }
}
