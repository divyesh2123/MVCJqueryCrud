using Microsoft.AspNetCore.Mvc;
using MVCJqueryCrud.Models;

namespace MVCJqueryCrud.Controllers
{
    public class InstituteController : Controller
    {
        private WeltecVadodaraContext _weltecVadodaraContext;
        public InstituteController() {

            _weltecVadodaraContext = new WeltecVadodaraContext();
        }
        public IActionResult Index()
        {
            var p = _weltecVadodaraContext.Institutes.ToList();
            return Json(new { data= p});
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult CreateStudentForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStudentForm(Institute institute)
        {
            _weltecVadodaraContext.Institutes.Add(institute);
            _weltecVadodaraContext.SaveChanges();
            return Json(new { Message = "data sabe Sucesnfully" });
        }

        public IActionResult DeleteInfo(int id)
        {
            var deleteRecord = _weltecVadodaraContext.Institutes.Find(id);
            _weltecVadodaraContext.Institutes.Remove(deleteRecord);
            _weltecVadodaraContext.SaveChanges();
            return Json(new { IsDelete = true, Message = "Delete Sucesnfully" });
        }
    }
}
