using DinamikCRM.Entity.Models.DB;
using DinamikCRM.Repository;
using DinamikCRM.Repository.Model;

namespace DinamikCRM.Repository.Service
{
    public interface ICustomerService
    {
        ServiceResponse<CustomerListResponse> GetList(int rowCount);
        ServiceResponse<TblCustomer> GetListByTypeId(int typeId);
    }
}
