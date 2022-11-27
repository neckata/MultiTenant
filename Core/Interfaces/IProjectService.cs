using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProjectService
    {
        Task<Project> CreateAsync(string name, string description);

        Task<Project> GetByIdAsync(int id);

        Task<IReadOnlyList<Project>> GetAllAsync();
    }
}