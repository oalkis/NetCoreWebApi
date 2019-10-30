using DinamikCRM.Entity.Models.DB;
using DinamikCRM.Repository;

namespace DinamikCRM.Service
{
    public interface ICustomerService
    {
        ServiceResponse<TblCustomer> GetList(int rowCount);
        ServiceResponse<TblCustomer> GetListByTypeId(int typeId);
    }
}
