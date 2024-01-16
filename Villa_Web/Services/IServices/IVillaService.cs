﻿using Villa_Web.Models;

namespace Villa_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id,string token);
        Task<T> CreateAsync<T>(VillaCreateDTO entity, string token);
        Task<T> UpdateAsync<T>(VillaUpdateDTO entity, string token);
        Task<T> DeleteAsync<T>(int id, string token);

    }
}
