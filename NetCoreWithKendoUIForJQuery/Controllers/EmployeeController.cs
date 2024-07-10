using Microsoft.AspNetCore.Mvc;
using NetCoreWithKendoUIForJQuery.Models;

namespace NetCoreWithKendoUIForJQuery.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public JsonResult GetAllEmployees() { 
            var result = employeeRepository.GetAllEmployees();
            var data = new
            {
                Items = result,
                TotalCount = result.Count()
            };

            return new JsonResult(data);
        }
    }
}
