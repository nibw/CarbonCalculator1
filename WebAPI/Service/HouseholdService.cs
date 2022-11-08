using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.IService;
using WebAPI.Models;

namespace WebAPI.Service
{
    public class HouseholdService : IHouseholdService
    {
        private readonly ApiDbContext _context;

        public HouseholdService(ApiDbContext context)
        {
            _context = context;
        }

        public string Delete(int householdId)
        {
            var household = _context.Households.FirstOrDefault(x => x.HouseholdId == householdId);
            if (household != null)
            {
                _context.Households.Remove(household);
                _context.SaveChanges();
            }
            return "Deteled";
        }

        public Household GetById(int householdId)
        {
            return _context.Households.SingleOrDefault(x => x.HouseholdId == householdId);
        }

        public List<Household> GetList()
        {
            return _context.Households.ToList();
        }

        public void save(Household oHousehold)
        {
            //var currentDate = DateTime.Now.Date;
            //_context.Households.Add(new Household()
            //{
            //    AmountPeople = oHousehold.AmountPeople,
            //    LpgConsumption = oHousehold.LpgConsumption,
            //    Standmeter = oHousehold.Standmeter,
            //    CityGasConsumption = oHousehold.CityGasConsumption,
            //    CreatedDate = currentDate
            //});
            _context.Households.Add(oHousehold);
            _context.SaveChanges();
        }

        public void update(Household oHousehold)
        {
            _context.Households.Update(oHousehold);
            _context.SaveChanges();
        }
    }
}
