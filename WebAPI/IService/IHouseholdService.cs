using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.IService
{
    public interface IHouseholdService
    {
        List<Household> GetList();
        Household GetById(int householdId);
        void save(Household oHousehold);
        void update(Household oHousehold);
        string Delete(int householdId);
    }
}
