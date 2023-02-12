using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Nucleos.API.Controllers.V1.V1;

[Route("api/vi/[controller]")]
public class EmployController : BaseController
{
    [HttpGet]
    [Route("get-all-employ")]
    [AllowAnonymous]
    public async Task<string> GetLastEmploy()
    {
        return "Resultado ok";
    }
}