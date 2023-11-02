﻿using STIMULUS_V2.Client.Services.Interfaces;
using STIMULUS_V2.Shared.Models.DTOs;
using STIMULUS_V2.Shared.Models.Entities;
using System.Net.Http.Json;

namespace STIMULUS_V2.Client.Services
{
    public class PageService : IModelService<Page, int>
    {
        private readonly HttpClient _httpClient;

        public PageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<APIResponse<Page>> Create(Page item)
        {
            var result = await _httpClient.PostAsJsonAsync<Page>("api/Page/Create", item);
            return await result.Content.ReadFromJsonAsync<APIResponse<Page>>();
        }

        public async Task<APIResponse<bool>> Delete(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/Page/Delete/{id}");
            return await result.Content.ReadFromJsonAsync<APIResponse<bool>>();
        }

        public async Task<APIResponse<Page>> Get(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<APIResponse<Page>>($"api/Page/Fetch/{id}");
            return result;
        }

        public async Task<APIResponse<IEnumerable<Page>>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<APIResponse<IEnumerable<Page>>>("api/Page/Fetch/All");
            return result;
        }

        public Task<APIResponse<IEnumerable<Page>>> GetFromParentId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<APIResponse<Page>> Update(int id, Page item)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/Page/Update/{id}", item);
            return await result.Content.ReadFromJsonAsync<APIResponse<Page>>();
        }
    }
}