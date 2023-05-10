using EstudoDapper.Application.Commands.Clientes;
using EstudoDapper.Application.Interfaces;
using EstudoDapper.Application.Queries.Clientes;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

        [HttpGet]
        [ProducesResponseType(typeof(ClienteQuery), 200)]
        public async Task<IActionResult> GetAll()
        {
            var clientes = await _clienteAppService.GetAll();
            return StatusCode(200, new
            {
                Message = "Lista de clientes recuperada com sucesso!",
                Cliente = clientes
            });
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ClienteQuery), 200)]
        public async Task<IActionResult> GetAById(Guid id)
        {
            var clientes = await _clienteAppService.GetById(id);
            return StatusCode(200, new
            {
                Message = "Cliente recuperado com sucesso!",
                Cliente = clientes
            });
        }

        [HttpPost]
        [ProducesResponseType(typeof(ClienteQuery), 201)]
        public async Task<IActionResult> Post(CriarClienteCommand command)
        {
            await _clienteAppService.Add(command);
            return StatusCode(201, new
            {
                Message = "Cliente cadastrado com sucesso!",
                Cliente = command
            });
        }

        [HttpPut]
        [ProducesResponseType(typeof(ClienteQuery), 200)]
        public async Task<IActionResult> Put(AtualizarClienteCommand command)
        {
            await _clienteAppService.Update(command);
            return StatusCode(200, new
            {
                Message = "Cliente atualizado com sucesso!",
                Cliente = command
            });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _clienteAppService.Remove(id);
            return StatusCode(200, new
            {
                Message = "Cliente excluido com sucesso!",
                Id = id
            }); ;
        }

    }
}
