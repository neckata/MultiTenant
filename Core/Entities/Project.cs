using Core.Contracts;
using System;

namespace Core.Entities
{
    public class Project : IEntity<Guid>, ITenant
    {
        public Project(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string TenantId { get; set; }
    }
}