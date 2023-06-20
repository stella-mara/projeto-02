using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
﻿using Microsoft.AspNetCore.Mvc;
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
    }
}