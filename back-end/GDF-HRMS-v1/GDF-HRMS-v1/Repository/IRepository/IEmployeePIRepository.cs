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
        public ICollection<Country> GetAllCountries();
        public ICollection<Department> GetAllDepartments();

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
        bool ReligionExists(string name);
        bool CountryExists(string name);
        bool NationalityExists(string name);
        bool DepartmentExists(string name);
        bool EthnicityExists(string name);
        bool MaritalStatusExists(string name);
        bool PositionExists(string name);
        bool RegionExists(string name);
        bool EmployeePIExists(int id);
        bool EmployeeCHExists(int id);
        bool CreateEmployeePI(EmployeePI employeePI);
        bool CreateReligion(Religion religion);

        bool CreateCountry(Country country);
        bool CreateNationality(Nationality nationality);
        bool CreateDepartment(Department department);
        bool CreateEthnicity(Ethnicity ethnicity);
        bool CreateMaritalStatus(MaritalStatus maritalStatus);
        bool CreatePosition(Position position);
        bool CreateRegion(Region region);
        bool UpdateEmployeePI(EmployeePI employeePI);
        bool DeleteEmployeePI(EmployeePI employeePI);
        bool UpdateEmployeeCH(CareerHistory careerHistory);
        bool Save();

      
    }
}