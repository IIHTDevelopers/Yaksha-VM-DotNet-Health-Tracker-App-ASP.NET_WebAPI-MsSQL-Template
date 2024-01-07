using HealthTrackerApp.DAL.Interrfaces;
using HealthTrackerApp.DAL.Services.Repository;
using HealthTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HealthTrackerApp.DAL.Services
{
    public class HealthTrackerService : IHealthTrackerService
    {
        private readonly IHealthTrackerRepository _repository;

        public HealthTrackerService(IHealthTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Health> CreateHealth(Health expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHealthById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Health> GetAllHealths()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Health> GetHealthById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Health> UpdateHealth(Health model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}