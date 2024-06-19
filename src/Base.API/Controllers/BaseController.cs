using Base.Application.UseCases.Register;
using Base.Communication.Requests;
using Base.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Base.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BaseController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBaseJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterBaseUseCase useCase,
        [FromBody] RequestRegisterBaseJson request)
    {
        var response = await useCase.Execute(request);
        return Created(string.Empty, response);
    }
}