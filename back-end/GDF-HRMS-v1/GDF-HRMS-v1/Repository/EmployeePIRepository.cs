using GDF_HRMS_v1.Data;
using GDF_HRMS_v1.Models;
using GDF_HRMS_v1.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Repository
{
    public class EmployeePIRepository : IEmployeePIRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeePIRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateEmployeePI(EmployeePI employeePI)
        {
            _db.EmployeePIs.Add(employeePI);
            return Save();
        }

        public bool DeleteEmployeePI(EmployeePI employeePI)
        {
            _db.EmployeePIs.Remove(employeePI);
            return Save();
        }

        public bool EmployeePIExists(string name)
        {
            bool value = _db.EmployeePIs.Any(a => a.Lname.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool EmployeePIExists(int id)
        {
            bool value = _db.EmployeePIs.Any(a => a.Id == id);
            return value;
        }

        public EmployeePI GetEmployeePIByFname(string employeeFname)
        {
            return _db.EmployeePIs.FirstOrDefault(a => a.Fname.ToLower().Trim() == employeeFname.ToLower().Trim());
        }

        public EmployeePI GetEmployeePIById(int employeeId)
        {
            return _db.EmployeePIs.FirstOrDefault(a => a.Id == employeeId);
        }

        public EmployeePI GetEmployeePIByRegNumber(int employeeRNumber)
        {
            return _db.EmployeePIs.FirstOrDefault(a => a.RNumber == employeeRNumber);

        }

        public ICollection<EmployeePI> GetEmployeePIs()
        {
            return _db.EmployeePIs.OrderBy(a => a.Lname).ToList();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateEmployeePI(EmployeePI employeePI)
        {
            _db.EmployeePIs.Update(employeePI);
            return Save();
        }
        public bool UpdateEmployeeCH(CareerHistory careerHistory)
        {
            _db.CareerHistories.Update(careerHistory);
            return Save();
        }
        public CareerHistory GetEmployeeCHByEId(int employeeId)
        {
            return _db.CareerHistories.FirstOrDefault(a => a.EId == employeeId);
        }
        public bool EmployeeCHExists(int id)
        {
            bool value = _db.CareerHistories.Any(a => a.Id == id);
            return value;
        }
    }
}
