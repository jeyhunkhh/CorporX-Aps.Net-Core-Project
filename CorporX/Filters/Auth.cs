using Microsoft.AspNetCore.Mvc.Filters;
using CorporX.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Linq;

namespace CorporX.Filters
{
    public class Auth : ActionFilterAttribute
    {
        private readonly ApplicationDbContext _context;

        public Auth(ApplicationDbContext context)
        {
            _context = context;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            bool hasToken = context.HttpContext.Request.Cookies.TryGetValue("token", out string token);

            if (!hasToken)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login", controller = "adminaccount" }));
            }

            var user = _context.Accounts.FirstOrDefault(u => u.Token == token);

            if (user == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login", controller = "adminaccount" }));
            }

            context.RouteData.Values["User"] = user;

            base.OnActionExecuting(context);
        }
    }
}
