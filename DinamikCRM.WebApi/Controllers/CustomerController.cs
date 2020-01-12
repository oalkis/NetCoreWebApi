using System;
using System.Collections.Generic;
using System.Linq;
using DinamikCRM.Entity.Models.DB;
using DinamikCRM.Repository;
using DinamikCRM.Repository.Model;
using DinamikCRM.Repository.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DinamikCRM.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IRepository<TblCustomer> _customerRepository;
     
     
        private readonly ICustomerService _customerService;
        public CustomerController(IRepository<TblCustomer> customerRepository, ICustomerService customerService)
        {
          
          
            _customerService = customerService;
            _customerRepository = customerRepository;
        }
            
        [HttpGet("GetById/{id}")]
        public ServiceResponse<TblCustomer> GetByID(int id)
        {

            var response = new ServiceResponse<TblCustomer>
            {
                Entity = _customerRepository.GetById(id),
                IsSuccessful = true
            };
            return response;

        }
        [HttpGet("GetList")]
        public ServiceResponse<TblCustomer> GetList()
        {
            var response = new ServiceResponse<TblCustomer>();
            response.List = _customerRepository.TableNoTracking.ToList();
            response.IsSuccessful = true;
            return response;
        }
        [HttpGet("GetList/{rowCount}")]
        public ServiceResponse<CustomerListResponse> GetList(int rowCount)
        {
            var response = _customerService.GetList(rowCount);



            return response;
        }
        [HttpGet("GetListByTypeId/{typeId}")]
        public ServiceResponse<TblCustomer> GetListByTypeId(int typeId)
        {

            var response = _customerService.GetListByTypeId(typeId);
            return response;
        }
        [HttpPost("Add")]
        public IActionResult Add([FromBody]TblCustomer tblCustomer)
        {
            var response = new ServiceResponse<TblCustomer>();
            if (!ModelState.IsValid || tblCustomer == null) return BadRequest();
         
            _customerRepository.Insert(tblCustomer);
            response.Entity = tblCustomer;
            response.IsSuccessful = true;
            return Ok(response);

        }
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var customer = _customerRepository.GetById(id);

            if (!ModelState.IsValid || customer == null) return BadRequest();

            var response = new ServiceResponse<TblCustomer>();
            response.Entity = customer;

            _customerRepository.Delete(customer);

            response.IsSuccessful = true;
            return Ok(response);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAddress : ControllerBase
    {
        private readonly IRepository<TblCustomerAddress> _customerAddressRepository;
        public CustomerAddress(IRepository<TblCustomerAddress> customerAddressRepository)
        {
            _customerAddressRepository = customerAddressRepository;
        }
        [HttpGet("GetById/{id}")]

        public ServiceResponse<TblCustomerAddress> GetByID(int id)
        {
            var response = new ServiceResponse<TblCustomerAddress>
            {
                Entity = _customerAddressRepository.GetById(id),
                IsSuccessful = true
            };
            return response;
        }
        [HttpGet("GetList")]
        public ServiceResponse<TblCustomerAddress> GetList()
        {
            var response = new ServiceResponse<TblCustomerAddress>
            {
                List = _customerAddressRepository.TableNoTracking.ToList(),
                IsSuccessful=true
            };


            return response;
        }
        [HttpPost("Add")]

        public IActionResult Add([FromBody]TblCustomerAddress tblCustomerAddress)
        {

            if (!ModelState.IsValid || tblCustomerAddress == null) return BadRequest();

            tblCustomerAddress.GroupId = Convert.ToInt32(HttpContext.Items["groupId"].ToString());
            tblCustomerAddress.UserId = Convert.ToInt32(HttpContext.Items["groupId"].ToString());
            var response = new ServiceResponse<TblCustomerAddress>
            {
                Entity = tblCustomerAddress,
                IsSuccessful = true
            };
            _customerAddressRepository.Insert(tblCustomerAddress);
            return Ok(response);

        }
        [HttpDelete("Delete/{id}")]

        public IActionResult Delete(int id)
        {
            var customer = _customerAddressRepository.GetById(id);
            if (!ModelState.IsValid || customer == null) return BadRequest();
          


            _customerAddressRepository.Delete(customer);
            var response = new ServiceResponse<TblCustomerAddress>
            {
                Entity = customer,
                IsSuccessful = true
            };
            return Ok(response);
        }
        [HttpPut("Update/{id}")]
        public IActionResult Update(int id, [FromBody]TblCustomerAddress tblCustomerAddress)
        {

            if (!ModelState.IsValid || tblCustomerAddress == null) return BadRequest();
            var entity = _customerAddressRepository.GetById(id);
            if (entity == null) return NotFound();

            entity.Address = tblCustomerAddress.Address;
            entity.CityId = tblCustomerAddress.CityId;
            entity.CountryId = tblCustomerAddress.CountryId;
            entity.DistrictId = tblCustomerAddress.DistrictId;
            entity.PostalCode = tblCustomerAddress.PostalCode;
            entity.UpdateDate = DateTime.Now;
            entity.Active = tblCustomerAddress.Active;
            entity.QuarterId = tblCustomerAddress.QuarterId;

            _customerAddressRepository.Update(entity);
            return Ok(entity);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerContact : ControllerBase
    {


        private readonly IRepository<TblCustomerContact> _customerContactRepository;
        public CustomerContact(IRepository<TblCustomerContact> customerContactRepository)
        {
            _customerContactRepository = customerContactRepository;
        }
        [HttpGet("GetById/{id}")]

        public ServiceResponse<TblCustomerContact> GetByID(int id)
        {
            var response = new ServiceResponse<TblCustomerContact>
            {
                Entity = _customerContactRepository.GetById(id),
                IsSuccessful = true
            };

            return response;
        }
        [HttpGet("GetList")]
        public ServiceResponse<TblCustomerContact> GetList()
        {
            var response = new ServiceResponse<TblCustomerContact>
            {
                List = _customerContactRepository.TableNoTracking.ToList(),
                IsSuccessful = true
            };

            return response;
        }
        [HttpPost("Add")]

        public IActionResult Add([FromBody]TblCustomerContact tblCustomerContact)
        {

            if (!ModelState.IsValid || tblCustomerContact == null) return BadRequest();
            _customerContactRepository.Insert(tblCustomerContact);
            var response = new ServiceResponse<TblCustomerContact>
            {
                Entity = tblCustomerContact,
                IsSuccessful = true
            };

            return Ok(response);

        }
        [HttpDelete("Delete/{id}")]

        public IActionResult Delete(int id)
        {
            var entity = _customerContactRepository.GetById(id);
            if (!ModelState.IsValid || entity == null) return BadRequest();

            _customerContactRepository.Delete(entity);
            var response = new ServiceResponse<TblCustomerContact>
            {
                Entity = entity,
                IsSuccessful = true
            };
            return Ok(response);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCustomFieldData : ControllerBase
    {
        private readonly IRepository<TblCustomerCustomFieldData> _customerCustomFieldDataRepository;
        public CustomerCustomFieldData(IRepository<TblCustomerCustomFieldData> customerCustomFieldDataRepository)
        {
            _customerCustomFieldDataRepository = customerCustomFieldDataRepository;
        }
        [HttpGet("GetById/{id}")]

        public ServiceResponse<TblCustomerCustomFieldData> GetByID(int id)

        {
            var response = new ServiceResponse<TblCustomerCustomFieldData>
            {
                Entity = _customerCustomFieldDataRepository.GetById(id),
                IsSuccessful = true
            };
            return response;
        }
        [HttpGet("GetList")]
        public ServiceResponse<TblCustomerCustomFieldData> GetList()
        {
            var response = new ServiceResponse<TblCustomerCustomFieldData>
            {
                List = _customerCustomFieldDataRepository.TableNoTracking.ToList(),
                IsSuccessful = true
            };

            return response;
        }
        [HttpPost("Add")]

        public IActionResult Add([FromBody]TblCustomerCustomFieldData tblCustomerCustomFieldData)
        {

            if (!ModelState.IsValid || tblCustomerCustomFieldData == null) return BadRequest();
            _customerCustomFieldDataRepository.Insert(tblCustomerCustomFieldData);

            var response = new ServiceResponse<TblCustomerCustomFieldData>
            {
                Entity = tblCustomerCustomFieldData,
                IsSuccessful = true
            };
            return Ok(response);

        }
        [HttpDelete("Delete/{id}")]

        public IActionResult Delete(int id)
        {
            var entity = _customerCustomFieldDataRepository.GetById(id);
            if (!ModelState.IsValid || entity == null) return BadRequest();

            _customerCustomFieldDataRepository.Delete(entity);
            var response = new ServiceResponse<TblCustomerCustomFieldData>
            {
                Entity = entity,
                IsSuccessful = true
            };
            return Ok(response);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerDetail : ControllerBase
    {
        private readonly IRepository<TblCustomerDetail> _customerDetailRepository;
        public CustomerDetail(IRepository<TblCustomerDetail> customerDetailRepository)
        {
            _customerDetailRepository = customerDetailRepository;
        }
        [HttpGet("GetById/{id}")]

        public ServiceResponse<TblCustomerDetail> GetByID(int id)
        {
            var response = new ServiceResponse<TblCustomerDetail>
            {
                Entity = _customerDetailRepository.GetById(id),
                IsSuccessful = true
            };
            return response;
        }
        [HttpGet("GetList")]
        public ServiceResponse<TblCustomerDetail> GetList()
        {
            var response = new ServiceResponse<TblCustomerDetail>
            {
                List = _customerDetailRepository.TableNoTracking.ToList(),
                IsSuccessful = true
            };


            return response;
        }
        [HttpPost("Add")]

        public IActionResult Add([FromBody]TblCustomerDetail tblCustomerDetail)
        {

            if (!ModelState.IsValid || tblCustomerDetail == null) return BadRequest();

            _customerDetailRepository.Insert(tblCustomerDetail);
            var response = new ServiceResponse<TblCustomerDetail>
            {
                Entity = tblCustomerDetail,
                IsSuccessful = true
            };

            return Ok(response);

        }
        [HttpDelete("Delete/{id}")]

        public IActionResult Delete(int id)
        {
            var entity = _customerDetailRepository.GetById(id);
            if (!ModelState.IsValid || entity == null) return BadRequest();

            _customerDetailRepository.Delete(entity);
            var response = new ServiceResponse<TblCustomerDetail>
            {
                Entity = entity,
                IsSuccessful = true
            };
            return Ok(response);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerEmail : ControllerBase
    {
        private readonly IRepository<TblCustomerEmail> _customerEmailRepository;
        public CustomerEmail(IRepository<TblCustomerEmail> customerEmailRepository)
        {
            _customerEmailRepository = customerEmailRepository;
        }

        [HttpGet("GetById/{id}")]

        public ServiceResponse<TblCustomerEmail> GetByID(int id)
        {
            var response = new ServiceResponse<TblCustomerEmail>
            {
                Entity = _customerEmailRepository.GetById(id),
                IsSuccessful = true
            };
            return response;
        }
        [HttpGet("GetList")]
        public ServiceResponse<TblCustomerEmail> GetList()
        {
            var response = new ServiceResponse<TblCustomerEmail>
            {
                List = _customerEmailRepository.TableNoTracking.ToList(),
                IsSuccessful = true
            };


            return response;
        }
        [HttpPost("Add")]

        public IActionResult Add([FromBody]TblCustomerEmail tblCustomerEmail)
        {

            if (!ModelState.IsValid || tblCustomerEmail == null) return BadRequest();

            _customerEmailRepository.Insert(tblCustomerEmail);
            var response = new ServiceResponse<TblCustomerEmail>
            {
                Entity = tblCustomerEmail,
                IsSuccessful = true
            };
            return Ok(response);

        }
        [HttpDelete("Delete/{id}")]

        public IActionResult Delete(int id)
        {
            var entity = _customerEmailRepository.GetById(id);
            if (!ModelState.IsValid || entity == null) return BadRequest();

            _customerEmailRepository.Delete(entity);
            var response = new ServiceResponse<TblCustomerEmail>
            {
                Entity = entity,
                IsSuccessful = true
            };
            return Ok(response);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerPhone : ControllerBase
    {
        private readonly IRepository<TblCustomerPhone> _customerPhoneRepository;
        public CustomerPhone(IRepository<TblCustomerPhone> customerPhoneRepository)
        {
            _customerPhoneRepository = customerPhoneRepository;
        }
        [HttpGet("GetById/{id}")]

        public ServiceResponse<TblCustomerPhone> GetByID(int id)
        {
            var response = new ServiceResponse<TblCustomerPhone>
            {
                Entity = _customerPhoneRepository.GetById(id),
                IsSuccessful = true
            };
            return response;
        }
        [HttpGet("GetList")]
        public ServiceResponse<TblCustomerPhone> GetList()
        {
            var response = new ServiceResponse<TblCustomerPhone>
            {
                List = _customerPhoneRepository.TableNoTracking.ToList(),
                IsSuccessful = true
            };


            return response;
        }
        [HttpPost("Add")]

        public IActionResult Add([FromBody]TblCustomerPhone tblCustomerPhone)
        {

            if (!ModelState.IsValid || tblCustomerPhone == null) return BadRequest();

            _customerPhoneRepository.Insert(tblCustomerPhone);
            var response = new ServiceResponse<TblCustomerPhone>
            {
                Entity = tblCustomerPhone,
                IsSuccessful = true
            };
            return Ok(response);

        }
        [HttpDelete("Delete/{id}")]

        public IActionResult Delete(int id)
        {
            var entity = _customerPhoneRepository.GetById(id);
            if (!ModelState.IsValid || entity == null) return BadRequest();

            _customerPhoneRepository.Delete(entity);
            var response = new ServiceResponse<TblCustomerPhone>
            {
                Entity = entity,
                IsSuccessful = true
            };
            return Ok(response);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSettings : ControllerBase
    {
        private readonly IRepository<TblCustomerSettings> _customerSettingsRepository;
        public CustomerSettings(IRepository<TblCustomerSettings> customerSettingsRepository)
        {
            _customerSettingsRepository = customerSettingsRepository;
        }
        [HttpGet("GetById/{id}")]

        public ServiceResponse<TblCustomerSettings> GetByID(int id)
        {
            var response = new ServiceResponse<TblCustomerSettings>
            {
                Entity = _customerSettingsRepository.GetById(id),
                IsSuccessful = true
            };
            return response;
        }
        [HttpGet("GetList")]
        public ServiceResponse<TblCustomerSettings> GetList()
        {
            var response = new ServiceResponse<TblCustomerSettings>
            {
                List = _customerSettingsRepository.TableNoTracking.ToList(),
                IsSuccessful = true
            };
            return response;
        }
        [HttpPost("Add")]

        public IActionResult Add([FromBody]TblCustomerSettings tblCustomerSettings)
        {

            if (!ModelState.IsValid || tblCustomerSettings == null) return BadRequest();

            _customerSettingsRepository.Insert(tblCustomerSettings);
            var response = new ServiceResponse<TblCustomerSettings>
            {
                Entity = tblCustomerSettings,
                IsSuccessful = true
            };
            return Ok(response);

        }
        [HttpDelete("Delete/{id}")]

        public IActionResult Delete(int id)
        {
            var entity = _customerSettingsRepository.GetById(id);
            if (!ModelState.IsValid || entity == null) return BadRequest();
          
            _customerSettingsRepository.Delete(entity);
            var response = new ServiceResponse<TblCustomerSettings>
            {
                Entity = entity,
                IsSuccessful = true
            };
            return Ok(response);
        }
    }


}