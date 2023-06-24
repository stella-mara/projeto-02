using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using projeto_02.Models.Enum;
using projeto_02.Services.Interfaces;
using projeto_02.Models.ViewModels;

namespace projeto_02.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UsuariosController : ControllerBase
  {
    private readonly IUsuariosService _service;

    public UsuariosController(IUsuariosService service)
    {
      _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PostUsuario usuario)
    {
      try
      {
        var result = await _service.CreateAsync(usuario);

        if (result == null)
          return Conflict("Usuário já cadastrado");

        if (result == false)
          return BadRequest("Erro ao criar usuário");

        return StatusCode((int)HttpStatusCode.Created);
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao criar usuário");
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PutUsuario usuario)
    {
      try
      {
        var result = await _service.UpdateAsync(usuario);

        if (result == null)
          return NotFound("Usuário não encontrado");

        if (result == false)
          return BadRequest("Erro ao alterar usuário");

        return Ok(usuario);
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao alterar usuário");
      }
    }

    [HttpPut("{id}/status")]
    public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Status status)
    {
      try
      {
        var result = await _service.UpdateStatusAsync(id, status);

        if (result == null)
          return NotFound("Usuário/Status não encontrado");

        if (result == false)
          return BadRequest("Erro ao alterar status do usuário");

        return Ok(status);
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao alterar status usuário");
      }
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] Status? status)
    {
      try
      {
        return Ok(await _service.GetAllAsync(status));
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao listar usuários");
      }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
      try
      {
        return Ok(await _service.GetByIdAsync(id));
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao obter usuário");
      }
    }
  }
}