using Core.Entities;
using Core.Wrapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProjectService
    {
        Task<IResult<Project>> CreateAsync(string name, string description);

        Task<IResult<Project>> GetByIdAsync(Guid id);

        Task<IResult<IReadOnlyList<Project>>> GetAllAsync();
    }
}