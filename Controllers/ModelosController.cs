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
  public class ModelosController : ControllerBase
  {
    private readonly IModelosService _service;

    public ModelosController(IModelosService service)
    {
      _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PostModelo modelo)
    {
      try
      {
        var result = await _service.CreateAsync(modelo);

        if (result == null)
          return Conflict("Modelo já cadastrado");

        if (result == false)
          return BadRequest("Erro ao criar modelo");

        return StatusCode((int)HttpStatusCode.Created);
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao criar modelo");
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PutModelo modelo)
    {
      try
      {
        var result = await _service.UpdateAsync(modelo);

        if (result == null)
          return NotFound("Modelo não encontrado");

        if (result == false)
          return BadRequest("Erro ao alterar modelo");

        return Ok(modelo);
      }
      catch (Exception e)
      {
        return BadRequest("Erro ao alterar modelo");
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
        return BadRequest("Erro ao obter modelo");
      }
    }
  }
}