using Microsoft.AspNetCore.Mvc;

namespace ModularMonolithDevApp.Modules.Confrences.Api.Controllers;

[ApiController]
[Route(BasePath + "/[controller]")]
internal abstract class BaseController : ControllerBase
{
    protected const string BasePath = "confrences-module";
}
