using EstudoDapper.Application.Commands.Clientes;
using EstudoDapper.Application.Interfaces;
using EstudoDapper.Application.Queries.Clientes;
using EstudoDapper.Domain.Validations;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EstudoDapper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ClienteQuery), 201)]
        public IActionResult Post(CriarClienteCommand command)
        {
            _clienteAppService.Add(command);
            return StatusCode(201, new
            {
                Message = "Cliente cadastrado com sucesso!",
                Cliente = command
            });
        }
    }
}
