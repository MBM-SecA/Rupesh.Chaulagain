
using System.Linq;
using Microsoft.AspNetCore.Mvc;


public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees = Person.GetPerson();
 
        return View(employees);

    }

    public ActionResult Detail(string firstname)
    {
        var employees = Person.GetPerson();
        var employee = employees.Where(x => x.FirstName == firstname).First();
        return View(employee);
    }

    public ActionResult Add()
    {
        return View();
    }
    [HttpPost]    
    public ActionResult<string> Add([FromForm]Person person)
    {
        return "So for so good!";
    }

   
   

}