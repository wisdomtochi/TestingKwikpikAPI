﻿using TestingKwikpikAPI.Domain.Entities.CreateSingleRequest;

namespace TestingKwikpikAPI.Application.CreateSingleRequestRepo
{
    public interface ICreateSingleRequestAPI
    {
        Task<CreateSingleRequest> CreateSingleRequest(CreateSingleRequest CreateSingleRequestDTO);
    }
}
