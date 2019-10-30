using DinamikCRM.Entity.Models.DB;
using DinamikCRM.Repository;
using System;
using System.Linq;

namespace DinamikCRM.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<TblCustomer> _customerRepository;
        public CustomerService(IRepository<TblCustomer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public ServiceResponse<TblCustomer> GetList(int rowCount)
        {
            var response = new ServiceResponse<TblCustomer>();
            var query = _customerRepository.TableNoTracking.Take(rowCount);
            var list = query.ToList();
            foreach (var customer in list)
            {
                var viewModel = new TblCustomer
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Surname = customer.Surname
                   
                    
                };
                response.List.Add(viewModel);
            }
            response.IsSuccessful = true;
            //response.Count = list.Count();
            return response;

        }
        public ServiceResponse<TblCustomer> GetListByTypeId(int typeId)
        {
            var response = new ServiceResponse<TblCustomer>();
            var query = _customerRepository.GetSql("select * from tblCustomer where TypeId=" + typeId + "").ToList();
            response.List = query;
            response.Count = response.List.Count;
            return response;
        }
        
    }
}
