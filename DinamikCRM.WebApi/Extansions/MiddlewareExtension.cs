using DinamikCRM.WebApi.Middleware;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCRM.WebApi.Extansions
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseCheckCustomerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CheckCustomer>();
        }
    }
}
