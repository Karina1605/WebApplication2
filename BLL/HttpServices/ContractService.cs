using BLL.Filters;
using BLL.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLL.HttpServices
{
    public class ContractService : IContractService
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task Contract(Contract contract)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Method = HttpMethod.Post;
            message.RequestUri = new Uri("https://localhost:44303/api/Contract/");
            message.Headers.Add("type", "application/json");
            message.Content = System.Net.Http.Json.JsonContent.Create<Contract>(contract);
            await _client.SendAsync(message);
        }

        public async Task<Contract> DeleteContract(int contractId)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Method = HttpMethod.Delete;
            message.RequestUri = new Uri($"https://localhost:44303/api/Contract/{contractId}");
            message.Headers.Add("type", "application/json");
            message.Content = System.Net.Http.Json.JsonContent.Create(new { ContractId = contractId});
            var res = await _client.SendAsync(message);
            var str = await res.Content.ReadAsStringAsync();
            var ops = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            var content = JsonSerializer.Deserialize<Contract>(str, ops);
            return content;
        }

        public async Task<ICollection<Contract>> GetAllContracts()
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri("https://localhost:44303/api/Contract");
            message.Headers.Add("type", "application/json");
            var res = await _client.SendAsync(message);
            if (!res.IsSuccessStatusCode)
                throw new Exception("Error code : " + res.StatusCode);
            var str = await res.Content.ReadAsStringAsync();
            var ops = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var content = JsonSerializer.Deserialize<ICollection<Contract>>(str, ops);
            return content;
        }

        public Task<ICollection<Contract>> GetContractByDate(ContractFilter expression)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Contract>> GetContractByFilter(Expression<Func<Contract, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<Contract> GetContractById(int contractId)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri("https://localhost:44303/api/Contract/" + contractId);
            message.Headers.Add("type", "application/json");
            var response = await _client.SendAsync(message);
            var json = await response.Content.ReadAsStringAsync();
            var ops = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            var res = JsonSerializer.Deserialize<Contract>(json, ops);
            //var res = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
            return res;
        }

        public async Task UpdateContract(Contract contract)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Method = HttpMethod.Put;
            message.RequestUri = new Uri($"https://localhost:44303/api/Contract/{contract.Id}");
            message.Headers.Add("type", "application/json");
            message.Content = System.Net.Http.Json.JsonContent.Create<Contract>(contract);
            await _client.SendAsync(message);
        }
    }
}
