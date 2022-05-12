using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuario.Application.Interfaces;

namespace Usuario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _usuarioService.Get());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _usuarioService.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] InputUsuarioDto usuarioDto)
        {
            _usuarioService.Add(usuarioDto.Login, usuarioDto.Password);

            return Ok();
        }
    }
}
