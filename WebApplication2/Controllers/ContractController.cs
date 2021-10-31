using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using WebApplication2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication2.Controllers
{
    public class ContractController : Controller
    {
        private readonly IContractService _service;
        private readonly IBargainTypeService _bargainTypeService;
        private readonly IClientService _clientService;
        private readonly IRealEstateService _realEstateService;

        public ContractController(
            IContractService service,  
            IBargainTypeService bargainTypeService,
            IClientService clientService,
            IRealEstateService realEstateService)
        {
            _service = service;
            _bargainTypeService = bargainTypeService;
            _clientService = clientService;
            _realEstateService = realEstateService;
        }

        public async Task<IActionResult> Index()
        {
            var contracts = await _service.GetAllContracts();
            return View("AllContracts", contracts);
        }

        [HttpGet]
        public async Task<IActionResult> CreateNewContract()
        {
            return View(new CreateNewContractModel()
            {
                Contract = new Contract(),
                Clients = (await _clientService.GetAllClients()).Select(e => new SelectListItem() { Value =e.Id.ToString(), Text = e.FIO}),
                BargainTypes = (await _bargainTypeService.GetAllBargainTypes()).Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.Name }),
                RealEstates = (await _realEstateService.GetAllRealEstates()).Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.Address }),
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateContract([FromForm]Contract contract)
        {
            contract.EmployeeId = 1;
            await _service.Contract(contract);
            
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await this._service.DeleteContract(id);
            return View("AllContracts", await this._service.GetAllContracts());
        }

    }
}
