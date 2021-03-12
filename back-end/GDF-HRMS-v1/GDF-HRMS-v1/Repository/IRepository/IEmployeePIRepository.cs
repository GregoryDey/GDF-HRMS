using GDF_HRMS_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Repository.IRepository
{
    public interface IEmployeePIRepository
    {
        ICollection<EmployeePI> GetEmployeePIs();
        ICollection<Region> GetAllRegions();

        ICollection<Religion> GetAllReligions();

        ICollection<Nationality> GetAllNationalities();

        ICollection<Ethnicity> GetAllEthnicities();
        ICollection<Position> GetAllPositions();
        ICollection<MaritalStatus> GetAllMaritalStatus();
        EmployeePI GetEmployeePIById(int employeeId);
        CareerHistory GetEmployeeCHByEId(int employeeId);
        EmployeePIDto GetEmployeePIByRegNumber(int employeeRNumber);
        ICollection<EmployeePIDto> GetEmployeePIByOtherCriteria(string employeeFname, string employeeLname, string employeePosition);

        EmployeePIDto GetEmployeePIByLname(string employeeLname);
        bool EmployeePIExists(string name);
        bool EmployeePIExists(int id);
        bool EmployeeCHExists(int id);
        bool CreateEmployeePI(EmployeePI employeePI);
        bool UpdateEmployeePI(EmployeePI employeePI);
        bool DeleteEmployeePI(EmployeePI employeePI);
        bool UpdateEmployeeCH(CareerHistory careerHistory);
        bool Save();

      
    }
}
