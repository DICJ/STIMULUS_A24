﻿using Microsoft.AspNetCore.Mvc;
using STIMULUS_V2.Shared.Interface.ChildInterface;
using STIMULUS_V2.Shared.Models.Entities;

namespace STIMULUS_V2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportanceController : Controller
    {
        private readonly IImportanceService importanceService;

        public ImportanceController(IImportanceService importanceService)
        {
            this.importanceService = importanceService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Importance importance)
        {
            var response = await importanceService.Create(importance);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await importanceService.Delete(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await importanceService.Get(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/All")]
        public async Task<IActionResult> GetAll()
        {
            var response = await importanceService.GetAll();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/All/{id}")]
        public async Task<IActionResult> GetAllById(int id)
        {
            var response = await importanceService.GetAllById(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Importance importance)
        {
            var response = await importanceService.Update(id, importance);
            return StatusCode(response.StatusCode, response);
        }
    }
}
