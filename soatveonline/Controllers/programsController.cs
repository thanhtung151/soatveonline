﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using soatveonline.Model;
using HueFestival_OnlineTicket.Core.InterfaceService;
using HueFestival_OnlineTicket.ViewModel;

namespace soatveonline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class programsController : ControllerBase
    {
        private readonly IprogramsService programmeService;

        public programsController(IprogramsService _programmeService)
        {
            programmeService = _programmeService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(programsVM_Input input)
        {
            await programmeService.AddAsync(input);

            return Ok("Successfully");
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await programmeService.DeleteAsync(id);

            switch (result)
            {
                case 1:
                    return NotFound();
                case 2:
                    return Problem();
                case 3:
                    return Ok("Successfully");
                default:
                    return NoContent();
            }
        }

        [HttpGet("TieuDiem")]
        public async Task<IActionResult> GetAllTieuDiem()
            => Ok(await programmeService.GetAllByTypeProgramAsync(1));

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
            => Ok(await programmeService.GetAllAsync());

        [HttpGet("CongDong")]
        public async Task<IActionResult> GetAllCongDong()
            => Ok(await programmeService.GetAllByTypeProgramAsync(3));

        [HttpGet("Details")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var result = await programmeService.GetDetailsAsync(id);

            if (result != null)
                return Ok(result);

            return NotFound();
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> Edit(int id, programsVM_Input input)
        {
            var result = await programmeService.UpdateAsync(id, input);

            switch (result)
            {
                case 1:
                    return NotFound();
                case 2:
                    return Problem();
                case 3:
                    return Ok("Successfully");
                default:
                    return NoContent();
            }
        }
    }
}
