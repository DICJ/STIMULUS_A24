﻿using Microsoft.AspNetCore.Mvc;
using STIMULUS_V2.Server.Services.Interfaces;
using STIMULUS_V2.Shared.Models.Entities;

namespace STIMULUS_V2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TexteFormaterController : Controller
    {
        private readonly IModelService<TexteFormater, int> texteFormaterService;

        public TexteFormaterController(IModelService<TexteFormater, int> texteFormaterService)
        {
            this.texteFormaterService = texteFormaterService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] TexteFormater texteFormater)
        {
            var response = await texteFormaterService.Create(texteFormater);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await texteFormaterService.Delete(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await texteFormaterService.Get(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/All")]
        public async Task<IActionResult> GetAll()
        {
            var response = await texteFormaterService.GetAll();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/FromParent/{id}")]
        public async Task<IActionResult> GetFromParentId(int id)
        {
            var response = await texteFormaterService.GetFromParentId(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TexteFormater texteFormater)
        {
            var response = await texteFormaterService.Update(id, texteFormater);
            return StatusCode(response.StatusCode, response);
        }
    }
}