using HealthTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HealthTrackerApp.DAL.Services.Repository
{
    public class HealthTrackerRepository : IHealthTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public HealthTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Health> CreateHealth(Health expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteHealthById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Health> GetAllHealths()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Health> GetHealthById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        

        public async Task<Health> UpdateHealth(Health model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}