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
  public class ColecoesController : ControllerBase
  {
    private readonly IColecoesService _service;

    public ColecoesController(IColecoesService service)
    {
      _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PostColecao colecao)
    {
      try
      {
        var result = await _service.CreateAsync(colecao);

        if (result == null)
          return Conflict("Coleção já cadastrada");

        if (result == false)
          return BadRequest("Erro ao criar coleção");

        return StatusCode((int)HttpStatusCode.Created);
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao criar coleção");
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PutColecao colecao)
    {
      try
      {
        var result = await _service.UpdateAsync(colecao);

        if (result == null)
          return NotFound("Coleção não encontrado");

        if (result == false)
          return BadRequest("Erro ao alterar coleção");

        return Ok(colecao);
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao alterar colecao");
      }
    }

    [HttpPut("{id}/status")]
    public async Task<IActionResult> Put([FromRoute] int id, [FromBody] EstadoSistema estadoSistema)
    {
      try
      {
        var result = await _service.UpdateStatusAsync(id, estadoSistema);

        if (result == null)
          return NotFound("Coleção/Estado do Sistema não encontrado");

        if (result == false)
          return BadRequest("Erro ao alterar estado do sistema de coleção");

        return Ok(estadoSistema);
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao alterar estado do sistema de coleção");
      }
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] EstadoSistema? estadoSistema)
    {
      try
      {
        return Ok(await _service.GetAllAsync(estadoSistema));
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao listar coleções");
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
        return BadRequest("Erro ao obter coleção");
      }
    }
  }
}