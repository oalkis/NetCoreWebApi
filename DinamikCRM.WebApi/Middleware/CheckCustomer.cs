using DinamikCRM.Entity.Models.DB;
using DinamikCRM.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCRM.WebApi.Middleware
{
    public class CheckCustomer
    {
        private readonly RequestDelegate _next;
        private readonly IRepository<TblGroupApi> _groupApiRepository;

        public CheckCustomer(RequestDelegate next, IRepository<TblGroupApi> groupApiRepository)
        {
            _next = next;
            _groupApiRepository = groupApiRepository;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var key1 = httpContext.Request.Headers.Keys.Contains("ApiKey");
            var key2 = httpContext.Request.Headers.Keys.Contains("ApiSecret");
            
            if (!key1 || !key2)
            {
                httpContext.Response.StatusCode = 400;
                await httpContext.Response.WriteAsync("Missing requeired keys!");
                return;
            }
            else
            {
                var apiKey = httpContext.Request.Headers["ApiKey"].ToString();
                var apiSecret = httpContext.Request.Headers["ApiSecret"].ToString();

                var customer = _groupApiRepository.TableNoTracking.FirstOrDefault(m => m.ApiKey == apiKey && m.ApiSecret==apiSecret);

             
                httpContext.Items.Add("groupId", customer.GroupId);
                httpContext.Items.Add("userId", customer.UserId);


            }
            await _next.Invoke(httpContext);
        }
    }
}
