﻿using GDFHRMS.Data;
using GDFHRMS.Models;
using GDFHRMS.Models.Dtos;
using GDFHRMS.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDFHRMS.Repository
{
    public class NationalParksRepository : INationalParksRepository
    {
        private readonly ApplicationDBContext _db;

        public NationalParksRepository(ApplicationDBContext db)
        {
            _db = db;
        }
        public bool CreateNationalPark(NationalParkDto nationalPark)
        {
            _db.NationalParks.Add(nationalPark);
            return Save();
        }

        public bool DeleteNationalPark(NationalParkDto nationalPark)
        {
            _db.NationalParks.Remove(nationalPark);
            return Save();
        }

        public NationalParkDto GetNationalPark(int nationalParkId)
        {
            return _db.NationalParks.FirstOrDefault(a => a.Id == nationalParkId);
        }

        public ICollection<NationalParkDto> GetNationalParks()
        {
            return _db.NationalParks.OrderBy(a => a.Name).ToList();

        }

        public bool NationalParkExists(string name)
        {
                bool value = _db.NationalParks.Any(a => a.Name.ToLower().Trim()==name.ToLower().Trim());
                return value;
        }

        public bool NationalParkExists(int nationalParkId)
        {
                return _db.NationalParks.Any(a => a.Id == nationalParkId);
        }

        public bool Save()
        {
                return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateNationalPark(NationalParkDto nationalPark)
        {
                _db.NationalParks.Update(nationalPark);
                return Save();
        }
    }
}
