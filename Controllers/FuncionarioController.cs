using Microsoft.AspNetCore.Mvc;

namespace TemplateBootstrap.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly TemplateBootstrap.Data.AppContext _appContext;

        public FuncionarioController(TemplateBootstrap.Data.AppContext appContext){
            _appContext = appContext;
        }

        public async Task<IActionResult> Index(){
            var funcs = await _appContext.Funcionarios.ToListAsync();
            return View(funcs);
        }
    }
}