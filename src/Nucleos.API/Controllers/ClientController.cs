using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Nucleos.API.Controllers;

[ApiController]
public class ClientController
{
    [HttpGet]
    [Route("api/[controller]")]
    public Task<IResult> Get()
    {
        var result = Results.Accepted("Clientes");
        return Task.FromResult(result);
    }
}