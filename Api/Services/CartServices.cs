﻿using EccomercePage.Api.Interfaces;
using EccomercePage.Data.DTO.CartDTO;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace EccomercePage.Api.Services
{
    public class CartServices : IRepository<CartReponseDTO, AddProductCartDTO, UpdateCartDTO>
    {
        private readonly string api = "api/cart";
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions jsonSerializerOptions =
          new()
          {
              PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
          };

        public CartServices(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("Auth");
        }

        public List<string> Errors => throw new NotImplementedException();

        public Task<CartReponseDTO> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartReponseDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CartReponseDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CartReponseDTO> InsertAsync(AddProductCartDTO insertDTO)
        {
            var response = await _httpClient.PostAsJsonAsync(api, insertDTO, jsonSerializerOptions);
            var CartResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CartReponseDTO>(CartResponse, jsonSerializerOptions) ?? new CartReponseDTO();
        }

        public Task<CartReponseDTO> UpdateAsync(int id, UpdateCartDTO updateDTO)
        {
            throw new NotImplementedException();
        }

        public bool Validate(AddProductCartDTO dto)
        {
            throw new NotImplementedException();
        }

        public bool Validate(UpdateCartDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
