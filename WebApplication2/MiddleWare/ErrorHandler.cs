using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.MiddleWare
{
    public class ErrorHandler
    {
        private RequestDelegate _next;

        public ErrorHandler(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context) 
        {
            await _next(context);

            if (context.Response.StatusCode > 400)
            {
                context.Response.Redirect("~/Home/Error");
            }
        }
    }
}
