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
            var result = await _service.CreateAsync(modelo);

            if (result == null)
                return Conflict("Modelo já cadastrado");

            if (!result.Value)
                return BadRequest("Erro ao criar modelo");

            return CreatedAtRoute(nameof(Get), new { id = modelo.Id }, modelo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PutModelo modelo)
        {
            var result = await _service.UpdateAsync(modelo);

            if (result == null)
                return NotFound("Modelo não encontrado");

            if (!result.Value)
                return BadRequest("Erro ao alterar modelo");

            return Ok(modelo);
        }

        [HttpPut("{id}/layout")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Layout layout)
        {
            var result = await _service.UpdateLayoutAsync(id, layout);

            if (result == null)
                return NotFound("Modelo/Layout não encontrado");

            if (!result.Value)
                return BadRequest("Erro ao alterar layout do modelo");

            return Ok(layout);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] Layout? layout)
        {
            return Ok(await _service.GetAllAsync(layout));
        }

        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var modelo = await _service.GetByIdAsync(id);

            if (modelo == null)
                return NotFound("Modelo não encontrado");

            return Ok(modelo);
        }
    }
}
