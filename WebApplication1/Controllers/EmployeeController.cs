using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        IEmployee _emp1;
        IEmployee _emp2;
        public EmployeeController(IEmployee emp1, IEmployee emp2)
        {
            _emp1 = emp1;
            _emp2 = emp2;
        }
        [HttpGet]

        public ActionResult Index()
        {

            string gid1 = _emp1.Generateguid().ToString();
            string gid2 = _emp2.Generateguid().ToString();
            List<string> emplist = _emp1.GetEmployeeList();
            return Ok(emplist);
        }
    }
}
