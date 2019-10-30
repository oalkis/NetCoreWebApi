using DinamikCRM.Entity.Models.DB;
using DinamikCRM.Repository;
using System;
using System.Linq;
using DinamikCRM.Repository.Model;

namespace DinamikCRM.Repository.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<TblCustomer> _customerRepository;
        public CustomerService(IRepository<TblCustomer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public ServiceResponse<CustomerListResponse> GetList(int rowCount)
        {
            var response = new ServiceResponse<CustomerListResponse>();
            var query = _customerRepository.TableNoTracking.Take(rowCount);
            var list = query.ToList();
            foreach (var customer in list)
            {
                var viewModel = new CustomerListResponse
                {
                    Id = customer.Id,
                    CustomerNumber = customer.CustomerNumber,
                    FullName = customer.Name + " " + customer.Surname


                };
                response.List.Add(viewModel);
            }
            response.IsSuccessful = true;
            return response;

        }
        public ServiceResponse<TblCustomer> GetListByTypeId(int typeId)
        {
            var response = new ServiceResponse<TblCustomer>();
            var query = _customerRepository.GetSql("select * from tblCustomer where TypeId=" + typeId + "").ToList();
            response.List = query;
            //response.Count = response.List.Count;
            return response;
        }

    }
}
