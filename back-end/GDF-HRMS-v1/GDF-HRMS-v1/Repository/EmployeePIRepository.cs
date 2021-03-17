using GDF_HRMS_v1.Data;
using GDF_HRMS_v1.Models;
using GDF_HRMS_v1.Models.Dtos;
using GDF_HRMS_v1.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
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

        public bool CreateReligion(Religion religion)
        {
            _db.Religions.Add(religion);
            return Save();
        }

        public bool CreateCountry(Country country)
        {
            _db.Countries.Add(country);
            return Save();
        }

        public bool CreateNationality(Nationality nationality)
        {
            _db.Nationalities.Add(nationality);
            return Save();
        }

        public bool CreateDepartment(Department department)
        {
            _db.Departments.Add(department);
            return Save();
        }

        public bool CreateEthnicity(Ethnicity ethnicity)
        {
            _db.Ethnicities.Add(ethnicity);
            return Save();
        }

        public bool CreateMaritalStatus(MaritalStatus maritalStatus)
        {
            _db.MaritalStatuses.Add(maritalStatus);
            return Save();
        }

        public bool CreatePosition(Position position)
        {
            _db.Positions.Add(position);
            return Save();
        }

        public bool CreateRegion(Region region)
        {
            _db.Regions.Add(region);
            return Save();
        }

        public bool DeleteEmployeePI(EmployeePI employeePI)
        {
            _db.EmployeePIs.Remove(employeePI);
            return Save();
        }

        public bool DeleteCountry(Country country)
        {
            _db.Countries.Remove(country);
            return Save();
        }

        public bool EmployeePIExists(string name)
        {
            bool value = _db.EmployeePIs.Any(a => a.Lname.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool ReligionExists(string name)
        {
            bool value = _db.Religions.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool CountryExists(string name)
        {
            bool value = _db.Countries.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool CountryExists(int Id)
        {
            bool value = _db.Countries.Any(a => a.Id == Id);
            return value;
        }
        public bool NationalityExists(string name)
        {
            bool value = _db.Nationalities.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool DepartmentExists(string name)
        {
            bool value = _db.Departments.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool EthnicityExists(string name)
        {
            bool value = _db.Ethnicities.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool MaritalStatusExists(string name)
        {
            bool value = _db.MaritalStatuses.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool PositionExists(string name)
        {
            bool value = _db.Positions.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool RegionExists(string name)
        {
            bool value = _db.Regions.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }
        public bool EmployeePIExists(int id)
        {
            bool value = _db.EmployeePIs.Any(a => a.Id == id);
            return value;
        }

        public ICollection<EmployeePIDto> GetEmployeePIByOtherCriteria(string employeeFname, string employeeLname, string employeePosition )
        {
            //return _db.EmployeePIs.FirstOrDefault(a => a.Fname.ToLower().Trim() == employeeFname.ToLower().Trim());

            return _db.EmployeePIs.Where(a => a.Fname == employeeFname || a.Lname == employeeLname || a.CareerHistory.Position.Name == employeePosition).Select(a => new EmployeePIDto
            {
                FirstName = a.Fname,
                LastName = a.Lname,
                OtherName = a.Oname,
                NationalIdNumber = a.NidNumber,
                PassportNumber = a.PNumber,
                PassportExpirationDate = a.PExpirationDate,
                Sex = a.Sex,
                TinNumber = a.TinNumber,
                Title = a.Title,
                DateOfBirth = a.Dob,
                Religion = a.Religion.Name,
                Nationality = a.Nationality.Name,
                Ethnicity = a.Ethnicity.Name,
                MaritalStatus = a.MaritalStatus.Name,
                //Position = a.CareerHistory.Position.Name,
                RegimentNumber = a.RNumber,
                AddressLot = a.Address.Lot,
                AddressArea = a.Address.Area,
                AddressStreet = a.Address.Street,
                AddressVillage = a.Address.Village,
                Country = a.Address.Country.Name,
                Region = a.Address.Region.Name,
                HomeNumber = a.ContactInfo.HNumber,
                CellNumber = a.ContactInfo.CNumber,
                WorkNumber = a.ContactInfo.WNumber,
                Email = a.ContactInfo.Email
                //DepartmentName = a.Department.Name,
               // DepartmentDescription = a.Department.Description,
               // DepartmentLocation = a.Department.Location



            }).ToList();
        }

        public EmployeePIDto GetEmployeePIByLname(string employeeLname)
        {
            //return _db.EmployeePIs.FirstOrDefault(a => a.Fname.ToLower().Trim() == employeeFname.ToLower().Trim());

            return _db.EmployeePIs.Where(a => a.Lname == employeeLname).Select(a => new EmployeePIDto
            {
                FirstName = a.Fname,
                LastName = a.Lname,
                OtherName = a.Oname,
                NationalIdNumber = a.NidNumber,
                PassportNumber = a.PNumber,
                PassportExpirationDate = a.PExpirationDate,
                Sex = a.Sex,
                TinNumber = a.TinNumber,
                Title = a.Title,
                DateOfBirth = a.Dob,
                Religion = a.Religion.Name,
                Nationality = a.Nationality.Name,
                Ethnicity = a.Ethnicity.Name,
                MaritalStatus = a.MaritalStatus.Name,
                Country = a.Address.Country.Name,
               // Position = a.CareerHistory.Position.Name,
                Region = a.Address.Region.Name,
                RegimentNumber = a.RNumber,
                AddressLot = a.Address.Lot,
                AddressArea = a.Address.Area,
                AddressStreet = a.Address.Street,
                AddressVillage = a.Address.Village,
                HomeNumber = a.ContactInfo.HNumber,
                CellNumber = a.ContactInfo.CNumber,
                WorkNumber = a.ContactInfo.WNumber,
                Email = a.ContactInfo.Email



            }).FirstOrDefault();
        }

        public EmployeePI GetEmployeePIById(int employeeId)
        {
            return _db.EmployeePIs.FirstOrDefault(a => a.Id == employeeId);
        }

        public Country GetCountryById(int countryId)
        {
            return _db.Countries.FirstOrDefault(a => a.Id == countryId);
        }
        public EmployeePIDto GetEmployeePIByRegNumber(int employeeRNumber)
        {
            return _db.EmployeePIs.Where(a => a.RNumber == employeeRNumber).Select(a => new EmployeePIDto
            {
                FirstName = a.Fname,
                LastName = a.Lname,
                OtherName = a.Oname,
                NationalIdNumber = a.NidNumber,
                PassportNumber = a.PNumber,
                PassportExpirationDate = a.PExpirationDate,
                Sex = a.Sex,
                TinNumber = a.TinNumber,
                Title = a.Title,
                DateOfBirth = a.Dob,
                Religion = a.Religion.Name,
                Nationality = a.Nationality.Name,
                Ethnicity = a.Ethnicity.Name,
                MaritalStatus = a.MaritalStatus.Name,
                Country = a.Address.Country.Name,
                //Position = a.CareerHistory.Position.Name,
                Region = a.Address.Country.Name,
                RegimentNumber = a.RNumber,
                AddressLot = a.Address.Lot,
                AddressArea = a.Address.Area,
                AddressStreet = a.Address.Street,
                AddressVillage = a.Address.Village,
                HomeNumber = a.ContactInfo.HNumber,
                CellNumber = a.ContactInfo.CNumber,
                WorkNumber = a.ContactInfo.WNumber,
                Email = a.ContactInfo.Email,
               /// DepartmentName = a.CareerHistory.Department.Name,
               // DepartmentDescription = a.CareerHistory.Department.Description,
               // DepartmentLocation = a.CareerHistory.Department.Location



            }).FirstOrDefault();

            //var result =  (from a in _db.EmployeePIs
            //              select new EmployeePIDto
            //              {

            //                  Id = a.Id,
            //                  Fname = a.Fname,
            //                  Lname = a.Lname,
            //                  RId = a.Religion.Id,
            //                  ReligionName = a.Religion.Name

            //              }).FirstOrDefault();
            //return result;



        }

        public ICollection<EmployeePI> GetEmployeePIs()
        {
            return _db.EmployeePIs.OrderBy(a => a.Lname).ToList();
        }

        public ICollection<Country> GetAllCountries()
        {
            return _db.Countries.OrderBy(a => a.Name).ToList();
        }

        public ICollection<Department> GetAllDepartments()
        {
            return _db.Departments.OrderBy(a => a.Name).ToList();
        }

        public ICollection<Region> GetAllRegions()
        {
            return _db.Regions.OrderBy(a => a.Id).ToList();
        }

        public ICollection<Religion> GetAllReligions()
        {
            return _db.Religions.OrderBy(a => a.Id).ToList();
        }

        public ICollection<Nationality> GetAllNationalities()
        {
            return _db.Nationalities.OrderBy(a => a.Id).ToList();
        }

        public ICollection<Ethnicity> GetAllEthnicities()
        {
            return _db.Ethnicities.OrderBy(a => a.Id).ToList();
        }

        public ICollection<Position> GetAllPositions()
        {
            return _db.Positions.OrderBy(a => a.Id).ToList();
        }

        public ICollection<MaritalStatus> GetAllMaritalStatus()
        {
            return _db.MaritalStatuses.OrderBy(a => a.Id).ToList();
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
            // return _db.CareerHistories.FirstOrDefault(a => a.EId == employeeId);
            return null;
        }
        public bool EmployeeCHExists(int id)
        {
            bool value = _db.CareerHistories.Any(a => a.Id == id);
            return value;
        }
    }
}