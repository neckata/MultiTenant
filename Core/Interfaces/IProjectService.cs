using Core.Entities;
using Core.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProjectService
    {
        Task<IResult<Project>> CreateAsync(string name, string description);

        Task<IResult<Project>> GetByIdAsync(int id);

        Task<IResult<IReadOnlyList<Project>>> GetAllAsync();
    }
}