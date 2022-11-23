using Microsoft.AspNetCore.Mvc;
using Tasks.Application.Services.ArrayTask.Interface;

namespace Tasks.Web.Controllers
{
    public class ArrayTask : Controller
    {
        private readonly IArrayTask_Sevices arrayTask_Sevices;
        public ArrayTask(IArrayTask_Sevices arrayTask_Sevices)
        {
            this.arrayTask_Sevices = arrayTask_Sevices;
        }
        public IActionResult Index(string caracteres)
        {
            var result= arrayTask_Sevices.ReverseIt(caracteres);
            return View(result);
        }
    }
}
