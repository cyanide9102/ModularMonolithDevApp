using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithDevApp.Modules.Confrences.Api.Controllers;

[Route(BasePath)]
internal class HomeController : BaseController
{
    [HttpGet]
    public ActionResult<string> Get() => "Confrences module!";
}
