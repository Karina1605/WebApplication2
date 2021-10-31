using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Interfaces;
using Domain.Entities;
using WebApi.Models;
using Microsoft.AspNetCore.Cors;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _contractService;

        public ContractController(IContractService contractService)
        {
            this._contractService = contractService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contracts = await this._contractService.GetAllContracts();
            return Ok(contracts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var res = await this._contractService.GetContractById(id);
            if (res == null)
                return NotFound();
            return Ok(res);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromBody]DeleteContractModel request)
        {
            var res = await this._contractService.DeleteContract(request.ContractId);
            return Ok(res);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody]Contract contract)
        {
            await this._contractService.UpdateContract(contract);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddClient([FromBody]Contract contract)
        {
            await this._contractService.Contract(contract);
            return Ok();
        }
    }
}
