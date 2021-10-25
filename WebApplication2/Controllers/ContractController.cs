using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;

namespace WebApplication2.Controllers
{
    public class ContractController : Controller
    {
        private readonly IContractService _service;

        public ContractController(IContractService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateNewContract()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContract([FromForm]Contract contract)
        {
            contract.EmployeeId = 1;
            await _service.Contract(contract);
            
            return Redirect("/Home/Index");
        }
        
    }
}
