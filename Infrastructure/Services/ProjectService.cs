using Core.Entities;
using Core.Interfaces;
using Core.Wrapper;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext _context;

        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IResult<Project>> CreateAsync(string name, string description)
        {
            var project = new Project(name, description);
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            return await Result<Project>.SuccessAsync(project);
        }

        public async Task<IResult<IReadOnlyList<Project>>> GetAllAsync()
        {
            var projects = await _context.Projects.ToListAsync();

            return await Result<IReadOnlyList<Project>>.SuccessAsync(projects);
        }

        public async Task<IResult<Project>> GetByIdAsync(int id)
        {
            var project = await _context.Projects.FindAsync(id);

            return await Result<Project>.SuccessAsync(project);
        }
    }
}